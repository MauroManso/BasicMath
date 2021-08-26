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
    public partial class FormInfo : Form
    {
        public FormInfo(string info)
        {
            InitializeComponent();
            customizeDesign(info);
        }

        private void customizeDesign(string info)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;
            richTextBox1.Text = info;

        }

    }
}
