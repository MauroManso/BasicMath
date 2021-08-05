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
    public partial class FormMultiplyMatrixAlgorithm : Form
    {
        public FormMultiplyMatrixAlgorithm()
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
            int factor1 = 0;
            int factor2 = 0;
            string userAnswer = "";
            try
            {
                factor1 = Convert.ToInt32(txtboxFactor1.Text);
                factor2 = Convert.ToInt32(txtboxFactor2.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            try
            {
                userAnswer = txtboxAnwser.Text;
            }
            catch { }


            if(Convert.ToString(factor1).Length != 2 || Convert.ToString(factor2).Length != 3)
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else if(factor1 > 0 && factor2 > 0)
            {
                var sistemAnswer = MathMethods.MatrixMultiplyAlgorithm(factor1, factor2);

                bool isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswer.numberResult));

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, sistemAnswer.outputString);
                openForm.Show();
            }  
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Clear();
            txtboxFactor1.Clear();
            txtboxFactor2.Clear();
        }
    }
}
