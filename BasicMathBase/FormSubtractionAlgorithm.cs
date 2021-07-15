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
    public partial class FormSubtractionAlgorithm : Form
    {
        public FormSubtractionAlgorithm()
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
            long minuend = 0;
            long subtrahend = 0;
            string userAnswer = "";
            bool run = true;
            try
            {
                minuend = Convert.ToInt64(txtboxMinuend.Text);
                subtrahend = Convert.ToInt64(txtboxSubtrahend.Text);
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
                var sistemAnswer = MathMethods.SubtractionAlgorithm(minuend, subtrahend);

                bool isCorrect = MathMethods.Correction(userAnswer, Convert.ToString(sistemAnswer.numberResult));

                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer.outputString);
                openForm.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxMinuend.Text = "";
            txtboxSubtrahend.Text = "";
        }
    }
}
