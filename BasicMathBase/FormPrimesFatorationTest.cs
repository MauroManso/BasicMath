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
    public partial class FormPrimesFatorationTest : Form
    {
        public FormPrimesFatorationTest()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitlePrimePower.Left = (this.ClientSize.Width - lblTitlePrimePower.Size.Width) / 2;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            long num = 0;
            try
            {
                num = Convert.ToInt64(txtboxNum.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            if(num > 0)
            {
                decimal k = 0;
                string answer = "";
                try
                {
                    k = TestFatorationInPrimes(num);
                    answer += $"{k}";
                }
                catch {
                    answer += $"Error";
                }

                try
                {
                    answer += "\n" + MathMethods.ProductPrimeToString(Convert.ToInt64(k));
                }
                catch {
                    answer += "\n Error";
                }
                

                FormAnswers openForm = new FormAnswers(false, (answer));
                openForm.Show();
            }
        }

        private decimal Fatorial_Recursao(decimal numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * Fatorial_Recursao(numero - 1);
        }

        private decimal TestFatorationInPrimes(decimal n)
        {
            decimal k = 0;

            k = (Fatorial_Recursao(2 * n)) / (Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(n - 1))) * Fatorial_Recursao(n) );

            return k;
        }

        private void btnClearNum_Click(object sender, EventArgs e)
        {
            txtboxNum.Text = "";
        }
    }
}
