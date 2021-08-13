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
    public partial class FormAnswerRichTxtBox : Form
    {
        public FormAnswerRichTxtBox(bool isCorrect, string answer, List<int>paintLocationList)
        {
            InitializeComponent();
            customizeDesign(isCorrect, answer, paintLocationList);
        }

        private void customizeDesign(bool isCorrect, string answer, List<int> paintLocationList)
        {
            richTextBoxAnswer.Visible = false;
            btnGetAnswer.Visible = false;

            lblIsCorrect.Left = (this.ClientSize.Width - lblIsCorrect.Size.Width) / 2;
            if (isCorrect)
            {
                lblIsCorrect.Text = "Resposta Correta!";

                btnGetAnswer.Text = "Conferir Resolução";
                btnGetAnswer.Left = (this.ClientSize.Width - btnGetAnswer.Size.Width) / 2;
                btnGetAnswer.Visible = true;
            }
            else
            {
                lblIsCorrect.Text = "Resposta Incorreta :(";

                btnGetAnswer.Left = (this.ClientSize.Width - btnGetAnswer.Size.Width) / 2;
                btnGetAnswer.Visible = true;
            }


            richTextBoxAnswer.Text = answer;
            int size = 1;
            foreach (var paintLocation in paintLocationList)
            {
                richTextBoxAnswer.Select(paintLocation - size, size);
                richTextBoxAnswer.SelectionColor = Color.Red;
            }
            richTextBoxAnswer.Left = (this.ClientSize.Width - richTextBoxAnswer.Size.Width) / 2;
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Visible = true;
        }

        private void lblIsCorrect_Click(object sender, EventArgs e)
        {

        }
    }
}
