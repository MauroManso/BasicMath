
namespace BasicMathBase
{
    partial class FormPrimeSieve
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblNumberOfPrimes = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtboxUpToPrime = new System.Windows.Forms.TextBox();
            this.btnListPrime = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.richTextBoxLista = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(326, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Números Primos por Crivo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPercentage);
            this.panel1.Controls.Add(this.lblTimeElapsed);
            this.panel1.Controls.Add(this.lblNumberOfPrimes);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.txtboxUpToPrime);
            this.panel1.Controls.Add(this.btnListPrime);
            this.panel1.Controls.Add(this.lbl_Lista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 217);
            this.panel1.TabIndex = 24;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPercentage.Location = new System.Drawing.Point(530, 153);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(42, 25);
            this.lblPercentage.TabIndex = 4143;
            this.lblPercentage.Text = "0 %";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimeElapsed.Location = new System.Drawing.Point(609, 117);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(181, 25);
            this.lblTimeElapsed.TabIndex = 4144;
            this.lblTimeElapsed.Text = "Tempo passado: 0Ms";
            // 
            // lblNumberOfPrimes
            // 
            this.lblNumberOfPrimes.AutoSize = true;
            this.lblNumberOfPrimes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberOfPrimes.Location = new System.Drawing.Point(325, 117);
            this.lblNumberOfPrimes.Name = "lblNumberOfPrimes";
            this.lblNumberOfPrimes.Size = new System.Drawing.Size(187, 25);
            this.lblNumberOfPrimes.TabIndex = 4145;
            this.lblNumberOfPrimes.Text = "Há 0 Números Primos";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(872, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 4141;
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
            this.btnPrint.Location = new System.Drawing.Point(115, 105);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 55);
            this.btnPrint.TabIndex = 4142;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtboxUpToPrime
            // 
            this.txtboxUpToPrime.Location = new System.Drawing.Point(506, 67);
            this.txtboxUpToPrime.Name = "txtboxUpToPrime";
            this.txtboxUpToPrime.Size = new System.Drawing.Size(101, 31);
            this.txtboxUpToPrime.TabIndex = 4138;
            // 
            // btnListPrime
            // 
            this.btnListPrime.FlatAppearance.BorderSize = 2;
            this.btnListPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPrime.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListPrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListPrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPrime.Location = new System.Drawing.Point(637, 58);
            this.btnListPrime.Name = "btnListPrime";
            this.btnListPrime.Size = new System.Drawing.Size(135, 55);
            this.btnListPrime.TabIndex = 4140;
            this.btnListPrime.Text = "Listar";
            this.btnListPrime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPrime.UseVisualStyleBackColor = true;
            this.btnListPrime.Click += new System.EventHandler(this.btnListPrime_Click);
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Lista.Location = new System.Drawing.Point(381, 70);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(100, 25);
            this.lbl_Lista.TabIndex = 4139;
            this.lbl_Lista.Text = "Primos até:";
            // 
            // richTextBoxLista
            // 
            this.richTextBoxLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLista.Location = new System.Drawing.Point(29, 312);
            this.richTextBoxLista.Margin = new System.Windows.Forms.Padding(20);
            this.richTextBoxLista.Name = "richTextBoxLista";
            this.richTextBoxLista.Size = new System.Drawing.Size(1070, 553);
            this.richTextBoxLista.TabIndex = 25;
            this.richTextBoxLista.Text = "";
            // 
            // FormPrimeSieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.richTextBoxLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimeSieve";
            this.Text = "FormPrimosCrivo";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblNumberOfPrimes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtboxUpToPrime;
        private System.Windows.Forms.Button btnListPrime;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.RichTextBox richTextBoxLista;
    }
}