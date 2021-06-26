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

            string answer = Convert.ToString(MathMethods.Mmc(a, b));

            if (txtboxAnwserMmc.Text == answer)
            {
                FormRespostas openForm = new FormRespostas(true, answer);
                openForm.Show();
            }
            else
            {
                FormRespostas openForm = new FormRespostas(false, answer);
                openForm.Show();
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
            

            if (checkboxAlgoritmoEuclides.Checked)
            {
                string answer = MathMethods.MdcAlgoritmoEuclides(a, b);
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
                string answer = Convert.ToString(MathMethods.Mdc(a, b));

                if (txtboxAnwserMdc.Text == answer)
                {
                    FormRespostas openForm = new FormRespostas(true, answer);
                    openForm.Show();
                }
                else
                {
                    FormRespostas openForm = new FormRespostas(false, answer);
                    openForm.Show();
                }
            }
        }

        private void btnClearMdc_Click(object sender, EventArgs e)
        {
            txtboxMdcA.Text = "";
            txtboxMdcB.Text = "";
            txtboxAnwserMdc.Text = "";
        }
    }
}
