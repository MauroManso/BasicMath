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
    public partial class FormNaturalAsPowerSum : Form
    {
        public FormNaturalAsPowerSum()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;

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
            checkboxOrdemClasse.Checked = false;
            checkboxParidade.Checked = false;
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            string answer = "";
            bool isCorrect = false;
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

            if ((Convert.ToString(num).Length <=9) && (num != -1))
            {
                if (checkboxParidade.Checked)
                {
                    bool isPar = false;
                    if ((num % 2) == 0)
                        isPar = true;
                    if (isPar && radioButtonPar.Checked)
                        isCorrect = true;
                    else if (!isPar && radioButtonImpar.Checked)
                        isCorrect = true;
                    else {
                        answer = "O número é " ;
                        if (isPar) answer += "par";
                        else answer += "impar";
                    }

                    FormAnswers openForm = new FormAnswers(isCorrect, answer);
                    openForm.Show();
                }
                else if (!checkboxOrdemClasse.Checked)
                {
                    var answers = MathMethods.SumPowerBase10(num);
                    string powerSumAnswer = answers.toLeft;
                    string powerSumAnswer2 = answers.toRight;
                    string userAnswer = tbResposta.Text;

                    string powerSumAnswerWithOutSpace = powerSumAnswer.Replace(" ", "");
                    string powerSumAnswer2WithOutSpace = powerSumAnswer2.Replace(" ", "");
                    string userAnswerWithOutSpace = userAnswer.Replace(" ", "");


                    System.Diagnostics.Debug.WriteLine(powerSumAnswer);
                    System.Diagnostics.Debug.WriteLine(powerSumAnswer2);
                    if ((userAnswerWithOutSpace == powerSumAnswerWithOutSpace) || (userAnswerWithOutSpace == powerSumAnswer2WithOutSpace))
                    {
                        FormAnswers openForm = new FormAnswers(true, powerSumAnswer);
                        openForm.Show();
                    }
                    else
                    {
                        FormAnswers openForm = new FormAnswers(false, powerSumAnswer);
                        openForm.Show();
                    }
                }
                else if (checkboxOrdemClasse.Checked)
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

                    answer = num.ToString();

                    FormTableAnswer openForm = new FormTableAnswer(isCorrect, answer);
                    openForm.Show();
                }

                
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

                tbResposta.Text = "";
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

                tb_uUnidade.Text = "";
                tb_dUnidade.Text = "";
                tb_cUnidade.Text = "";
                tb_uMilhar.Text = "";
                tb_dMilhar.Text = "";
                tb_cMilhar.Text = "";
                tb_uMilhao.Text = "";
                tb_dMilhao.Text = "";
                tb_cMilhao.Text = "";
            }
        }

        private void checkboxParidade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxParidade.Checked == true)
            {
                lblParidade.Visible = true;
                radioButtonPar.Visible = true;
                radioButtonImpar.Visible = true;

                tbResposta.Text = "";
                checkboxOrdemClasse.Checked = false;
                checkboxOrdemClasse.Visible = false;
                lblResposta.Visible = false;
                tbResposta.Visible = false;
            }
            else
            {
                lblParidade.Visible = false;
                radioButtonPar.Visible = false;
                radioButtonImpar.Visible = false;

                radioButtonPar.Checked = false;
                radioButtonImpar.Checked = false;

                checkboxOrdemClasse.Visible = true;
                lblResposta.Visible = true;
                tbResposta.Visible = true;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "\t NATURAL COMO SOMA DE POTÊNCIAS DE BASE 10\n\n\n";
            info += "\t i₁ UTILIZAR O FORMATO : \n";
            info += "\t\t a₀.10^0+a₁.10^1 + ... aₖ.10^k\n\n";
            info += "\t i₂ EXEMPLO:\n";
            info += "\t\t n = 8439    :    9.10^0 + 3.10^1 + 4.10^2 + 8.10^3\n";
            FormInfo openForm = new FormInfo(info);
            openForm.Show();
        }
    }
}
