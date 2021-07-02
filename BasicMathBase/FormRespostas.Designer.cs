
namespace BasicMathBase
{
    partial class FormRespostas
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
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.lblIsCorrect = new System.Windows.Forms.Label();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.FlatAppearance.BorderSize = 2;
            this.btnGetAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAnswer.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGetAnswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetAnswer.Location = new System.Drawing.Point(312, 419);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(280, 65);
            this.btnGetAnswer.TabIndex = 6;
            this.btnGetAnswer.Text = "Obter Resposta";
            this.btnGetAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // lblIsCorrect
            // 
            this.lblIsCorrect.AutoSize = true;
            this.lblIsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsCorrect.Location = new System.Drawing.Point(332, 95);
            this.lblIsCorrect.Name = "lblIsCorrect";
            this.lblIsCorrect.Size = new System.Drawing.Size(260, 32);
            this.lblIsCorrect.TabIndex = 7;
            this.lblIsCorrect.Text = "Resposta Correta!";
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnwser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAnwser.Location = new System.Drawing.Point(359, 208);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(207, 29);
            this.lblAnwser.TabIndex = 8;
            this.lblAnwser.Text = "O número é impar";
            this.lblAnwser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRespostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(930, 525);
            this.Controls.Add(this.lblIsCorrect);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnGetAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormRespostas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.Label lblIsCorrect;
        private System.Windows.Forms.Label lblAnwser;
    }
}