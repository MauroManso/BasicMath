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
    public partial class FormPotencia10 : Form
    {
        public FormPotencia10()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            tlbOrdemClase.Visible = false;
            lbl_Unidades.Visible = false;
            lbl_Milhares.Visible = false;
            lbl_Milhões.Visible = false;
            tb_uUnidade.Visible = false;
            tb_dUnidade.Visible = false;
            tb_cUnidade.Visible = false;
            tb_uMilhar.Visible = false;
            tb_dMilhar.Visible = false;
            tb_cMilhar.Visible = false;
            tb_uMilhao.Visible = false;
            tb_dMilhao.Visible = false;
            tb_cMilhao.Visible = false;

            lblParidade.Visible = false;
            radioButtonPar.Visible = false;
            radioButtonImpar.Visible = false;
        }

        public static string TrimAllWithInplaceCharArray(string str)
        {
            var len = str.Length;
            var src = str.ToCharArray();
            int dstIdx = 0;

            for (int i = 0; i < len; i++)
            {
                var ch = src[i];

                switch (ch)
                {
                    case '\u0020':
                    case '\u00A0':
                    case '\u1680':
                    case '\u2000':
                    case '\u2001':

                    case '\u2002':
                    case '\u2003':
                    case '\u2004':
                    case '\u2005':
                    case '\u2006':

                    case '\u2007':
                    case '\u2008':
                    case '\u2009':
                    case '\u200A':
                    case '\u202F':

                    case '\u205F':
                    case '\u3000':
                    case '\u2028':
                    case '\u2029':
                    case '\u0009':

                    case '\u000A':
                    case '\u000B':
                    case '\u000C':
                    case '\u000D':
                    case '\u0085':
                        continue;

                    default:
                        src[dstIdx++] = ch;
                        break;
                }
            }

            return new string(src, 0, dstIdx);
        }

        private int Lenght(int n)
        {
            int len = 0;
            while (n != 0)
            {
                len++;
                n = n / 10;
            }

            return len;
        }

        private int ReverteNum(int n)
        {
            int revert = 0;
            while (n != 0)
            {
                revert *= 10;
                revert += n % 10;
                n /= 10;
            }

            return revert;
        }

        private string SeparaNumResultado(int value, int position, bool isFinalZero)
        {
            string output = "";
            if (value >= 10)
            {
                if (output == "")
                {
                    position--;
                    output += SeparaNumResultado((value / 10), position, isFinalZero);
                }
                else
                {
                    position--;
                    output += " + " + SeparaNumResultado((value / 10), position, isFinalZero);
                }
            }

            if (output == "")
            {
                if (isFinalZero == true)
                    output += "0.10^0 + ";
                output += (value % 10).ToString() + ".10^" + (position - 1);
            }
            else
                output += " + " + (value % 10).ToString() + ".10^" + position;

            return output;
        }

        private string Soma_Potencia(int num)
        {
            string resultado = "";
            bool isFinalZero = (num % 10) == 0;
            int numInvert = ReverteNum(num);
            resultado = SeparaNumResultado(numInvert, Lenght(num), isFinalZero);

            return resultado;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbResposta.Clear();
            tb_uUnidade.Clear();
            tb_dUnidade.Clear();
            tb_cUnidade.Clear();
            tb_uMilhar.Clear();
            tb_dMilhar.Clear();
            tb_cMilhar.Clear();
            tb_uMilhao.Clear();
            tb_dMilhao.Clear();
            tb_cMilhao.Clear();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            int num = -1;
            try
            {
                num = Convert.ToInt32(tbNum.Text);
            }
            catch
            {
                MessageBox.Show("Insira um número natural de até 9 digitos",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            if ((Lenght(num) <= 9) && (num != -1))
            {
                /* Caso 1: Ordem e Classe Desativado e Paridade Desativado
                 * Caso 2: Ordem e Classe Ativado e Paridade Desativado
                 * Caso 3: Ordem e Classe Desativado e Paridade Ativado
                 * Caso 4: Ordem e Classe Ativado e Paridade Ativado
                */
                bool classeIsOn;
                if (checkboxOrdemClasse.Checked == true)
                    classeIsOn = true;
                else
                    classeIsOn = false;


                bool paridadeIsOn;
                if (checkboxParidade.Checked == true)
                    paridadeIsOn = true;
                else
                    paridadeIsOn = false;

                string result = "";
                bool isCorrect = false;
                bool isPar = false;
                bool isParidadeCorrect = false;

                if (classeIsOn == false)
                {
                    result = Soma_Potencia(num);
                    string withoutSpaceResult = TrimAllWithInplaceCharArray(result);

                    string userAnswer = tbResposta.Text;
                    string withoutSpaceUserAnswer = TrimAllWithInplaceCharArray(userAnswer);

                    if (withoutSpaceResult == withoutSpaceUserAnswer)
                        isCorrect = true;
                    else
                        isCorrect = false;
                }
                else if (classeIsOn == true)
                {
                    string userAnswerClasse = "";
                    userAnswerClasse += tb_cMilhao.Text;
                    userAnswerClasse += tb_dMilhao.Text;
                    userAnswerClasse += tb_uMilhao.Text;
                    userAnswerClasse += tb_cMilhar.Text;
                    userAnswerClasse += tb_dMilhar.Text;
                    userAnswerClasse += tb_uMilhar.Text;
                    userAnswerClasse += tb_cUnidade.Text;
                    userAnswerClasse += tb_dUnidade.Text;
                    userAnswerClasse += tb_uUnidade.Text;

                    if (userAnswerClasse == num.ToString())
                        isCorrect = true;
                    else
                        isCorrect = false;

                    result = num.ToString();
                }

                if (paridadeIsOn)
                {
                    if ((num % 2) == 0)
                        isPar = true;
                    if (isPar == true && radioButtonPar.Checked == true)
                        isParidadeCorrect = true;
                    else if (isPar == false && radioButtonImpar.Checked == true)
                        isParidadeCorrect = true;
                }

                FormPotencia10Resposta openForm = new FormPotencia10Resposta(classeIsOn, result, isCorrect, paridadeIsOn, isPar, isParidadeCorrect);
                openForm.Show();
            }
            else
            {
                MessageBox.Show("Insira um número natural de até 9 digitos",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        private void cb_ModoOrdemClasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxOrdemClasse.Checked == true)
            {
                tlbOrdemClase.Visible = true;
                lbl_Unidades.Visible = true;
                lbl_Milhares.Visible = true;
                lbl_Milhões.Visible = true;
                tb_uUnidade.Visible = true;
                tb_dUnidade.Visible = true;
                tb_cUnidade.Visible = true;
                tb_uMilhar.Visible = true;
                tb_dMilhar.Visible = true;
                tb_cMilhar.Visible = true;
                tb_uMilhao.Visible = true;
                tb_dMilhao.Visible = true;
                tb_cMilhao.Visible = true;
                lblResposta.Visible = false;
                tbResposta.Visible = false;
            }
            else
            {
                tlbOrdemClase.Visible = false;
                lbl_Unidades.Visible = false;
                lbl_Milhares.Visible = false;
                lbl_Milhões.Visible = false;
                tb_uUnidade.Visible = false;
                tb_dUnidade.Visible = false;
                tb_cUnidade.Visible = false;
                tb_uMilhar.Visible = false;
                tb_dMilhar.Visible = false;
                tb_cMilhar.Visible = false;
                tb_uMilhao.Visible = false;
                tb_dMilhao.Visible = false;
                tb_cMilhao.Visible = false;
                lblResposta.Visible = true;
                tbResposta.Visible = true;
            }
        }

        private void checkboxParidade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxParidade.Checked == true)
            {
                lblParidade.Visible = true;
                radioButtonPar.Visible = true;
                radioButtonImpar.Visible = true;
            }
            else
            {
                lblParidade.Visible = false;
                radioButtonPar.Visible = false;
                radioButtonImpar.Visible = false;
            }
        }
    }
}
