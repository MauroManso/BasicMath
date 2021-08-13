
namespace BasicMathBase
{
    partial class FormPiX
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxPix = new System.Windows.Forms.TextBox();
            this.lblPix = new System.Windows.Forms.Label();
            this.btnCalculatePix = new System.Windows.Forms.Button();
            this.lblApproximatePiX = new System.Windows.Forms.Label();
            this.lblRealPiX = new System.Windows.Forms.Label();
            this.lblAcuratePiX = new System.Windows.Forms.Label();
            this.lblApproximatePiXAnswer = new System.Windows.Forms.Label();
            this.lblRealPiXAnswer = new System.Windows.Forms.Label();
            this.lblAcuratePiXAnswer = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(496, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "π (x)";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(723, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 4136;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxPix
            // 
            this.txtboxPix.Location = new System.Drawing.Point(368, 328);
            this.txtboxPix.Name = "txtboxPix";
            this.txtboxPix.Size = new System.Drawing.Size(101, 31);
            this.txtboxPix.TabIndex = 4132;
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPix.Location = new System.Drawing.Point(318, 325);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(190, 32);
            this.lblPix.TabIndex = 4134;
            this.lblPix.Text = "π (                    )";
            // 
            // btnCalculatePix
            // 
            this.btnCalculatePix.FlatAppearance.BorderSize = 2;
            this.btnCalculatePix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatePix.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculatePix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculatePix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculatePix.Location = new System.Drawing.Point(549, 319);
            this.btnCalculatePix.Name = "btnCalculatePix";
            this.btnCalculatePix.Size = new System.Drawing.Size(135, 55);
            this.btnCalculatePix.TabIndex = 4135;
            this.btnCalculatePix.Text = "Calcular";
            this.btnCalculatePix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculatePix.UseVisualStyleBackColor = true;
            this.btnCalculatePix.Click += new System.EventHandler(this.btnCalculatePix_Click);
            // 
            // lblApproximatePiX
            // 
            this.lblApproximatePiX.AutoSize = true;
            this.lblApproximatePiX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApproximatePiX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApproximatePiX.Location = new System.Drawing.Point(167, 442);
            this.lblApproximatePiX.Name = "lblApproximatePiX";
            this.lblApproximatePiX.Size = new System.Drawing.Size(327, 25);
            this.lblApproximatePiX.TabIndex = 4134;
            this.lblApproximatePiX.Text = "Número de primos por aproximação:";
            // 
            // lblRealPiX
            // 
            this.lblRealPiX.AutoSize = true;
            this.lblRealPiX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRealPiX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRealPiX.Location = new System.Drawing.Point(280, 497);
            this.lblRealPiX.Name = "lblRealPiX";
            this.lblRealPiX.Size = new System.Drawing.Size(214, 25);
            this.lblRealPiX.TabIndex = 4134;
            this.lblRealPiX.Text = "Número de primos real:";
            // 
            // lblAcuratePiX
            // 
            this.lblAcuratePiX.AutoSize = true;
            this.lblAcuratePiX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcuratePiX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcuratePiX.Location = new System.Drawing.Point(394, 548);
            this.lblAcuratePiX.Name = "lblAcuratePiX";
            this.lblAcuratePiX.Size = new System.Drawing.Size(100, 25);
            this.lblAcuratePiX.TabIndex = 4134;
            this.lblAcuratePiX.Text = "Acuracia: ";
            // 
            // lblApproximatePiXAnswer
            // 
            this.lblApproximatePiXAnswer.AutoSize = true;
            this.lblApproximatePiXAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApproximatePiXAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApproximatePiXAnswer.Location = new System.Drawing.Point(500, 442);
            this.lblApproximatePiXAnswer.Name = "lblApproximatePiXAnswer";
            this.lblApproximatePiXAnswer.Size = new System.Drawing.Size(87, 25);
            this.lblApproximatePiXAnswer.TabIndex = 4134;
            this.lblApproximatePiXAnswer.Text = "resposta";
            // 
            // lblRealPiXAnswer
            // 
            this.lblRealPiXAnswer.AutoSize = true;
            this.lblRealPiXAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRealPiXAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRealPiXAnswer.Location = new System.Drawing.Point(500, 497);
            this.lblRealPiXAnswer.Name = "lblRealPiXAnswer";
            this.lblRealPiXAnswer.Size = new System.Drawing.Size(87, 25);
            this.lblRealPiXAnswer.TabIndex = 4134;
            this.lblRealPiXAnswer.Text = "resposta";
            // 
            // lblAcuratePiXAnswer
            // 
            this.lblAcuratePiXAnswer.AutoSize = true;
            this.lblAcuratePiXAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcuratePiXAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcuratePiXAnswer.Location = new System.Drawing.Point(500, 548);
            this.lblAcuratePiXAnswer.Name = "lblAcuratePiXAnswer";
            this.lblAcuratePiXAnswer.Size = new System.Drawing.Size(87, 25);
            this.lblAcuratePiXAnswer.TabIndex = 4134;
            this.lblAcuratePiXAnswer.Text = "resposta";
            // 
            // FormPiX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxPix);
            this.Controls.Add(this.lblAcuratePiX);
            this.Controls.Add(this.lblRealPiX);
            this.Controls.Add(this.lblAcuratePiXAnswer);
            this.Controls.Add(this.lblRealPiXAnswer);
            this.Controls.Add(this.lblApproximatePiXAnswer);
            this.Controls.Add(this.lblApproximatePiX);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.btnCalculatePix);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPiX";
            this.Text = "FormPix";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxPix;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.Button btnCalculatePix;
        private System.Windows.Forms.Label lblApproximatePiX;
        private System.Windows.Forms.Label lblRealPiX;
        private System.Windows.Forms.Label lblAcuratePiX;
        private System.Windows.Forms.Label lblApproximatePiXAnswer;
        private System.Windows.Forms.Label lblRealPiXAnswer;
        private System.Windows.Forms.Label lblAcuratePiXAnswer;
        private System.Windows.Forms.Label lblTitle;
    }
}