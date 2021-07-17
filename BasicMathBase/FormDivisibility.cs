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
    public partial class FormDivisibility : Form
    {
        public FormDivisibility()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            richtxtboxMultiplicationTable.Visible = false;
            radiobtnDivisionExact.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long dividend = 0;
            long divisor = 0;
            string userAnswer;
            bool run = true;
            try
            {
                dividend = Convert.ToInt64(txtboxDividend.Text);
                divisor = Convert.ToInt64(txtboxDivisor.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }
            userAnswer = txtboxQuotient.Text;

            if (run)
            {
                long sistemAnswerRest;
                long sistemAnswerQuotient;
                float sistemAnswerQuotientNonExact;
                bool isCorrect = false;
                string sistemAnswer = "";
                try
                {
                    if (radiobtnDivisionExact.Checked)
                    {
                        sistemAnswerRest = dividend % divisor;
                        sistemAnswerQuotient = dividend / divisor;
                        isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswerQuotient));
                        sistemAnswer = "Quociente = " + Convert.ToString(sistemAnswerQuotient) + "\nResto =  " + Convert.ToString(sistemAnswerRest);
                    }
                    else
                    {
                        sistemAnswerQuotientNonExact = dividend / divisor;
                        isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswerQuotientNonExact));
                        sistemAnswer = Convert.ToString(sistemAnswerQuotientNonExact);
                    }
                }
                catch { }

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, sistemAnswer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxDividend.Text = "";
            txtboxDivisor.Text = "";
            txtboxQuotient.Text = "";
            txtboxRest.Text = "";
            richtxtboxMultiplicationTable.Text = "";
            richtxtboxMultiplicationTable.Visible = false;
            radiobtnDivisionExact.Checked = true;
            radiobtnDivisionNonExact.Checked = false;
        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            long divisor = 0;
            try
            {
                divisor = Convert.ToInt64(txtboxDivisor.Text);
            }catch{

            }
            
            if (divisor > 0)
            {
                richtxtboxMultiplicationTable.Text = MathMethods.MultiplicationTable(divisor);
                richtxtboxMultiplicationTable.Visible = true;
            }
        }
    }
}
