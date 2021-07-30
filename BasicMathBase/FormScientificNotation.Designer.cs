
namespace BasicMathBase
{
    partial class FormScientificNotation
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
            this.txtboxAnwser = new System.Windows.Forms.TextBox();
            this.lblNEqual = new System.Windows.Forms.Label();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxN = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
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
            this.panel3.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(395, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Notação Científica";
            // 
            // txtboxAnwser
            // 
            this.txtboxAnwser.Location = new System.Drawing.Point(627, 228);
            this.txtboxAnwser.Name = "txtboxAnwser";
            this.txtboxAnwser.Size = new System.Drawing.Size(126, 31);
            this.txtboxAnwser.TabIndex = 4166;
            // 
            // lblNEqual
            // 
            this.lblNEqual.AutoSize = true;
            this.lblNEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNEqual.Location = new System.Drawing.Point(310, 231);
            this.lblNEqual.Name = "lblNEqual";
            this.lblNEqual.Size = new System.Drawing.Size(39, 25);
            this.lblNEqual.TabIndex = 4169;
            this.lblNEqual.Text = "n =";
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnwser.Location = new System.Drawing.Point(537, 231);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(84, 25);
            this.lblAnwser.TabIndex = 4171;
            this.lblAnwser.Text = "Resposta";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(562, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 4168;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxN
            // 
            this.txtboxN.Location = new System.Drawing.Point(365, 228);
            this.txtboxN.Name = "txtboxN";
            this.txtboxN.Size = new System.Drawing.Size(122, 31);
            this.txtboxN.TabIndex = 4165;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(393, 311);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 47);
            this.btnCalculate.TabIndex = 4167;
            this.btnCalculate.Text = "Corrigir";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FormScientificNotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.txtboxAnwser);
            this.Controls.Add(this.lblNEqual);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxN);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScientificNotation";
            this.Text = "FormScientificNotation";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxAnwser;
        private System.Windows.Forms.Label lblNEqual;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxN;
        private System.Windows.Forms.Button btnCalculate;
    }
}