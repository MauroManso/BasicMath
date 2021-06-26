using BasicMathBase.CalcMethods;
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
    public partial class FormProductPrime : Form
    {
        public FormProductPrime()
        {
            InitializeComponent();
        }

        private void btnCorrectNum_Click(object sender, EventArgs e)
        {
            string answer1 = MathMethods.ProductPrime(Convert.ToInt32(txtboxNum.Text));
            string answer2 = MathMethods.ProductPrimeWithPower(Convert.ToInt32(txtboxNum.Text));

            if (txtboxResposta.Text == answer1 || txtboxResposta.Text == answer2)
            {
                FormRespostas openForm = new FormRespostas(true, (answer1 + " ou" + Environment.NewLine + answer2));
                openForm.Show();
            }
            else
            {
                FormRespostas openForm = new FormRespostas(false, (answer1 + " ou" + Environment.NewLine + answer2));
                openForm.Show();
            }
                

        }

        private void btnClearNum_Click(object sender, EventArgs e)
        {
            txtboxNum.Text = "";
            txtboxResposta.Text = "";
        }
    }
}
