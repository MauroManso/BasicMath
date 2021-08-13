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
    public partial class FormPowerBase10Division : Form
    {
        public FormPowerBase10Division()
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
            double num1 = 0;
            double num2 = 0;
            int expoent1 = 0;
            int expoent2 = 0;

            string userAnswer = txtboxAnwser.Text;
            bool run = true;
            try
            {
                num1 = Convert.ToDouble(txtboxN1.Text);
                num2 = Convert.ToDouble(txtboxN2.Text);
                expoent1 = Convert.ToInt32(txtboxN1x10ToPowerOf.Text);
                expoent2 = Convert.ToInt32(txtboxN2x10ToPowerOf.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }

            if (run)
            {
                string sistemAnswer = MathMethods.DivisionScientficNotation(num1, num2, expoent1, expoent2);


                bool isCorrect = MathMethods.Correction(userAnswer, sistemAnswer);

                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxN1.Text = "";
            txtboxN1x10ToPowerOf.Text = "";
            txtboxN2.Text = "";
            txtboxN2x10ToPowerOf.Text = "";
        }
    }
}
