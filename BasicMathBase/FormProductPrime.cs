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
            string answer = MathMethods.ProductPrime(Convert.ToInt32(txtboxNum.Text));

            if(txtboxResposta.Text == answer)
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

        private void btnClearNum_Click(object sender, EventArgs e)
        {
            txtboxNum.Text = "";
            txtboxResposta.Text = "";
        }
    }
}
