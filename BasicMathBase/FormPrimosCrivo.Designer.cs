
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
            this.lblPrimos = new System.Windows.Forms.Label();
            this.txtBox_atePrimo = new System.Windows.Forms.TextBox();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.richTextBoxLista = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblPrimos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 95);
            this.panel3.TabIndex = 23;
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.lblPrimos.Location = new System.Drawing.Point(228, 29);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(521, 37);
            this.lblPrimos.TabIndex = 2;
            this.lblPrimos.Text = "NÚMEROS PRIMOS POR CRIVO";
            // 
            // txtBox_atePrimo
            // 
            this.txtBox_atePrimo.Location = new System.Drawing.Point(441, 149);
            this.txtBox_atePrimo.Name = "txtBox_atePrimo";
            this.txtBox_atePrimo.Size = new System.Drawing.Size(101, 31);
            this.txtBox_atePrimo.TabIndex = 4130;
            // 
            // btn_Lista
            // 
            this.btn_Lista.FlatAppearance.BorderSize = 2;
            this.btn_Lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lista.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lista.Location = new System.Drawing.Point(572, 140);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(135, 47);
            this.btn_Lista.TabIndex = 4133;
            this.btn_Lista.Text = "Listar";
            this.btn_Lista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lista.UseVisualStyleBackColor = true;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
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
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(807, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 47);
            this.btnLimpar.TabIndex = 4135;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(50, 187);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 47);
            this.btnImprimir.TabIndex = 4136;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormPrimosCrivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.richTextBoxLista);
            this.Controls.Add(this.txtBox_atePrimo);
            this.Controls.Add(this.btn_Lista);
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
        private System.Windows.Forms.Label lblPrimos;
        private System.Windows.Forms.TextBox txtBox_atePrimo;
        private System.Windows.Forms.Button btn_Lista;
        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.RichTextBox richTextBoxLista;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}