
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
            this.lblPrimos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.txtbox_Eprimo = new System.Windows.Forms.TextBox();
            this.btn_VerificarPrimo = new System.Windows.Forms.Button();
            this.lbl_RespostaPrimo = new System.Windows.Forms.Label();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.txtbox_dePrimo = new System.Windows.Forms.TextBox();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.txtBox_atePrimo = new System.Windows.Forms.TextBox();
            this.lbl_AtePrimo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxLista = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.lblPrimos.Location = new System.Drawing.Point(342, 30);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(325, 37);
            this.lblPrimos.TabIndex = 2;
            this.lblPrimos.Text = "NÚMEROS PRIMOS";
            this.lblPrimos.Click += new System.EventHandler(this.lblSomaPotencia_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblPrimos);
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
            // txtbox_Eprimo
            // 
            this.txtbox_Eprimo.Location = new System.Drawing.Point(312, 110);
            this.txtbox_Eprimo.Name = "txtbox_Eprimo";
            this.txtbox_Eprimo.Size = new System.Drawing.Size(237, 31);
            this.txtbox_Eprimo.TabIndex = 24;
            // 
            // btn_VerificarPrimo
            // 
            this.btn_VerificarPrimo.FlatAppearance.BorderSize = 2;
            this.btn_VerificarPrimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerificarPrimo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerificarPrimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_VerificarPrimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerificarPrimo.Location = new System.Drawing.Point(576, 100);
            this.btn_VerificarPrimo.Name = "btn_VerificarPrimo";
            this.btn_VerificarPrimo.Size = new System.Drawing.Size(135, 49);
            this.btn_VerificarPrimo.TabIndex = 25;
            this.btn_VerificarPrimo.Text = "Verificar";
            this.btn_VerificarPrimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_VerificarPrimo.UseVisualStyleBackColor = true;
            this.btn_VerificarPrimo.Click += new System.EventHandler(this.btn_VerificarPrimo_Click);
            // 
            // lbl_RespostaPrimo
            // 
            this.lbl_RespostaPrimo.AutoSize = true;
            this.lbl_RespostaPrimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RespostaPrimo.Location = new System.Drawing.Point(735, 113);
            this.lbl_RespostaPrimo.Name = "lbl_RespostaPrimo";
            this.lbl_RespostaPrimo.Size = new System.Drawing.Size(0, 25);
            this.lbl_RespostaPrimo.TabIndex = 38;
            // 
            // btn_Lista
            // 
            this.btn_Lista.FlatAppearance.BorderSize = 2;
            this.btn_Lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lista.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lista.Location = new System.Drawing.Point(588, 181);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(135, 47);
            this.btn_Lista.TabIndex = 4128;
            this.btn_Lista.Text = "Listar";
            this.btn_Lista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lista.UseVisualStyleBackColor = true;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // txtbox_dePrimo
            // 
            this.txtbox_dePrimo.Location = new System.Drawing.Point(312, 190);
            this.txtbox_dePrimo.Name = "txtbox_dePrimo";
            this.txtbox_dePrimo.Size = new System.Drawing.Size(92, 31);
            this.txtbox_dePrimo.TabIndex = 26;
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
            // txtBox_atePrimo
            // 
            this.txtBox_atePrimo.Location = new System.Drawing.Point(471, 190);
            this.txtBox_atePrimo.Name = "txtBox_atePrimo";
            this.txtBox_atePrimo.Size = new System.Drawing.Size(101, 31);
            this.txtBox_atePrimo.TabIndex = 27;
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
            this.panel1.Controls.Add(this.txtboxLista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 408);
            this.panel1.TabIndex = 4129;
            // 
            // txtboxLista
            // 
            this.txtboxLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.txtboxLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxLista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtboxLista.Location = new System.Drawing.Point(0, 0);
            this.txtboxLista.Multiline = true;
            this.txtboxLista.Name = "txtboxLista";
            this.txtboxLista.ReadOnly = true;
            this.txtboxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxLista.Size = new System.Drawing.Size(984, 408);
            this.txtboxLista.TabIndex = 4130;
            this.txtboxLista.TextChanged += new System.EventHandler(this.txtboxLista_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(23, 193);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 47);
            this.btnImprimir.TabIndex = 4130;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(786, 193);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 47);
            this.btnLimpar.TabIndex = 4130;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBox_atePrimo);
            this.Controls.Add(this.lbl_AtePrimo);
            this.Controls.Add(this.btn_Lista);
            this.Controls.Add(this.txtbox_dePrimo);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_RespostaPrimo);
            this.Controls.Add(this.btn_VerificarPrimo);
            this.Controls.Add(this.txtbox_Eprimo);
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

        private System.Windows.Forms.Label lblPrimos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.TextBox txtbox_Eprimo;
        private System.Windows.Forms.Button btn_VerificarPrimo;
        private System.Windows.Forms.Label lbl_RespostaPrimo;
        private System.Windows.Forms.Button btn_Lista;
        private System.Windows.Forms.TextBox txtbox_dePrimo;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.TextBox txtBox_atePrimo;
        private System.Windows.Forms.Label lbl_AtePrimo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxLista;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpar;
    }
}