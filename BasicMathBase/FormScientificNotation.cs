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
    public partial class FormScientificNotation : Form
    {
        public FormScientificNotation()
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
            double num = 0;
            string userAnswer = txtboxAnwser.Text;
            bool run = true;
            try
            {
                num = Convert.ToDouble(txtboxN.Text);
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
                string sistemAnswer = MathMethods.ScientficNotation(num);
                

                bool isCorrect = MathMethods.Correction(userAnswer, sistemAnswer);

                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxN.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
