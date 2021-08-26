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
    public partial class FormFractionAddSubtraction : Form
    {
        public FormFractionAddSubtraction()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            radiobtnAdd.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int denominator = 0;
            int numerator = 0;
            int denominator2 = 0;
            int numerator2 = 0;
            float userAnswerNumerator = 0;
            float userAnswerDenominator = 0;
            bool run = true;

            try
            {
                denominator = Convert.ToInt32(txtboxDenominator.Text);
                numerator = Convert.ToInt32(txtboxNumerator.Text);
                denominator2 = Convert.ToInt32(txtboxDenominator2.Text);
                numerator2 = Convert.ToInt32(txtboxNumerator2.Text);
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
                userAnswerDenominator = Convert.ToInt64(txtboxAnswerDenominator.Text);
                userAnswerNumerator = Convert.ToInt64(txtboxAnswerNumerator.Text);
            }
            catch { }

            if (radiobtnSubtraction.Checked) numerator2 *= -1;

            if (run)
            {
                bool isCorrect = false;
                string answer = "";
                var systemAnswer = MathMethods.FractionAdd(numerator, denominator, numerator2, denominator2);

                var reductionFraction = MathMethods.FractionReduction(systemAnswer.numerator, systemAnswer.denominator);

                answer += $"{systemAnswer.numerator}/{systemAnswer.denominator}";
                if(reductionFraction.numerator != 0 && reductionFraction.denominator != 0) answer += " ou " + reductionFraction.reductions;

                if ((userAnswerNumerator == reductionFraction.numerator && userAnswerDenominator == reductionFraction.denominator) || (userAnswerNumerator == systemAnswer.numerator && userAnswerDenominator == systemAnswer.denominator)) isCorrect = true;

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, answer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxDenominator.Text = "";
            txtboxNumerator.Text = "";
            txtboxDenominator2.Text = "";
            txtboxNumerator2.Text = "";
            txtboxAnswerDenominator.Text = "";
            txtboxAnswerNumerator.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
