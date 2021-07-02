
namespace BasicMathBase
{
    partial class FormPrimosCrivo
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
            this.txtboxUpToPrime = new System.Windows.Forms.TextBox();
            this.btnListPrime = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.richTextBoxLista = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNumberOfPrimes = new System.Windows.Forms.Label();
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
            this.panel3.Size = new System.Drawing.Size(984, 95);
            this.panel3.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.lblTitle.Location = new System.Drawing.Point(228, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "NÚMEROS PRIMOS POR CRIVO";
            // 
            // txtboxUpToPrime
            // 
            this.txtboxUpToPrime.Location = new System.Drawing.Point(441, 149);
            this.txtboxUpToPrime.Name = "txtboxUpToPrime";
            this.txtboxUpToPrime.Size = new System.Drawing.Size(101, 31);
            this.txtboxUpToPrime.TabIndex = 4130;
            // 
            // btnListPrime
            // 
            this.btnListPrime.FlatAppearance.BorderSize = 2;
            this.btnListPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPrime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListPrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListPrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPrime.Location = new System.Drawing.Point(572, 140);
            this.btnListPrime.Name = "btnListPrime";
            this.btnListPrime.Size = new System.Drawing.Size(135, 47);
            this.btnListPrime.TabIndex = 4133;
            this.btnListPrime.Text = "Listar";
            this.btnListPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPrime.UseVisualStyleBackColor = true;
            this.btnListPrime.Click += new System.EventHandler(this.btnListPrime_Click);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lista.Location = new System.Drawing.Point(316, 152);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(100, 25);
            this.lbl_Lista.TabIndex = 4131;
            this.lbl_Lista.Text = "Primos até:";
            // 
            // richTextBoxLista
            // 
            this.richTextBoxLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.richTextBoxLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxLista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxLista.Location = new System.Drawing.Point(0, 256);
            this.richTextBoxLista.Name = "richTextBoxLista";
            this.richTextBoxLista.ReadOnly = true;
            this.richTextBoxLista.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLista.Size = new System.Drawing.Size(984, 408);
            this.richTextBoxLista.TabIndex = 4134;
            this.richTextBoxLista.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(807, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4135;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(50, 187);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 47);
            this.btnPrint.TabIndex = 4136;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNumberOfPrimes
            // 
            this.lblNumberOfPrimes.AutoSize = true;
            this.lblNumberOfPrimes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfPrimes.Location = new System.Drawing.Point(441, 209);
            this.lblNumberOfPrimes.Name = "lblNumberOfPrimes";
            this.lblNumberOfPrimes.Size = new System.Drawing.Size(102, 25);
            this.lblNumberOfPrimes.TabIndex = 4137;
            this.lblNumberOfPrimes.Text = "quantidade";
            // 
            // FormPrimosCrivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.lblNumberOfPrimes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.richTextBoxLista);
            this.Controls.Add(this.txtboxUpToPrime);
            this.Controls.Add(this.btnListPrime);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimosCrivo";
            this.Text = "FormPrimosCrivo";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxUpToPrime;
        private System.Windows.Forms.Button btnListPrime;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.RichTextBox richTextBoxLista;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblNumberOfPrimes;
    }
}