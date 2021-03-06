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
    public partial class FormOwnFraction : Form
    {
        public FormOwnFraction()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;

            lblPeriod.Visible = false;
            lblAntiPeriod.Visible = false;

            txtboxPeriod.Visible = false;
            txtboxAntiPeriod.Visible = false;

            lblDistinctPeriod.Visible = false;
            txtboxDistinctPeriod.Visible = false;

            lblK.Visible = false;
            txtboxK.Visible = false;

            radiobtnExactDecimal.Checked = true;

            checkboxCongruentMap.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int denominator = 0;
            int numerator = 0;
            float userAnswer = 0;
            bool run = true;

            try
            {
                denominator = Convert.ToInt32(txtboxDenominator.Text);
                numerator = Convert.ToInt32(txtboxNumerator.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }
            try
            {
                userAnswer = Convert.ToInt64(txtboxAnwser.Text);
            }
            catch { }

            if (numerator > denominator)
            {
                MessageBox.Show("O numerador deve ser menor que o denominador",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }

            if (run)
            {
                bool isCorrect = false;
                string answer = "";
                double systemAnswer = Convert.ToDouble(numerator) / Convert.ToDouble(denominator);
                bool isExactDecimal = false;
                bool isRepeatingDecimalSimple = false;
                bool isRepeatingDecimalComposite = false;

                if (denominator % 2 == 0 || denominator % 5 == 0)
                {
                    for(int i = 7; i < denominator/2; i++)
                    {
                        if (denominator % i  == 0)
                        {
                            isRepeatingDecimalComposite = true;
                            break;
                        }
                    }
                    if (!isRepeatingDecimalComposite)
                        isExactDecimal = true;
                }
                else
                    isRepeatingDecimalSimple = true;


                if (isExactDecimal)
                {
                    isCorrect = MathMethods.Correction(Convert.ToString(userAnswer), Convert.ToString(systemAnswer));
                    answer = $"\n\tResposta: {systemAnswer}";
                }
                else if (isRepeatingDecimalSimple)
                {
                    int period = 0;
                    int k = 0;
                    try
                    {
                        period = Convert.ToInt32(txtboxPeriod.Text);
                        k = Convert.ToInt32(txtboxK.Text);
                    }
                    catch { }

                    isCorrect = MathMethods.Correction(Convert.ToString(userAnswer), Convert.ToString(systemAnswer));

                    var systemAnswerPeriod = MathMethods.Period(numerator, denominator);

                    string systemAnswerPeriodString = "";
                    foreach (int i in systemAnswerPeriod)
                        systemAnswerPeriodString += $"{i}";

                    var congruentMap = MathMethods.CongruenceMap(denominator);

                    if (isCorrect)
                        isCorrect = MathMethods.Correction(Convert.ToString(k), Convert.ToString(systemAnswerPeriod.Length));
                    if (isCorrect)
                        isCorrect = MathMethods.Correction(Convert.ToString(period), systemAnswerPeriodString);

                    answer = $"\n\t Resposta: {systemAnswer} \n\n\t Periodo: {systemAnswerPeriodString} \n\n\t  K: {systemAnswerPeriod.Length} \n\n\t  Períodos distintos: {(denominator - 1) / systemAnswerPeriod.Length}";

                    if (checkboxCongruentMap.Checked)
                    {
                        answer += $"\n\n \t\tMapa de Congruencia: \n{congruentMap.Map}";
                    }
                }
                else if (isRepeatingDecimalComposite)
                {
                    int period = 0;
                    int k = 0;
                    try
                    {
                        period = Convert.ToInt32(txtboxPeriod.Text);
                        k = Convert.ToInt32(txtboxK.Text);
                    }
                    catch { }

                    isCorrect = MathMethods.Correction(Convert.ToString(userAnswer), Convert.ToString(systemAnswer));

                    var systemAnswerPeriod = MathMethods.Period(numerator, denominator);

                    string systemAnswerPeriodString = "";
                    foreach (int i in systemAnswerPeriod)
                        systemAnswerPeriodString += $"{i}";

                    var congruentMap = MathMethods.CongruenceMap(denominator);

                    if (isCorrect)
                        isCorrect = MathMethods.Correction(Convert.ToString(k), Convert.ToString(systemAnswerPeriod.Length));
                    if (isCorrect)
                        isCorrect = MathMethods.Correction(Convert.ToString(period), systemAnswerPeriodString);

                    answer = $"isRepeatingDecimalComposite\n\t Resposta: {systemAnswer} \n\n\t Periodo: {systemAnswerPeriodString} \n\n\t  K: {systemAnswerPeriod.Length} ";

                    if (checkboxCongruentMap.Checked)
                    {
                        answer += $"\n\n \t\tMapa de Congruencia: \n{congruentMap.Map}";
                    }
                }

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, answer);
                openForm.Show();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxDenominator.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radiobtnExactDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnExactDecimal.Checked){

            }
        }

        private void radiobtnRepeatingDecimalSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnRepeatingDecimalSimple.Checked)
            {
                lblK.Visible = true;
                txtboxK.Visible = true;

                lblPeriod.Visible = true;
                txtboxPeriod.Visible = true;

                lblDistinctPeriod.Visible = true;
                txtboxDistinctPeriod.Visible = true;

                checkboxCongruentMap.Visible = true;


                lblAntiPeriod.Visible = false;
                txtboxAntiPeriod.Visible = false;
            }
            else
            {
                lblK.Visible = false;
                txtboxK.Visible = false;

                lblPeriod.Visible = false;
                txtboxPeriod.Visible = false;

                lblDistinctPeriod.Visible = false;
                txtboxDistinctPeriod.Visible = false;

                checkboxCongruentMap.Visible = false;

                lblAntiPeriod.Visible = false;
                txtboxAntiPeriod.Visible = false;
            }
        }

        private void radiobtnRepeatingDecimalComposite_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnRepeatingDecimalComposite.Checked)
            {
                lblK.Visible = true;
                txtboxK.Visible = true;

                lblPeriod.Visible = true;
                txtboxPeriod.Visible = true;

                lblDistinctPeriod.Visible = true;
                txtboxDistinctPeriod.Visible = true;

                lblAntiPeriod.Visible = true;
                txtboxAntiPeriod.Visible = true;
                
            }
            else
            {
                lblK.Visible = false;
                txtboxK.Visible = false;

                lblPeriod.Visible = false;
                lblAntiPeriod.Visible = false;

                lblDistinctPeriod.Visible = false;
                txtboxDistinctPeriod.Visible = false;

                txtboxAntiPeriod.Visible = false;
                txtboxPeriod.Visible = false;

            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
