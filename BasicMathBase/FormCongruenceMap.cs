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
    public partial class FormCongruenceMap : Form
    {
        public FormCongruenceMap()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            richTextBoxMap.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool run = true;
            try
            {
                num = Convert.ToInt32(txtboxNum.Text);
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
                var sistemAnswer = MathMethods.CongruenceMap(num);
                richTextBoxMap.Visible = true;
                richTextBoxMap.Text = sistemAnswer.Map;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxNum.Text = "";
            richTextBoxMap.Text = "";

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
