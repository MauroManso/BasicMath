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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            panelMutiplyAlgorithmsSubMenu.Visible = false;
            panelPrimesSubMenu.Visible = false;
            panelPowersSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelMutiplyAlgorithmsSubMenu.Visible == true)
            {
                panelMutiplyAlgorithmsSubMenu.Visible = false;
                btnMutiplyAlgorithms.BackColor = Color.FromArgb(24, 30, 54);
            }
            if (panelPrimesSubMenu.Visible == true)
            {
                panelPrimesSubMenu.Visible = false;
                btnPrimes.BackColor = Color.FromArgb(24, 30, 54);
            }
            if (panelPowersSubMenu.Visible == true)
            {
                panelPowersSubMenu.Visible = false;
                btnPowers.BackColor = Color.FromArgb(24, 30, 54);
            }
                
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void btnMutiplyAlgorithms_Click(object sender, EventArgs e)
        {
            btnMutiplyAlgorithms.BackColor = Color.FromArgb(0, 60, 97);
            showSubMenu(panelMutiplyAlgorithmsSubMenu);
        }

        private void btnPrimes_Click(object sender, EventArgs e)
        {
            btnPrimes.BackColor = Color.FromArgb(0, 60, 97);
            showSubMenu(panelPrimesSubMenu);
        }

        private void btnPowers_Click(object sender, EventArgs e)
        {
            btnPowers.BackColor = Color.FromArgb(0, 60, 97);
            showSubMenu(panelPowersSubMenu);
        }

        private void btnNaturalAsPowerSum_Click(object sender, EventArgs e)
        {
            btnNaturalAsPowerSum.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormNaturalAsPowerSum());
        }

        private void btnMutiplyMatrixAlgorithm_Click(object sender, EventArgs e)
        {
            btnMutiplyMatrixAlgorithm.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormNaturalAsPowerSum());
        }

        private void btnMultiplyRussianAlgorithm_Click(object sender, EventArgs e)
        {
            btnMultiplyRussianAlgorithm.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormNaturalAsPowerSum());
        }

        private void btnMutiplyEgyptianAlgorithm_Click(object sender, EventArgs e)
        {
            btnMutiplyEgyptianAlgorithm.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormNaturalAsPowerSum());
        }

        private void btnMmcMdc_Click(object sender, EventArgs e)
        {
            btnMmcMdc.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormMmcMdc());
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            btnIsPrime.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormIsPrime());
        }

        private void btnPrimesList_Click(object sender, EventArgs e)
        {
            btnPrimesList.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormIsPrime());
        }

        private void btnPrimeSieve_Click(object sender, EventArgs e)
        {
            btnPrimeSieve.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormPrimeSieve());
        }

        private void btnNaturalAsPrimeProduct_Click(object sender, EventArgs e)
        {
            btnNaturalAsPrimeProduct.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormProductPrime());
        }


        private void btnPiX_Click(object sender, EventArgs e)
        {
            btnPiX.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormPiX());
        }

        private void btnArithmeticsFunction_Click(object sender, EventArgs e)
        {
            btnArithmeticsFunction.BackColor = Color.FromArgb(0, 60, 97);
            hideSubMenu();
            openChildForm(new FormArithmeticsFunctions());
        }

        private void btnToPowerOf_Click(object sender, EventArgs e)
        {
            btnToPowerOf.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormPower());
        }

        private void btnMutiplyPowerSameBase_Click(object sender, EventArgs e)
        {
            btnMutiplyPowerSameBase.BackColor = Color.FromArgb(0, 77, 123);
            openChildForm(new FormPower());
        }

        private void btnSubtractionAlgorithm_Click(object sender, EventArgs e)
        {
            btnSubtractionAlgorithm.BackColor = Color.FromArgb(0, 60, 97);
            hideSubMenu();
            openChildForm(new FormPower());
        }

        private void btnBModA_Click(object sender, EventArgs e)
        {
            btnBModA.BackColor = Color.FromArgb(0, 60, 97);
            hideSubMenu();
            openChildForm(new FormPower());
        }



        private void btnNaturalAsPowerSum_Leave(object sender, EventArgs e)
        {
            btnNaturalAsPowerSum.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnMutiplyMatrixAlgorithm_Leave(object sender, EventArgs e)
        {
            btnMutiplyMatrixAlgorithm.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnMultiplyRussianAlgorithm_Leave(object sender, EventArgs e)
        {
            btnMultiplyRussianAlgorithm.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnMutiplyEgyptianAlgorithm_Leave(object sender, EventArgs e)
        {
            btnMutiplyEgyptianAlgorithm.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnMmcMdc_Leave(object sender, EventArgs e)
        {
            btnMmcMdc.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnIsPrime_Leave(object sender, EventArgs e)
        {
            btnIsPrime.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnPrimesList_Leave(object sender, EventArgs e)
        {
            btnPrimesList.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnPrimeSieve_Leave(object sender, EventArgs e)
        {
            btnPrimeSieve.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnNaturalAsPrimeProduct_Leave(object sender, EventArgs e)
        {
            btnNaturalAsPrimeProduct.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnPiX_Leave(object sender, EventArgs e)
        {
            btnPiX.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnArithmeticsFunction_Leave(object sender, EventArgs e)
        {
            btnArithmeticsFunction.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnToPowerOf_Leave(object sender, EventArgs e)
        {
            btnToPowerOf.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnMutiplyPowerSameBase_Leave(object sender, EventArgs e)
        {
            btnMutiplyPowerSameBase.BackColor = Color.FromArgb(37, 35, 43);
        }

        private void btnSubtractionAlgorithm_Leave(object sender, EventArgs e)
        {
            btnSubtractionAlgorithm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBModA_Leave(object sender, EventArgs e)
        {
            btnBModA.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
