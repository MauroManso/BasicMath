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
    public partial class FormArithmeticsFunctions : Form
    {
        public FormArithmeticsFunctions()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;

        }

        private void btnCalculateTauN_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "" + MathMethods.TauN(Convert.ToInt64(txtboxTauN.Text));
                if (txtboxAnwserTauN.Text == answer)
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
            catch
            {
                MessageBox.Show("Insira um número válido",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnCalculateSigmaN_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "" + MathMethods.SigmaN(Convert.ToInt64(txtboxSigmaN.Text));
                if (txtboxAnswerSigmaN.Text == answer)
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
            catch
            {
                MessageBox.Show("Insira um número válido",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnCalculatePhiN_Click(object sender, EventArgs e)
        {
            try
            {
                string answer = "" + MathMethods.PhiN(Convert.ToInt64(txtboxPhiN.Text));
                if (txtboxAnswerPhiN.Text == answer)
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
            catch
            {
                MessageBox.Show("Insira um número válido",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnClearTauN_Click(object sender, EventArgs e)
        {
            txtboxTauN.Text = "";
            txtboxAnwserTauN.Text = "";
        }

        private void btnClearSigmaN_Click(object sender, EventArgs e)
        {
            txtboxSigmaN.Text = "";
            txtboxAnswerSigmaN.Text = "";
        }

        private void btnClearPhiN_Click(object sender, EventArgs e)
        {
            txtboxPhiN.Text = "";
            txtboxAnswerPhiN.Text = "";
        }
    }
}
