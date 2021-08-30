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
    public partial class FormMultiplyPowerSameBase : Form
    {
        public FormMultiplyPowerSameBase()
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
            long powerBase = 0;
            long expoent1 = 0;
            long expoent2 = 0;
            string userAnswer = "";
            bool run = true;
            try
            {
                powerBase = Convert.ToInt64(txtboxBase.Text);
                expoent1 = Convert.ToInt64(txtboxExpoent1.Text);
                expoent2 = Convert.ToInt64(txtboxExpoent2.Text);
                userAnswer = txtboxAnwser.Text;
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
                string sistemAnswer = $"{powerBase} ^ {(expoent1 + expoent2)} = " + MathMethods.ToPower(powerBase, (expoent1 + expoent2));

                bool isCorrect1 = MathMethods.Correction(userAnswer, MathMethods.ToPower(powerBase, (expoent1 + expoent2)));
                bool isCorrect2 = MathMethods.Correction(userAnswer, $"{ powerBase}^{ (expoent1 + expoent2)}");
                bool isCorrect = false;
                if (isCorrect1 || isCorrect2) isCorrect = true;

                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxBase.Text = "";
            txtboxExpoent1.Text = "";
            txtboxExpoent2.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t MULTIPLICAÇÃO DE POTÊNCIAS DE MESMA BASE\n\n\n";
            info += "\t i₁ bᵉ¹.bᵉ² = bᵉ¹⁺ᵉ²  Multiplicação de potências de mesma base. Converva-se a base e somam-se os expoentes.\n\n";
            info += "\t i₂ EXEMPLO:  2⁵.2³ = 2⁵⁺³ = 2⁸ = 256\n\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
