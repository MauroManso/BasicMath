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
    public partial class FormRespostaTable : Form
    {
        public FormRespostaTable(bool isCorrect, string answer)
        {
            InitializeComponent();
            customizeDesign(isCorrect, answer);

        }

        private void customizeDesign(bool isCorrect, string answer) 
        {
            if (isCorrect == true)
            {
                lblAcerto.Text = "Resposta Correta!";
                lblAcerto.Left = (this.ClientSize.Width - lblAcerto.Size.Width) / 2;
                btnObterResposta.Visible = false;
            }
            else
            {
                lblAcerto.Text = "Resposta Incorreta :(";
                lblAcerto.Left = (this.ClientSize.Width - lblAcerto.Size.Width) / 2;
                btnObterResposta.Visible = true;
            }
            
            tlbOrdemClase.Visible = false;
            lbl_Unidades.Visible = false;
            lbl_Milhares.Visible = false;
            lbl_Milhões.Visible = false;

            int control = 0;
            for (int i = (answer.Length - 1); i >= 0; i--)
            {
                if (control == 0)
                {
                    lbl_uUnidades.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 1)
                {
                    lbl_dUnidades.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 2)
                {
                    lbl_cUnidades.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 3)
                {
                    lbl_uMilhares.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 4)
                {
                    lbl_dMilhares.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 5)
                {
                    lbl_cMilhares.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 6)
                {
                    lbl_uMilhoes.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 7)
                {
                    lbl_dMilhoes.Text = answer[i].ToString();
                    control++;
                }
                else if (control == 8)
                {
                    lbl_cMilhoes.Text = answer[i].ToString();
                    control++;
                }
            }
        }

        private void btnObterResposta_Click(object sender, EventArgs e)
        {
            tlbOrdemClase.Visible = true;
            lbl_Unidades.Visible = true;
            lbl_Milhares.Visible = true;
            lbl_Milhões.Visible = true;
        }
    }
}
