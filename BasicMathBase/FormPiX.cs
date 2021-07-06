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
    public partial class FormPix : Form
    {
        public FormPix()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            lblApproximatePiX.Visible = false;
            lblRealPiX.Visible = false;
            lblAcuratePiX.Visible = false;
            lblApproximatePiXAnswer.Visible = false;
            lblRealPiXAnswer.Visible = false;
            lblAcuratePiXAnswer.Visible = false;

            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
        }

        private void btnCalculatePix_Click(object sender, EventArgs e)
        {
            long x = Convert.ToInt64(txtboxPix.Text);
            lblApproximatePiXAnswer.Text = "" + MathMethods.ApproximatePiX(x);
            lblRealPiXAnswer.Text = "" + MathMethods.RealPiX(x);
            lblAcuratePiXAnswer.Text = "" + MathMethods.AcuratePiX(x) + "%";

            lblApproximatePiX.Visible = true;
            lblRealPiX.Visible = true;
            lblAcuratePiX.Visible = true;
            lblApproximatePiXAnswer.Visible = true;
            lblRealPiXAnswer.Visible = true;
            lblAcuratePiXAnswer.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxPix.Text = "";
            lblApproximatePiX.Visible = false;
            lblRealPiX.Visible = false;
            lblAcuratePiX.Visible = false;
            lblApproximatePiXAnswer.Visible = false;
            lblRealPiXAnswer.Visible = false;
            lblAcuratePiXAnswer.Visible = false;
        }
    }
}
