using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BasicMathBase
{
    public partial class FormIntegerNumbers : Form
    {
        public FormIntegerNumbers()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            radiobtnOposite.Checked = true;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                long number = Convert.ToInt64(txtboxInteger.Text);
                string userAnswer = txtboxAnwser.Text;
                string sistemAnswer = "";
                bool isCorrect = false;
                if (radiobtnOposite.Checked == true)
                {
                    sistemAnswer = Convert.ToString(number * -1);
                    if(sistemAnswer == userAnswer)
                    {
                        isCorrect = true;
                    }
                }
                else if (radiobtnMultipleInverse.Checked == true)
                {
                    sistemAnswer ="1/" + Convert.ToString(number);
                    if (sistemAnswer == txtboxAnwser.Text)
                    {
                        isCorrect = true;
                    }
                }
                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
                openForm.Show();
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxInteger.Text = "";
            txtboxAnwser.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
