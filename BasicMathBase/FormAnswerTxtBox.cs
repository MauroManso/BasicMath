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
    public partial class FormAnswerTxtBox : Form
    {
        public FormAnswerTxtBox(bool isCorrect, string answer)
        {
            InitializeComponent();
            customizeDesign(isCorrect, answer);
        }

        private void customizeDesign(bool isCorrect, string answer)
        {
            richTextBoxAnswer.Visible = false;
            btnGetAnswer.Visible = false;

            lblIsCorrect.Left = (this.ClientSize.Width - lblIsCorrect.Size.Width) / 2;
            if (isCorrect)
                lblIsCorrect.Text = "Resposta Correta!";
            else
            {
                lblIsCorrect.Text = "Resposta Incorreta :(";
                btnGetAnswer.Visible = true;
                btnGetAnswer.Left = (this.ClientSize.Width - btnGetAnswer.Size.Width) / 2;
            }


            richTextBoxAnswer.Text = answer;
            richTextBoxAnswer.Left = (this.ClientSize.Width - richTextBoxAnswer.Size.Width) / 2;
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Visible = true;
        }
    }
}
