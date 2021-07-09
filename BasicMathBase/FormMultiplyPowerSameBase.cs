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
            }

            string sistemAnswer = $"{powerBase} ^ {(expoent1 + expoent2)} = " + MathMethods.ToPower(powerBase, (expoent1 + expoent2));

            bool isCorrect = MathMethods.Correction(userAnswer, sistemAnswer);

            FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
            openForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxBase.Text = "";
            txtboxExpoent1.Text = "";
            txtboxExpoent2.Text = "";
        }
    }
}
