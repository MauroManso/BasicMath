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


          /*if(Convert.ToString(factor1).Length != 3 && Convert.ToString(factor2).Length != 3)
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else*/ 
            if(factor1 > 0 && factor2 > 0)
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t ALGORITIMO DE MULTIPLICAÇÃO POR MATRIZ\n\n\n";
            info += "\t i₁ OS FATORES PRECISAM TER O MESMO NÚMERO DE DÍGITOS. CASO NECESSÁRIO COMPLEMENTAR COM ZEROS À ESQUERDA. \n\n";
            info += "\t i₂ EXEMPLO:\n";
            info += "\t\t     0     3     4\n";
            info += "\t\t 1  00  03  04\n";
            info += "\t\t 2  00  06  08\n";
            info += "\t\t 3  00  09  12\n\n\n";
            info += "\t\t     000612\n";
            info += "\t\t       0009\n";
            info += "\t\t       0308\n";
            info += "\t\t         04\n";
            info += "\t\t         00\n";
            info += "\t\t   ___________\n";
            info += "\t\t        4182\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
