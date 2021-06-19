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
    public partial class FormPotencia10Resposta : Form
    {
        private bool classeIsOn;
        private string resultSistem;
        private bool isCorrect;
        private bool paridadeIsOn;
        private bool isPar;
        private bool isParidadeCorrect;
        public FormPotencia10Resposta(bool classeIsOn1,string resultSistem1, bool isCorrect1, bool paridadeIsOn1, bool isPar1, bool isParidadeCorrect1)
        {
            InitializeComponent();
            classeIsOn = classeIsOn1;
            resultSistem = resultSistem1;
            isCorrect = isCorrect1;
            paridadeIsOn = paridadeIsOn1;
            isPar = isPar1;
            isParidadeCorrect = isParidadeCorrect1;

            customizeDesign();

        }

        private void customizeDesign() 
        {
            if (isCorrect == true)
            {
                lblAcerto.Text = "Resposta Correta!";
                int x = (984 - lblAcerto.Width) / 2;
                int y = ((569 - lblRespostaCorreta.Height) / 2) - 80;
                lblAcerto.Location = new Point(x, y);
                btnObterResposta.Visible = false;
            }
            else
            {
                lblAcerto.Text = "Resposta Incorreta :(";
                int x = (984 - lblAcerto.Width) / 2;
                int y = 30;
                lblAcerto.Location = new Point(x, y);
                btnObterResposta.Visible = true;
            }
            if (paridadeIsOn == true && isParidadeCorrect == false)
            {
                lblAcerto.Text = "Resposta Incorreta :(";
                int x = (984 - lblAcerto.Width) / 2;
                int y = 30;
                lblAcerto.Location = new Point(x, y);
                btnObterResposta.Visible = true;
            }
            
            lblParidade.Visible = false;
            lblRespostaCorreta.Visible = false;
            tlbOrdemClase.Visible = false;
            lbl_Unidades.Visible = false;
            lbl_Milhares.Visible = false;
            lbl_Milhões.Visible = false;
        }

        private void btnObterResposta_Click(object sender, EventArgs e)
        {
            if (classeIsOn == false && isCorrect == false)
            {
                lblRespostaCorreta.Text = resultSistem;
                int x = (984 - lblRespostaCorreta.Width) / 2;
                int y = (569 - lblRespostaCorreta.Height) / 2;
                lblRespostaCorreta.Location = new Point(x, y);
                lblRespostaCorreta.Visible = true;
            }
            else if (classeIsOn == true && isCorrect == false)
            {
                tlbOrdemClase.Visible = true;
                lbl_Unidades.Visible = true;
                lbl_Milhares.Visible = true;
                lbl_Milhões.Visible = true;

                int control = 0;
                for (int i = (resultSistem.Length - 1); i >= 0; i--)
                {
                    if (control == 0)
                    {
                        lbl_uUnidades.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 1)
                    {
                        lbl_dUnidades.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 2)
                    {
                        lbl_cUnidades.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 3)
                    {
                        lbl_uMilhares.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 4)
                    {
                        lbl_dMilhares.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 5)
                    {
                        lbl_cMilhares.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 6)
                    {
                        lbl_uMilhoes.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 7)
                    {
                        lbl_dMilhoes.Text = resultSistem[i].ToString();
                        control++;
                    }
                    else if (control == 8)
                    {
                        lbl_cMilhoes.Text = resultSistem[i].ToString();
                        control++;
                    }
                }
            }

            if (paridadeIsOn == true && isParidadeCorrect == false)
            {
                if (isPar == true)
                    lblParidade.Text = "O número é par";
                else
                    lblParidade.Text = "O número é impar";
                lblParidade.Visible = true;
            }
        }
    }
}
