
namespace BasicMathBase
{
    partial class FormPrimesList
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
            this.txtboxList = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtboxUpToPrime = new System.Windows.Forms.TextBox();
            this.lbl_AtePrimo = new System.Windows.Forms.Label();
            this.btnListPrime = new System.Windows.Forms.Button();
            this.txtboxBeginPrime = new System.Windows.Forms.TextBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lblNumberOfPrimes = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(436, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Lista de Primos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 27;
            // 
            // txtboxList
            // 
            this.txtboxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.txtboxList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtboxList.Location = new System.Drawing.Point(0, 330);
            this.txtboxList.Multiline = true;
            this.txtboxList.Name = "txtboxList";
            this.txtboxList.ReadOnly = true;
            this.txtboxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxList.Size = new System.Drawing.Size(1128, 564);
            this.txtboxList.TabIndex = 4151;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPercentage.Location = new System.Drawing.Point(516, 259);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(42, 25);
            this.lblPercentage.TabIndex = 4149;
            this.lblPercentage.Text = "0 %";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimeElapsed.Location = new System.Drawing.Point(642, 231);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(181, 25);
            this.lblTimeElapsed.TabIndex = 4150;
            this.lblTimeElapsed.Text = "Tempo passado: 0Ms";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(902, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4147;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(90, 219);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 47);
            this.btnPrint.TabIndex = 4148;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtboxUpToPrime
            // 
            this.txtboxUpToPrime.Location = new System.Drawing.Point(553, 161);
            this.txtboxUpToPrime.Name = "txtboxUpToPrime";
            this.txtboxUpToPrime.Size = new System.Drawing.Size(101, 31);
            this.txtboxUpToPrime.TabIndex = 4143;
            // 
            // lbl_AtePrimo
            // 
            this.lbl_AtePrimo.AutoSize = true;
            this.lbl_AtePrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AtePrimo.Location = new System.Drawing.Point(504, 164);
            this.lbl_AtePrimo.Name = "lbl_AtePrimo";
            this.lbl_AtePrimo.Size = new System.Drawing.Size(43, 25);
            this.lbl_AtePrimo.TabIndex = 4145;
            this.lbl_AtePrimo.Text = "Até:";
            // 
            // btnListPrime
            // 
            this.btnListPrime.FlatAppearance.BorderSize = 2;
            this.btnListPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPrime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListPrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListPrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPrime.Location = new System.Drawing.Point(706, 152);
            this.btnListPrime.Name = "btnListPrime";
            this.btnListPrime.Size = new System.Drawing.Size(135, 47);
            this.btnListPrime.TabIndex = 4146;
            this.btnListPrime.Text = "Listar";
            this.btnListPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPrime.UseVisualStyleBackColor = true;
            this.btnListPrime.Click += new System.EventHandler(this.btnListPrime_Click);
            // 
            // txtboxBeginPrime
            // 
            this.txtboxBeginPrime.Location = new System.Drawing.Point(394, 161);
            this.txtboxBeginPrime.Name = "txtboxBeginPrime";
            this.txtboxBeginPrime.Size = new System.Drawing.Size(92, 31);
            this.txtboxBeginPrime.TabIndex = 4142;
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lista.Location = new System.Drawing.Point(292, 164);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(96, 25);
            this.lbl_Lista.TabIndex = 4144;
            this.lbl_Lista.Text = "Primos de:";
            // 
            // lblNumberOfPrimes
            // 
            this.lblNumberOfPrimes.AutoSize = true;
            this.lblNumberOfPrimes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfPrimes.Location = new System.Drawing.Point(325, 231);
            this.lblNumberOfPrimes.Name = "lblNumberOfPrimes";
            this.lblNumberOfPrimes.Size = new System.Drawing.Size(102, 25);
            this.lblNumberOfPrimes.TabIndex = 4141;
            this.lblNumberOfPrimes.Text = "quantidade";
            // 
            // FormPrimesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.txtboxList);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtboxUpToPrime);
            this.Controls.Add(this.lbl_AtePrimo);
            this.Controls.Add(this.btnListPrime);
            this.Controls.Add(this.txtboxBeginPrime);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lblNumberOfPrimes);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimesList";
            this.Text = "FormPrimesList";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxList;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtboxUpToPrime;
        private System.Windows.Forms.Label lbl_AtePrimo;
        private System.Windows.Forms.Button btnListPrime;
        private System.Windows.Forms.TextBox txtboxBeginPrime;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lblNumberOfPrimes;
    }
}