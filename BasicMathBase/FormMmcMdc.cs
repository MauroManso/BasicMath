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
    public partial class FormMmcMdc : Form
    {
        public FormMmcMdc()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign() 
        {
            lblTitleMmcMdc.Left = (this.ClientSize.Width - lblTitleMmcMdc.Size.Width) / 2;
        }

        private void btnCorrectMmc_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(txtboxMmcA.Text);
                b = Convert.ToInt32(txtboxMmcB.Text);

            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            string answer = $"a = {a} b = {b} \n";
            if (a > 0 && b > 0)
            {
                answer = Convert.ToString(MathMethods.Mmc(a, b));

                if (txtboxAnwserMmc.Text == answer)
                {
                    FormAnswers openForm = new FormAnswers(true, answer);
                    openForm.Show();
                }
                else
                {
                    FormAnswers openForm = new FormAnswers(false, answer);
                    openForm.Show();
                }
            }
        }

        private void btnClearMmc_Click(object sender, EventArgs e)
        {
            txtboxMmcA.Text = "";
            txtboxMmcB.Text = "";
            txtboxAnwserMmc.Text = "";
        }

        private void btnCorrectMdc_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(txtboxMdcA.Text);
                b = Convert.ToInt32(txtboxMdcB.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            string answer = $"a = {a} b = {b} \n";
            if (a > 0 && b > 0)
            {
                if (checkboxAlgoritmoEuclides.Checked)
                {
                    answer += MathMethods.MdcAlgoritmoEuclides(a, b);
                    bool isCorrect = false;

                    if (txtboxAnwserMdc.Text == Convert.ToString(MathMethods.Mdc(a, b)))
                        isCorrect = true;

                    if (isCorrect)
                    {
                        FormAnswerTxtBox openForm = new FormAnswerTxtBox(true, answer);
                        openForm.Show();
                    }
                    else
                    {
                        FormAnswerTxtBox openForm = new FormAnswerTxtBox(false, answer);
                        openForm.Show();
                    }
                }
                else
                {
                    answer = Convert.ToString(MathMethods.Mdc(a, b));

                    if (txtboxAnwserMdc.Text == answer)
                    {
                        FormAnswers openForm = new FormAnswers(true, answer);
                        openForm.Show();
                    }
                    else
                    {
                        FormAnswers openForm = new FormAnswers(false, answer);
                        openForm.Show();
                    }
                }
            }
        }

        private void btnClearMdc_Click(object sender, EventArgs e)
        {
            txtboxMdcA.Text = "";
            txtboxMdcB.Text = "";
            txtboxAnwserMdc.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t MMC E MDC\n\n\n";
            info += "\t i₁ mmc: menor múltiplo comum entre a e b. a,b ∈ N.\n";
            info += "\t mdc: maior divisor comum entre a e b. a,b ∈ N.\n";
            info += "\t mmc = P₁^α.P₂^β...Pₙ^λ  que aparecem na fatoração simultânea de a e b.\n";
            info += "\t mdc = P₁^α.P₂^β...Pₙ^λ  Pₙ fator primo que divide simultaneamente a e b.\n";
            info += "\t mmc.mds = a.b\n\n";
            info += "\t i₂ EXEMPLO:\n\n";
            info += "\t\t 60, 32 \t| 2\n";
            info += "\t\t 30, 16 \t| 2\n";
            info += "\t\t 15,   8 \t| 2\n";
            info += "\t\t 15,   4 \t| 2\n";
            info += "\t\t 15,   2 \t| 2\n";
            info += "\t\t 15,   1 \t| 3\n";
            info += "\t\t   5,   1 \t| 5\n";
            info += "\t\t   1     \t| \n\n";
            info += "\t\tmmc = 2⁵.3.5 = 480\n";
            info += "\t\tmdc = 2²= 4\n\n\n";

            info += "\t i₃ ALGORITMO DE EUCLIDES: DIVISÕES SUCESSIVAS\n\n";
            info += "\t\t\t a₀\ta₁ ...\taₙ \t Linha dos quocientes \n";
            info += "\ta,\tb\tk₀\tk₁ ...\t0 \t Linha dos restos \n\n";
            info += "\t i₄ EXEMPLO:\n\n";
            info += "\t\t\t 1\t1\t7  \n";
            info += "\t60,\t32\t28\t4\t0 \t mdcc = 4 \n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
