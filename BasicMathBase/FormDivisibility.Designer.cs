
namespace BasicMathBase
{
    partial class FormDivisibility
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
            this.txtboxQuotient = new System.Windows.Forms.TextBox();
            this.lblDividend = new System.Windows.Forms.Label();
            this.lblQuotient = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxDividend = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtboxDivisor = new System.Windows.Forms.TextBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.txtboxRest = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(185, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(756, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Regra Geral de Divisibilidade/ Divisão Euclidiana";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 26;
            // 
            // txtboxQuotient
            // 
            this.txtboxQuotient.Location = new System.Drawing.Point(533, 458);
            this.txtboxQuotient.Name = "txtboxQuotient";
            this.txtboxQuotient.Size = new System.Drawing.Size(126, 31);
            this.txtboxQuotient.TabIndex = 4173;
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDividend.Location = new System.Drawing.Point(170, 461);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(94, 25);
            this.lblDividend.TabIndex = 4176;
            this.lblDividend.Text = "Dividendo";
            // 
            // lblQuotient
            // 
            this.lblQuotient.AutoSize = true;
            this.lblQuotient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuotient.Location = new System.Drawing.Point(434, 461);
            this.lblQuotient.Name = "lblQuotient";
            this.lblQuotient.Size = new System.Drawing.Size(93, 25);
            this.lblQuotient.TabIndex = 4177;
            this.lblQuotient.Text = "Quociente";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(849, 449);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4175;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxDividend
            // 
            this.txtboxDividend.Location = new System.Drawing.Point(285, 458);
            this.txtboxDividend.Name = "txtboxDividend";
            this.txtboxDividend.Size = new System.Drawing.Size(122, 31);
            this.txtboxDividend.TabIndex = 4172;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(680, 449);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 47);
            this.btnCalculate.TabIndex = 4174;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDivisor.Location = new System.Drawing.Point(197, 509);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(67, 25);
            this.lblDivisor.TabIndex = 4179;
            this.lblDivisor.Text = "Divisor";
            // 
            // txtboxDivisor
            // 
            this.txtboxDivisor.Location = new System.Drawing.Point(285, 506);
            this.txtboxDivisor.Name = "txtboxDivisor";
            this.txtboxDivisor.Size = new System.Drawing.Size(122, 31);
            this.txtboxDivisor.TabIndex = 4178;
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRest.Location = new System.Drawing.Point(208, 561);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(56, 25);
            this.lblRest.TabIndex = 4181;
            this.lblRest.Text = "Resto";
            // 
            // txtboxRest
            // 
            this.txtboxRest.Location = new System.Drawing.Point(285, 558);
            this.txtboxRest.Name = "txtboxRest";
            this.txtboxRest.Size = new System.Drawing.Size(122, 31);
            this.txtboxRest.TabIndex = 4180;
            // 
            // FormDivisibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.txtboxRest);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtboxDivisor);
            this.Controls.Add(this.txtboxQuotient);
            this.Controls.Add(this.lblDividend);
            this.Controls.Add(this.lblQuotient);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxDividend);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDivisibility";
            this.Text = "FormDivisibility";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxQuotient;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.Label lblQuotient;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxDividend;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtboxDivisor;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.TextBox txtboxRest;
    }
}