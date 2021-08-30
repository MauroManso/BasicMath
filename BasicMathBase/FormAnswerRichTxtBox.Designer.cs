
namespace BasicMathBase
{
    partial class FormAnswerRichTxtBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsCorrect = new System.Windows.Forms.Label();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblIsCorrect
            // 
            this.lblIsCorrect.AutoSize = true;
            this.lblIsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsCorrect.Location = new System.Drawing.Point(388, 65);
            this.lblIsCorrect.Name = "lblIsCorrect";
            this.lblIsCorrect.Size = new System.Drawing.Size(260, 32);
            this.lblIsCorrect.TabIndex = 13;
            this.lblIsCorrect.Text = "Resposta Correta!";
            this.lblIsCorrect.Click += new System.EventHandler(this.lblIsCorrect_Click);
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.FlatAppearance.BorderSize = 2;
            this.btnGetAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAnswer.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGetAnswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetAnswer.Location = new System.Drawing.Point(368, 542);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(280, 65);
            this.btnGetAnswer.TabIndex = 12;
            this.btnGetAnswer.Text = "Obter Resposta";
            this.btnGetAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(105, 131);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(861, 371);
            this.richTextBoxAnswer.TabIndex = 14;
            this.richTextBoxAnswer.Text = "";
            // 
            // FormAnswerRichTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1073, 679);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.lblIsCorrect);
            this.Controls.Add(this.btnGetAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAnswerRichTxtBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnswerRichTxtBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsCorrect;
        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
    }
}