
namespace BasicMathBase
{
    partial class FormIsPrime
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.txtboxVerifyPrime = new System.Windows.Forms.TextBox();
            this.btnVerifyPrime = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(396, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Números Primos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 22;
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimo.Location = new System.Drawing.Point(237, 365);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(82, 25);
            this.lblPrimo.TabIndex = 23;
            this.lblPrimo.Text = "É primo?";
            // 
            // txtboxVerifyPrime
            // 
            this.txtboxVerifyPrime.Location = new System.Drawing.Point(325, 362);
            this.txtboxVerifyPrime.Name = "txtboxVerifyPrime";
            this.txtboxVerifyPrime.Size = new System.Drawing.Size(260, 31);
            this.txtboxVerifyPrime.TabIndex = 24;
            // 
            // btnVerifyPrime
            // 
            this.btnVerifyPrime.FlatAppearance.BorderSize = 2;
            this.btnVerifyPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyPrime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyPrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVerifyPrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifyPrime.Location = new System.Drawing.Point(601, 352);
            this.btnVerifyPrime.Name = "btnVerifyPrime";
            this.btnVerifyPrime.Size = new System.Drawing.Size(135, 49);
            this.btnVerifyPrime.TabIndex = 25;
            this.btnVerifyPrime.Text = "Verificar";
            this.btnVerifyPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerifyPrime.UseVisualStyleBackColor = true;
            this.btnVerifyPrime.Click += new System.EventHandler(this.btnVerifyPrime_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(799, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4131;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormIsPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerifyPrime);
            this.Controls.Add(this.txtboxVerifyPrime);
            this.Controls.Add(this.lblPrimo);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIsPrime";
            this.Text = "FormPrimos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.TextBox txtboxVerifyPrime;
        private System.Windows.Forms.Button btnVerifyPrime;
        private System.Windows.Forms.Button btnClear;
    }
}