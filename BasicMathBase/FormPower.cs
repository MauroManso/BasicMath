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
    public partial class FormPower : Form
    {
        public FormPower()
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
            long baseExpoent = 0;
            long toPowerOf = 0;
            string userAnswer = "";
            try
            {
                baseExpoent = Convert.ToInt64(txtboxBase.Text);
                toPowerOf = Convert.ToInt64(txtboxToPowerOf.Text);
                userAnswer = txtboxAnwser.Text;
            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            string sistemAnswer = ToPower(baseExpoent, toPowerOf);

            bool isCorrect = MathMethods.Correction(userAnswer, sistemAnswer);

            FormRespostas openForm = new FormRespostas(isCorrect, sistemAnswer);
            openForm.Show();
        }

        private string ToPower(long baseExpoent, long toPowerOf)
        {
            string output = "";
            if (toPowerOf == 0) return "1";
            if (baseExpoent == 1) return "1";
            if (toPowerOf < 0)
            {
                toPowerOf *= -1;
                output += "1/";
            }

            long result = baseExpoent;
            for(int i = 0; i < (toPowerOf - 1); i++)
                result *= baseExpoent;

            output += $"{result}";
            return output;
        }
    }
}
