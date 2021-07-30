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
    public partial class FormPowerBase10Multiply : Form
    {
        public FormPowerBase10Multiply()
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxAnwser.Text = "";
            txtboxN1.Text = "";
            txtboxN1x10ToPowerOf.Text = "";
            txtboxN2.Text = "";
            txtboxN2x10ToPowerOf.Text = "";
        }
    }
}
