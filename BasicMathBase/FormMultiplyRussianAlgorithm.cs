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
    public partial class FormMultiplyRussianAlgorithm : Form
    {
        public FormMultiplyRussianAlgorithm()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long factor1 = 0;
            long factor2 = 0;
            string userAnswer = "";
            try
            {
                factor1 = Convert.ToInt64(txtboxFactor1.Text);
                factor2 = Convert.ToInt64(txtboxFactor2.Text);
                userAnswer = txtboxAnwser.Text;
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            if (factor1 > 0 && factor2 > 0)
            {
                var sistemAnswer = MathMethods.RussianMultiplyAlgorithm(factor1, factor2);

                bool isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswer.numberResult));

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, sistemAnswer.outputString);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxFactor1.Text = "";
            txtboxFactor2.Text = "";
        }
    }
}
