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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t ALGORITIMO DE MULTIPLICAÇÃO RUSSO\n\n\n";
            info += "\t i₁:  CONSTRUA UMA COLUNA À ESQUERDA PARA O MENOR FATOR - FAÇA DIVISÕES SUCESSIVAS POPR 2, EXPRESSANDO SOMENTE O VALOR INTEIRO DA DIVISÃO ATÉ QUE SE OBTENHA O 1.\n";
            info += "\t CONSTRUA UMA COLUNA À DIREITA PARA O MAIOR FATOR - FAÇA MULTIPLICAÇÕES SUCESSIVAS POPR 2.\n";
            info += "\t ELIMINE AS LINHAS COM VALORES PARES DA COLUNA DO MENOR FATOR. O RESULTADO DE F₁.F₂ SERÁ A SOMA DOS VALORES DA COLUNA DO MAIOR FATOR DAS LINHAS NN ELIMINADAS\n\n";
            info += "\t i₂ EXEMPLO:\n";
            info += "\t\t 34 \t 123    --\n";
            info += "\t\t 17 \t 246\n";
            info += "\t\t  8 \t 492    --\n";
            info += "\t\t  4 \t 984    --\n";
            info += "\t\t  2 \t 1968  --\n";
            info += "\t\t  1 \t 3936\n";
            info += "\t\t _________________\n";
            info += "\t\t        4182\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
