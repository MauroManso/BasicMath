using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using BasicMathBase.CalcMethods;

namespace BasicMathBase
{
    public partial class FormIsPrime : Form
    {
        public FormIsPrime()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;

        }

        private void btnVerifyPrime_Click(object sender, EventArgs e)
        {
            long num1;
            try
            {
                num1 = Convert.ToInt64(txtboxVerifyPrime.Text);
                if (num1 == 0 || num1 == 1)
                {
                    //lbl_RespostaPrimo.Text = ("\'" + num1 + "\' É um número composto");
                    MessageBox.Show("\'" + num1 + "\' É um número composto",
                                        "É primo?",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.None);
                }
                else
                {
                    if (MathMethods.IsPrime(num1))
                    {
                        //lbl_RespostaPrimo.Text = ("\'" + num1 + "\' É um número primo");
                        MessageBox.Show("\'" + num1 + "\' É um número primo",
                                        "É primo?",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.None);
                    }
                    else
                    {
                        //lbl_RespostaPrimo.Text = ("\'" + num1 + "\' É um número composto");
                        MessageBox.Show("\'" + num1 + "\' É um número composto",
                                        "É primo?",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.None);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Insira um Número Inteiro Válido até " + Int64.MaxValue,
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxVerifyPrime.Text = "";  
        }
    }
}
