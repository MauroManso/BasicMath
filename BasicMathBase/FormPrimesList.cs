using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicMathBase.CalcMethods;

namespace BasicMathBase
{
    public partial class FormPrimesList : Form
    {
        public FormPrimesList()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            lblNumberOfPrimes.Visible = false;
            lblTimeElapsed.Visible = false;
            lblPercentage.Visible = false;
            txtboxList.Text = "";
        }

        private async void btnListPrime_Click(object sender, EventArgs e)
        {
            customDesign();
            lblPercentage.Visible = true;

            long begin = 2;
            long end = 0;
            try
            {
                if (txtboxBeginPrime.Text != "")
                    begin = Convert.ToInt64(txtboxBeginPrime.Text);
                end = Convert.ToInt64(txtboxUpToPrime.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            if(end > 0)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                var result = await ListPrimeAsync(begin, end);

                watch.Stop();
                var elapsedS = watch.ElapsedMilliseconds;

                lblTimeElapsed.Text = $"Tempo de execução: {elapsedS}Ms";
                lblTimeElapsed.Visible = true;

                txtboxList.Text = result.primesList;

                lblNumberOfPrimes.Text = "Há " + result.numberOfPrimes + " números primos";
                lblNumberOfPrimes.Visible = true;
            }
        }

        private async Task<(string primesList, long numberOfPrimes)> ListPrimeAsync(long begin, long end)
        {
            string primesList = "";
            long numberOfPrimes = 0;

            int size = (Convert.ToString(begin)).Length + 2;
            for (long number = begin; number < end; number++)
            {
                bool isPrime = await Task.Run(() => MathMethods.IsPrime(number));
                if (isPrime)
                {
                    primesList += String.Format("{0," + size + "}\t", number);
                    numberOfPrimes++;
                }
                lblPercentage.Text = $"{((number * 100) / end)} %";
            }
            lblPercentage.Text = $"100 %";
            return (primesList, numberOfPrimes);
        }

        public class PCPrint : System.Drawing.Printing.PrintDocument
        {
            #region  Property Variables 
            /// <summary>
            /// Property variable for the Font the user wishes to use
            /// </summary>
            /// <remarks></remarks>
            private Font _font;

            /// <summary>
            /// Property variable for the text to be printed
            /// </summary>
            /// <remarks></remarks>
            private string _text;
            #endregion

            #region Static Local Variables
            /// <summary>
            /// Static variable to hold the current character
            /// we're currently dealing with.
            /// </summary>
            static int curChar;
            #endregion

            #region  Class Properties
            /// <summary>
            /// Property to hold the text that is to be printed
            /// </summary>
            /// <value></value>
            /// <returns>A string</returns>
            /// <remarks></remarks>
            public string TextToPrint
            {
                get { return _text; }
                set { _text = value; }
            }

            /// <summary>
            /// Property to hold the font the users wishes to use
            /// </summary>
            /// <value></value>
            /// <returns></returns>
            /// <remarks></remarks>
            public Font PrinterFont
            {
                // Allows the user to override the default font
                get { return _font; }
                set { _font = value; }
            }
            #endregion

            #region  Class Constructors 
            /// <summary>
            /// Empty constructor
            /// </summary>
            /// <remarks></remarks>
            public PCPrint() : base()
            {
                //Set the file stream
                //Instantiate out Text property to an empty string
                _text = string.Empty;
            }

            /// <summary>
            /// Constructor to initialize our printing object
            /// and the text it's supposed to be printing
            /// </summary>
            /// <param name=str>Text that will be printed</param>
            /// <remarks></remarks>
            public PCPrint(string str) : base()
            {
                //Set the file stream
                //Set our Text property value
                _text = str;
            }
            #endregion

            #region  OnBeginPrint 
            /// <summary>
            /// Override the default OnBeginPrint method of the PrintDocument Object
            /// </summary>
            /// <param name=e></param>
            /// <remarks></remarks>
            protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
            {
                // Run base code
                base.OnBeginPrint(e);

                //Check to see if the user provided a font
                //if they didnt then we default to Times New Roman
                if (_font == null)
                {
                    //Create the font we need
                    _font = new Font("Times New Roman", 10);
                }
            }
            #endregion

            #region  OnPrintPage 
            /// <summary>
            /// Override the default OnPrintPage method of the PrintDocument
            /// </summary>
            /// <param name=e></param>
            /// <remarks>This provides the print logic for our document</remarks>
            protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
            {
                // Run base code
                base.OnPrintPage(e);

                //Declare local variables needed

                int printHeight;
                int printWidth;
                int leftMargin;
                int rightMargin;
                Int32 lines;
                Int32 chars;

                //Set print area size and margins
                {
                    printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                    printWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                    leftMargin = base.DefaultPageSettings.Margins.Left;
                    //X
                    rightMargin = base.DefaultPageSettings.Margins.Top;
                    //Y
                }

                //Check if the user selected to print in Landscape mode
                //if they did then we need to swap height/width parameters
                if (base.DefaultPageSettings.Landscape)
                {
                    int tmp;
                    tmp = printHeight;
                    printHeight = printWidth;
                    printWidth = tmp;
                }

                //Now we need to determine the total number of lines
                //we're going to be printing
                Int32 numLines = (int)printHeight / PrinterFont.Height;

                //Create a rectangle printing are for our document
                RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);

                //Use the StringFormat class for the text layout of our document
                StringFormat format = new StringFormat(StringFormatFlags.LineLimit);

                //Fit as many characters as we can into the print area      

                e.Graphics.MeasureString(_text.Substring(RemoveZeros(curChar)), PrinterFont, new SizeF(printWidth, printHeight), format, out chars, out lines);

                //Print the page
                e.Graphics.DrawString(_text.Substring(RemoveZeros(curChar)), PrinterFont, Brushes.Black, printArea, format);

                //Increase current char count
                curChar += chars;

                //Detemine if there is more text to print, if
                //there is the tell the printer there is more coming
                if (curChar < _text.Length)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    curChar = 0;
                }
            }

            #endregion

            #region  RemoveZeros 
            /// <summary>
            /// Function to replace any zeros in the size to a 1
            /// Zero's will mess up the printing area
            /// </summary>
            /// <param name=value>Value to check</param>
            /// <returns></returns>
            /// <remarks></remarks>
            public int RemoveZeros(int value)
            {
                //Check the value passed into the function,
                //if the value is a 0 (zero) then return a 1,
                //otherwise return the value passed in
                switch (value)
                {
                    case 0:
                        return 1;
                    default:
                        return value;
                }
            }
            #endregion
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Create an instance of our printer class
            PCPrint printer = new PCPrint();
            //Set the font we want to use
            printer.PrinterFont = new Font("Arial", 10);
            //Set the TextToPrint property
            printer.TextToPrint = txtboxList.Text;
            //Issue print command
            printer.Print();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxList.Text = "";
            txtboxBeginPrime.Text = "";
            txtboxUpToPrime.Text = "";
            lblTimeElapsed.Visible = false;
            lblNumberOfPrimes.Visible = false;
            lblPercentage.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
