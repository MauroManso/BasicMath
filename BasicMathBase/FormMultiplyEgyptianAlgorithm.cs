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
    public partial class FormMultiplyEgyptianAlgorithm : Form
    {
        public FormMultiplyEgyptianAlgorithm()
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
            string answer = $"Fator 1 = {factor1}\n Fator 2 = {factor2} \n";
            if (factor1 > 0 && factor2 > 0)
            {
                var sistemAnswer = MathMethods.EgyptianMultiplyAlgorithm(factor1, factor2);
                answer += sistemAnswer.outputString;

                bool isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswer.numberResult));

                FormAnswerTxtBox openForm = new FormAnswerTxtBox(isCorrect, answer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxFactor1.Text = "";
            txtboxFactor2.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t ALGORITIMO EGÍPCCIO DE MULTIPLICAÇÃO\n\n\n";
            info += "\t i₁:  TODO NÚMERO NATURAL PODE SER ESCRITO COMO SOMA DE POTÊNCCIAS DE BASE 2.";
            info += " CONSTRUA UMA COLUNA À ESQUERDA COM AS POTÊNCIAS DE BASE 2 À PARTIR DO 1 (2⁰). CONSTRUA UMA COLUNA, A PARTIR DE UM DOS FATORES À DIREITA.";
            info += " CONSTRUA CADA LINHA MULTIPLICANDO A LINHA ANTERIOR POR 2.";
            info += " MARQUE OS VALORES DA ESQUERDA, CUJA SOMA SEJA IGUAL AO SEGUNDO FATOR, O RESULTADO DA F₁.F₂ SERÁ A SOMA DOS VALORES DA COLUNA DA DIREITA, DAS LINHAS MARCADAS.\n\n";
            info += "\t i₂ EXEMPLO:      34.123\n\n";
            info += "\t\t 1 \t 34\n";
            info += "\t\t 2 \t 68\n";
            info += "\t\t 4 \t 136    --\n";
            info += "\t\t 8 \t 272\n";
            info += "\t\t 16 \t 544\n";
            info += "\t\t 32 \t 1088\n";
            info += "\t\t 64 \t 2176\n";
            info += "\t\t____\t ______\n";
            info += "\t\t 123 \t  4182\n\n";
            info += "\t\t 1 \t 123     --\n";
            info += "\t\t 2 \t 246\n";
            info += "\t\t 4 \t 492     --\n";
            info += "\t\t 8 \t 984     --\n";
            info += "\t\t 16 \t 1968   --\n";
            info += "\t\t 32 \t 3936\n";
            info += "\t\t____\t ______\n";
            info += "\t\t 34 \t  4182\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
