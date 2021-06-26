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
    public partial class FormRespostas : Form
    {
        public FormRespostas(bool isCorrect, string answer)
        {
            InitializeComponent();
            customizeDesign(isCorrect, answer);
        }

        private void customizeDesign(bool isCorrect, string answer)
        {
            lblAnwser.Visible = false;
            btnGetAnswer.Visible = false;

            int x1 = (952 - lblIsCorrect.Width) / 2;
            lblIsCorrect.Location = new Point(x1, 100);
            if (isCorrect)
                lblIsCorrect.Text = "Resposta Correta!";
            else
            {
                lblIsCorrect.Text = "Resposta Incorreta :(";
                btnGetAnswer.Visible = true;
            }
                

            lblAnwser.Text = answer;
            int x = (952 - lblAnwser.Width) / 2;
            int y = ((581 - lblAnwser.Height) / 2) - 80;
            lblAnwser.Location = new Point(x, y);
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            lblAnwser.Visible = true;
        }
    }
}
