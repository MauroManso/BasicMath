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
    public partial class FormAnswers : Form
    {
        [System.Runtime.InteropServices.DllImport("MimeTex.dll")]
        internal static extern int CreateGifFromEq(string expr, string fileName);
        public FormAnswers(bool isCorrect, string answer)
        {
            InitializeComponent();
            customizeDesign(isCorrect, answer);
        }

        private void customizeDesign(bool isCorrect, string answer)
        {
            lblAnwser.Visible = false;
            btnGetAnswer.Visible = false;

            if (isCorrect)
            {
                lblIsCorrect.Text = "Resposta Correta!";
                lblIsCorrect.Left = (this.ClientSize.Width - lblIsCorrect.Size.Width) / 2;

                btnGetAnswer.Text = "Conferir Resolução";
                btnGetAnswer.Left = (this.ClientSize.Width - btnGetAnswer.Size.Width) / 2;
                btnGetAnswer.Visible = true;
            }
            else
            {
                lblIsCorrect.Text = "Resposta Incorreta :(";
                lblIsCorrect.Left = (this.ClientSize.Width - lblIsCorrect.Size.Width) / 2;

                btnGetAnswer.Left = (this.ClientSize.Width - btnGetAnswer.Size.Width) / 2;
                btnGetAnswer.Visible = true;
            }

            lblAnwser.Text = answer;
            lblAnwser.Left = (this.ClientSize.Width - lblAnwser.Size.Width) / 2;
            
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            lblAnwser.Visible = true;
        }
    }
}
