﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathBase
{
    public partial class FormPrimosCrivo : Form
    {
        public FormPrimosCrivo()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            
        }


        private void btn_Lista_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxLista.Text = "";
                long upToNum = Convert.ToInt64(txtBox_atePrimo.Text);
                int tam = (Convert.ToString(upToNum)).Length + 2;
                long last = 0;

                int[] c = new int[] { 7, 11, 13, 17, 19, 23, 29, 31 };

                int upToLine = (Convert.ToInt32((upToNum - 31) / 30)) + 1;

                var nonPrimeNumTextBox = new List<int>();
                for (int i = 0; i < upToLine; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int num = (c[j]) + (30 * i);
                        richTextBoxLista.Text += String.Format("{0," + tam + "}\t", num);
                        if (!IsPrime(num))
                        {
                            nonPrimeNumTextBox.Add(richTextBoxLista.TextLength);
                        }
                        last = num;
                    }
                    richTextBoxLista.Text += Environment.NewLine;
                    richTextBoxLista.Text += Environment.NewLine;
                }
                foreach (var nonPrimePosition in nonPrimeNumTextBox)
                {
                    richTextBoxLista.Select(nonPrimePosition - 5, 5);
                    richTextBoxLista.SelectionColor = Color.Red;
                }
            }
            catch{
                MessageBox.Show("Insira um Número Inteiro Válido até " + Int64.MaxValue,
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            
        }

        public bool IsPrime(int num)
        {
            for (int a = 2; a <= num / 2; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }

            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxLista.Text = "";
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Create an instance of our printer class
            PCPrint printer = new PCPrint();
            //Set the font we want to use
            printer.PrinterFont = new Font("Arial", 10);
            //Set the TextToPrint property
            printer.TextToPrint = richTextBoxLista.Text;
            //Issue print command
            printer.Print();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gerandolbl_Click(object sender, EventArgs e)
        {

        }
    }
}
