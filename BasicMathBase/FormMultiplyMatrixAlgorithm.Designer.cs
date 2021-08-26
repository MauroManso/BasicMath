
namespace BasicMathBase
{
    partial class FormMultiplyMatrixAlgorithm
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
            this.txtboxAnwser = new System.Windows.Forms.TextBox();
            this.lblFactor1 = new System.Windows.Forms.Label();
            this.lblFactor2 = new System.Windows.Forms.Label();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxFactor2 = new System.Windows.Forms.TextBox();
            this.txtboxFactor1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(286, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(589, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Algoritimo de Multiplicação por Matriz";
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
            // txtboxAnwser
            // 
            this.txtboxAnwser.Location = new System.Drawing.Point(499, 432);
            this.txtboxAnwser.Name = "txtboxAnwser";
            this.txtboxAnwser.Size = new System.Drawing.Size(126, 31);
            this.txtboxAnwser.TabIndex = 4174;
            // 
            // lblFactor1
            // 
            this.lblFactor1.AutoSize = true;
            this.lblFactor1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFactor1.Location = new System.Drawing.Point(179, 416);
            this.lblFactor1.Name = "lblFactor1";
            this.lblFactor1.Size = new System.Drawing.Size(67, 25);
            this.lblFactor1.TabIndex = 4177;
            this.lblFactor1.Text = "Fator 1";
            // 
            // lblFactor2
            // 
            this.lblFactor2.AutoSize = true;
            this.lblFactor2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFactor2.Location = new System.Drawing.Point(179, 453);
            this.lblFactor2.Name = "lblFactor2";
            this.lblFactor2.Size = new System.Drawing.Size(67, 25);
            this.lblFactor2.TabIndex = 4178;
            this.lblFactor2.Text = "Fator 2";
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnwser.Location = new System.Drawing.Point(409, 435);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(84, 25);
            this.lblAnwser.TabIndex = 4179;
            this.lblAnwser.Text = "Resposta";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(816, 419);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 4176;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxFactor2
            // 
            this.txtboxFactor2.Location = new System.Drawing.Point(252, 450);
            this.txtboxFactor2.Name = "txtboxFactor2";
            this.txtboxFactor2.Size = new System.Drawing.Size(122, 31);
            this.txtboxFactor2.TabIndex = 4173;
            // 
            // txtboxFactor1
            // 
            this.txtboxFactor1.Location = new System.Drawing.Point(252, 413);
            this.txtboxFactor1.Name = "txtboxFactor1";
            this.txtboxFactor1.Size = new System.Drawing.Size(122, 31);
            this.txtboxFactor1.TabIndex = 4172;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(646, 419);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 55);
            this.btnCalculate.TabIndex = 4175;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.FlatAppearance.BorderSize = 2;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(1066, 101);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 50);
            this.btnInfo.TabIndex = 4180;
            this.btnInfo.Text = "i";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormMultiplyMatrixAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtboxAnwser);
            this.Controls.Add(this.lblFactor1);
            this.Controls.Add(this.lblFactor2);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxFactor2);
            this.Controls.Add(this.txtboxFactor1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMultiplyMatrixAlgorithm";
            this.Text = "FormMultiplyMatrixAlgorithm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxAnwser;
        private System.Windows.Forms.Label lblFactor1;
        private System.Windows.Forms.Label lblFactor2;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxFactor2;
        private System.Windows.Forms.TextBox txtboxFactor1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnInfo;
    }
}