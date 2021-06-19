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
            btnNaturalSomaPotencia.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPotencia10());

        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrimos.Height;
            pnlNav.Top = btnPrimos.Top;
            pnlNav.Left = btnPrimos.Left;
            btnPrimos.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPrimos());
        }

        private void btnSomaPrimos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSomaPrimos.Height;
            pnlNav.Top = btnSomaPrimos.Top;
            pnlNav.Left = btnSomaPrimos.Left;
            btnSomaPrimos.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new FormPrimosCrivo());
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAjuda.Height;
            pnlNav.Top = btnAjuda.Top;
            pnlNav.Left = btnAjuda.Left;
            btnAjuda.BackColor = Color.FromArgb(46, 51, 73);

            MessageBox.Show("\n     NÚMEROS NATURAIS COMO SOMA DE POTÊNCIAS DE BASE 10\n" +
                            "\n\t  Use \"^\" para representar expoentes" +
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

        private void btnAjuda_Leave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(24, 30, 54);
        }

        public Form1()
        {
            InitializeComponent();
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
