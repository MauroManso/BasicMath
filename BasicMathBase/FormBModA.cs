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
    public partial class FormBModA : Form
    {
        public FormBModA()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            label1.Text = "";
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            bool run = true;
            try
            {
                a = Convert.ToInt32(txtboxA.Text);
                b = Convert.ToInt32(txtboxB.Text);

            }
            catch
            {
                MessageBox.Show("Insira um número válido",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }
            if (a <= 1)
            {
                MessageBox.Show("Insira um valor para 'a' > 1",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                run = false;
            }

            if (run)
            {
                string result = MathMethods.InversoBmodA(a, b);

                label1.Text = result;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            txtboxA.Text = "";
            txtboxB.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t b⁻¹ mod a\n\n\n";
            info += "\t i₁ b⁻¹ mod a calcula o inverso multiplicativo de b mod a ou seja: encontra b⁻¹ de modo que b⁻¹.b ≡ 1 (mod a) condição necessária e suficiente para a existência de b⁻¹ mod a: mdc(a,b) = 1 a,b ∈ N, a > b. \n\n";
            info += "\t i₂ EXEMPLO:  7⁻¹ mod 10 = 3.\n\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
