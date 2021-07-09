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
            customDesign();
        }

        private void customDesign()
        {
            lblTitlePrimePower.Left = (this.ClientSize.Width - lblTitlePrimePower.Size.Width) / 2;
        }

        private void btnCorrectNum_Click(object sender, EventArgs e)
        {
            string answer = MathMethods.ProductPrimeToString(Convert.ToInt64(txtboxNum.Text));

            if (txtboxResposta.Text == answer)
            {
                FormAnswers openForm = new FormAnswers(true, (answer));
                openForm.Show();
            }
            else
            {
                FormAnswers openForm = new FormAnswers(false, (answer));
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
