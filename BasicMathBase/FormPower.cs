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
            long powerBase = 0;
            long expoent = 0;
            string userAnswer = "";
            bool run = true;
            try
            {
                powerBase = Convert.ToInt64(txtboxBase.Text);
                expoent = Convert.ToInt64(txtboxToPowerOf.Text);
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
            if(run)
            {
                string sistemAnswer = MathMethods.ToPower(powerBase, expoent);

                bool isCorrect = MathMethods.Correction(userAnswer, sistemAnswer);

                FormAnswers openForm = new FormAnswers(isCorrect, sistemAnswer);
                openForm.Show();
            }
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t POTÊNCIA\n\n\n";
            info += "\t i₁ bᵉ = b.b.b...b \tb:base\n";
            info += "\t \te vezes \te:expoente\n\n";
            info += "\t i₂ EXEMPLO:  2⁴ = 2.2.2.2 = 16\n\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
