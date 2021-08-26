
namespace BasicMathBase
{
    partial class FormIntegerNumbers
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxInteger = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtboxAnwser = new System.Windows.Forms.TextBox();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.lblInteger = new System.Windows.Forms.Label();
            this.radiobtnOposite = new System.Windows.Forms.RadioButton();
            this.radiobtnMultipleInverse = new System.Windows.Forms.RadioButton();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(414, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Números Inteiros";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(835, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 503;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxInteger
            // 
            this.txtboxInteger.Location = new System.Drawing.Point(254, 363);
            this.txtboxInteger.Name = "txtboxInteger";
            this.txtboxInteger.Size = new System.Drawing.Size(122, 31);
            this.txtboxInteger.TabIndex = 500;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(666, 347);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 55);
            this.btnCalculate.TabIndex = 502;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtboxAnwser
            // 
            this.txtboxAnwser.Location = new System.Drawing.Point(504, 359);
            this.txtboxAnwser.Name = "txtboxAnwser";
            this.txtboxAnwser.Size = new System.Drawing.Size(126, 31);
            this.txtboxAnwser.TabIndex = 501;
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnwser.Location = new System.Drawing.Point(414, 359);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(84, 25);
            this.lblAnwser.TabIndex = 4157;
            this.lblAnwser.Text = "Resposta";
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInteger.Location = new System.Drawing.Point(189, 361);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(59, 33);
            this.lblInteger.TabIndex = 4157;
            this.lblInteger.Text = "ℤ  = ";
            // 
            // radiobtnOposite
            // 
            this.radiobtnOposite.AutoSize = true;
            this.radiobtnOposite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radiobtnOposite.Location = new System.Drawing.Point(257, 431);
            this.radiobtnOposite.Name = "radiobtnOposite";
            this.radiobtnOposite.Size = new System.Drawing.Size(98, 29);
            this.radiobtnOposite.TabIndex = 510;
            this.radiobtnOposite.TabStop = true;
            this.radiobtnOposite.Text = "Oposto";
            this.radiobtnOposite.UseVisualStyleBackColor = true;
            // 
            // radiobtnMultipleInverse
            // 
            this.radiobtnMultipleInverse.AutoSize = true;
            this.radiobtnMultipleInverse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radiobtnMultipleInverse.Location = new System.Drawing.Point(257, 479);
            this.radiobtnMultipleInverse.Name = "radiobtnMultipleInverse";
            this.radiobtnMultipleInverse.Size = new System.Drawing.Size(206, 29);
            this.radiobtnMultipleInverse.TabIndex = 511;
            this.radiobtnMultipleInverse.TabStop = true;
            this.radiobtnMultipleInverse.Text = "Inverso Multiplicativo";
            this.radiobtnMultipleInverse.UseVisualStyleBackColor = true;
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
            this.btnInfo.TabIndex = 4158;
            this.btnInfo.Text = "i";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormIntegerNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.radiobtnMultipleInverse);
            this.Controls.Add(this.radiobtnOposite);
            this.Controls.Add(this.txtboxAnwser);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxInteger);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIntegerNumbers";
            this.Text = "v";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxInteger;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtboxAnwser;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.RadioButton radiobtnOposite;
        private System.Windows.Forms.RadioButton radiobtnMultipleInverse;
        private System.Windows.Forms.Button btnInfo;
    }
}