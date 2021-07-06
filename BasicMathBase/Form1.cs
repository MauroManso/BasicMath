using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BasicMathBase
{
    public partial class Form1 : Form
    {

        private void BtnNaturalSomaPotencia_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNaturalSomaPotencia.Height;
            pnlNav.Top = btnNaturalSomaPotencia.Top;
            pnlNav.Left = btnNaturalSomaPotencia.Left;
            pnlNav.Visible = true;
            btnNaturalSomaPotencia.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPotencia10());

        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrimos.Height;
            pnlNav.Top = btnPrimos.Top;
            pnlNav.Left = btnPrimos.Left;
            pnlNav.Visible = true;
            btnPrimos.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPrimos());
        }

        private void btnSomaPrimos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSomaPrimos.Height;
            pnlNav.Top = btnSomaPrimos.Top;
            pnlNav.Left = btnSomaPrimos.Left;
            pnlNav.Visible = true;
            btnSomaPrimos.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPrimosCrivo());
        }

        private void btnPrimePower_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrimePower.Height;
            pnlNav.Top = btnPrimePower.Top;
            pnlNav.Left = btnPrimePower.Left;
            pnlNav.Visible = true;
            btnPrimePower.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormProductPrime());
        }

        private void btnMmcMdc_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMmcMdc.Height;
            pnlNav.Top = btnMmcMdc.Top;
            pnlNav.Left = btnMmcMdc.Left;
            pnlNav.Visible = true;
            btnMmcMdc.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormMmcMdc());
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPix.Height;
            pnlNav.Top = btnPix.Top;
            pnlNav.Left = btnPix.Left;
            pnlNav.Visible = true;
            btnPix.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPix());
        }

        private void btnArithmeticsFunctions_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnArithmeticsFunctions.Height;
            pnlNav.Top = btnArithmeticsFunctions.Top;
            pnlNav.Left = btnArithmeticsFunctions.Left;
            pnlNav.Visible = true;
            btnArithmeticsFunctions.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormArithmeticsFunctions());
        }
        private void btnIntegerNumbers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnIntegerNumbers.Height;
            pnlNav.Top = btnIntegerNumbers.Top;
            pnlNav.Left = btnIntegerNumbers.Left;
            pnlNav.Visible = true;
            btnIntegerNumbers.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormIntegerNumbers());
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAjuda.Height;
            pnlNav.Top = btnAjuda.Top;
            pnlNav.Left = btnAjuda.Left;
            pnlNav.Visible = true;
            btnAjuda.BackColor = Color.FromArgb(46, 51, 73);

            MessageBox.Show("\n\t  Use \"^\" para representar expoentes" +
                            "\n\t  Use \". (Ponto)\" para operações de multiplicação");
        }

        private void btnNaturalSomaPotencia_Leave(object sender, EventArgs e)
        {
            btnNaturalSomaPotencia.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPrimos_Leave(object sender, EventArgs e)
        {
            btnPrimos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSomaPrimos_Leave(object sender, EventArgs e)
        {
            btnSomaPrimos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPrimePower_Leave(object sender, EventArgs e)
        {
            btnPrimePower.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMmcMdc_Leave(object sender, EventArgs e)
        {
            btnMmcMdc.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPix_Leave(object sender, EventArgs e)
        {
            btnPix.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnArithmeticsFunctions_Leave(object sender, EventArgs e)
        {
            btnArithmeticsFunctions.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIntegerNumbers_Leave(object sender, EventArgs e)
        {
            btnIntegerNumbers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAjuda_Leave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(24, 30, 54);
        }

        public Form1()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            pnlNav.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
