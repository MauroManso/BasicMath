
namespace BasicMathBase
{
    partial class FormPrimos
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
            this.lblPrimes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.txtboxVerifyPrime = new System.Windows.Forms.TextBox();
            this.btnVerifyPrime = new System.Windows.Forms.Button();
            this.btnListPrime = new System.Windows.Forms.Button();
            this.txtboxBeginPrime = new System.Windows.Forms.TextBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.txtboxUpToPrime = new System.Windows.Forms.TextBox();
            this.lbl_AtePrimo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxList = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimes
            // 
            this.lblPrimes.AutoSize = true;
            this.lblPrimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.lblPrimes.Location = new System.Drawing.Point(342, 30);
            this.lblPrimes.Name = "lblPrimes";
            this.lblPrimes.Size = new System.Drawing.Size(325, 37);
            this.lblPrimes.TabIndex = 2;
            this.lblPrimes.Text = "NÚMEROS PRIMOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblPrimes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 95);
            this.panel3.TabIndex = 22;
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimo.Location = new System.Drawing.Point(224, 113);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(82, 25);
            this.lblPrimo.TabIndex = 23;
            this.lblPrimo.Text = "É primo?";
            // 
            // txtboxVerifyPrime
            // 
            this.txtboxVerifyPrime.Location = new System.Drawing.Point(312, 110);
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
            this.btnVerifyPrime.Location = new System.Drawing.Point(588, 100);
            this.btnVerifyPrime.Name = "btnVerifyPrime";
            this.btnVerifyPrime.Size = new System.Drawing.Size(135, 49);
            this.btnVerifyPrime.TabIndex = 25;
            this.btnVerifyPrime.Text = "Verificar";
            this.btnVerifyPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerifyPrime.UseVisualStyleBackColor = true;
            this.btnVerifyPrime.Click += new System.EventHandler(this.btnVerifyPrime_Click);
            // 
            // btnListPrime
            // 
            this.btnListPrime.FlatAppearance.BorderSize = 2;
            this.btnListPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPrime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListPrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListPrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPrime.Location = new System.Drawing.Point(588, 181);
            this.btnListPrime.Name = "btnListPrime";
            this.btnListPrime.Size = new System.Drawing.Size(135, 47);
            this.btnListPrime.TabIndex = 4128;
            this.btnListPrime.Text = "Listar";
            this.btnListPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPrime.UseVisualStyleBackColor = true;
            this.btnListPrime.Click += new System.EventHandler(this.btnListPrime_Click);
            // 
            // txtboxBeginPrime
            // 
            this.txtboxBeginPrime.Location = new System.Drawing.Point(312, 190);
            this.txtboxBeginPrime.Name = "txtboxBeginPrime";
            this.txtboxBeginPrime.Size = new System.Drawing.Size(92, 31);
            this.txtboxBeginPrime.TabIndex = 26;
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lista.Location = new System.Drawing.Point(210, 193);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(96, 25);
            this.lbl_Lista.TabIndex = 39;
            this.lbl_Lista.Text = "Primos de:";
            // 
            // txtboxUpToPrime
            // 
            this.txtboxUpToPrime.Location = new System.Drawing.Point(471, 190);
            this.txtboxUpToPrime.Name = "txtboxUpToPrime";
            this.txtboxUpToPrime.Size = new System.Drawing.Size(101, 31);
            this.txtboxUpToPrime.TabIndex = 27;
            // 
            // lbl_AtePrimo
            // 
            this.lbl_AtePrimo.AutoSize = true;
            this.lbl_AtePrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AtePrimo.Location = new System.Drawing.Point(422, 193);
            this.lbl_AtePrimo.Name = "lbl_AtePrimo";
            this.lbl_AtePrimo.Size = new System.Drawing.Size(43, 25);
            this.lbl_AtePrimo.TabIndex = 43;
            this.lbl_AtePrimo.Text = "Até:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtboxList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 408);
            this.panel1.TabIndex = 4129;
            // 
            // txtboxList
            // 
            this.txtboxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.txtboxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtboxList.Location = new System.Drawing.Point(0, 0);
            this.txtboxList.Multiline = true;
            this.txtboxList.Name = "txtboxList";
            this.txtboxList.ReadOnly = true;
            this.txtboxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxList.Size = new System.Drawing.Size(984, 408);
            this.txtboxList.TabIndex = 4130;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(31, 181);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 47);
            this.btnPrint.TabIndex = 4130;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.FlatAppearance.BorderSize = 2;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear2.Location = new System.Drawing.Point(786, 181);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(135, 47);
            this.btnClear2.TabIndex = 4130;
            this.btnClear2.Text = "Limpar";
            this.btnClear2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(786, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4131;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxUpToPrime);
            this.Controls.Add(this.lbl_AtePrimo);
            this.Controls.Add(this.btnListPrime);
            this.Controls.Add(this.txtboxBeginPrime);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.btnVerifyPrime);
            this.Controls.Add(this.txtboxVerifyPrime);
            this.Controls.Add(this.lblPrimo);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimos";
            this.Text = "FormPrimos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.TextBox txtboxVerifyPrime;
        private System.Windows.Forms.Button btnVerifyPrime;
        private System.Windows.Forms.Button btnListPrime;
        private System.Windows.Forms.TextBox txtboxBeginPrime;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.TextBox txtboxUpToPrime;
        private System.Windows.Forms.Label lbl_AtePrimo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnClear;
    }
}