
namespace BasicMathBase
{
    partial class FormFractionAddSubtraction
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
            this.txtboxNumerator = new System.Windows.Forms.TextBox();
            this.txtboxDenominator = new System.Windows.Forms.TextBox();
            this.txtboxDenominator2 = new System.Windows.Forms.TextBox();
            this.txtboxNumerator2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtboxAnswerNumerator = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtboxAnswerDenominator = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.panel3.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(322, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(468, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Adição/Subtração de Frações";
            // 
            // txtboxNumerator
            // 
            this.txtboxNumerator.Location = new System.Drawing.Point(141, 254);
            this.txtboxNumerator.Name = "txtboxNumerator";
            this.txtboxNumerator.PlaceholderText = "Numerador";
            this.txtboxNumerator.Size = new System.Drawing.Size(122, 31);
            this.txtboxNumerator.TabIndex = 200;
            // 
            // txtboxDenominator
            // 
            this.txtboxDenominator.Location = new System.Drawing.Point(141, 300);
            this.txtboxDenominator.Name = "txtboxDenominator";
            this.txtboxDenominator.PlaceholderText = "Denominador";
            this.txtboxDenominator.Size = new System.Drawing.Size(122, 31);
            this.txtboxDenominator.TabIndex = 201;
            // 
            // txtboxDenominator2
            // 
            this.txtboxDenominator2.Location = new System.Drawing.Point(337, 300);
            this.txtboxDenominator2.Name = "txtboxDenominator2";
            this.txtboxDenominator2.PlaceholderText = "Denominador";
            this.txtboxDenominator2.Size = new System.Drawing.Size(122, 31);
            this.txtboxDenominator2.TabIndex = 211;
            // 
            // txtboxNumerator2
            // 
            this.txtboxNumerator2.Location = new System.Drawing.Point(337, 254);
            this.txtboxNumerator2.Name = "txtboxNumerator2";
            this.txtboxNumerator2.PlaceholderText = "Numerador";
            this.txtboxNumerator2.Size = new System.Drawing.Size(122, 31);
            this.txtboxNumerator2.TabIndex = 210;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(423, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 47);
            this.btnClear.TabIndex = 231;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(254, 391);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 47);
            this.btnCalculate.TabIndex = 230;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtboxAnswerNumerator
            // 
            this.txtboxAnswerNumerator.Location = new System.Drawing.Point(638, 254);
            this.txtboxAnswerNumerator.Name = "txtboxAnswerNumerator";
            this.txtboxAnswerNumerator.PlaceholderText = "Numerador";
            this.txtboxAnswerNumerator.Size = new System.Drawing.Size(122, 31);
            this.txtboxAnswerNumerator.TabIndex = 220;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswer.Location = new System.Drawing.Point(522, 280);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(88, 25);
            this.lblAnswer.TabIndex = 4173;
            this.lblAnswer.Text = "Resposta:";
            // 
            // txtboxAnswerDenominator
            // 
            this.txtboxAnswerDenominator.Location = new System.Drawing.Point(638, 300);
            this.txtboxAnswerDenominator.Name = "txtboxAnswerDenominator";
            this.txtboxAnswerDenominator.PlaceholderText = "Denominador";
            this.txtboxAnswerDenominator.Size = new System.Drawing.Size(122, 31);
            this.txtboxAnswerDenominator.TabIndex = 221;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(131, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 3);
            this.panel1.TabIndex = 4174;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(327, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 3);
            this.panel2.TabIndex = 4174;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(628, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 3);
            this.panel4.TabIndex = 4174;
            // 
            // FormFractionAddSubtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtboxAnswerDenominator);
            this.Controls.Add(this.txtboxAnswerNumerator);
            this.Controls.Add(this.txtboxNumerator2);
            this.Controls.Add(this.txtboxDenominator2);
            this.Controls.Add(this.txtboxNumerator);
            this.Controls.Add(this.txtboxDenominator);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFractionAddSubtraction";
            this.Text = "FormFractionAddSubtraction";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxNumerator;
        private System.Windows.Forms.TextBox txtboxDenominator;
        private System.Windows.Forms.TextBox txtboxDenominator2;
        private System.Windows.Forms.TextBox txtboxNumerator2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtboxAnswerNumerator;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtboxAnswerDenominator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}