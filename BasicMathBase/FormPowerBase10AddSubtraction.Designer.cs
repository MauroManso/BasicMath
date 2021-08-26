
namespace BasicMathBase
{
    partial class FormPowerBase10AddSubtraction
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
            this.lblN1Equal = new System.Windows.Forms.Label();
            this.lblAnwser = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxN1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtboxN2 = new System.Windows.Forms.TextBox();
            this.lblN2Equal = new System.Windows.Forms.Label();
            this.lblN1x10ToPowerOf = new System.Windows.Forms.Label();
            this.txtboxN1x10ToPowerOf = new System.Windows.Forms.TextBox();
            this.lblN2x10ToPowerOf = new System.Windows.Forms.Label();
            this.txtboxN2x10ToPowerOf = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(260, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Adição/Subtração com Potências de Base 10";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 29;
            // 
            // txtboxAnwser
            // 
            this.txtboxAnwser.Location = new System.Drawing.Point(554, 290);
            this.txtboxAnwser.Name = "txtboxAnwser";
            this.txtboxAnwser.Size = new System.Drawing.Size(126, 31);
            this.txtboxAnwser.TabIndex = 4173;
            // 
            // lblN1Equal
            // 
            this.lblN1Equal.AutoSize = true;
            this.lblN1Equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN1Equal.Location = new System.Drawing.Point(226, 222);
            this.lblN1Equal.Name = "lblN1Equal";
            this.lblN1Equal.Size = new System.Drawing.Size(45, 25);
            this.lblN1Equal.TabIndex = 4176;
            this.lblN1Equal.Text = "n₁ =";
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnwser.Location = new System.Drawing.Point(464, 293);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(84, 25);
            this.lblAnwser.TabIndex = 4177;
            this.lblAnwser.Text = "Resposta";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(591, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 4175;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxN1
            // 
            this.txtboxN1.Location = new System.Drawing.Point(281, 219);
            this.txtboxN1.Name = "txtboxN1";
            this.txtboxN1.Size = new System.Drawing.Size(122, 31);
            this.txtboxN1.TabIndex = 4172;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(422, 364);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 55);
            this.btnCalculate.TabIndex = 4174;
            this.btnCalculate.Text = "Corrigir";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtboxN2
            // 
            this.txtboxN2.Location = new System.Drawing.Point(652, 219);
            this.txtboxN2.Name = "txtboxN2";
            this.txtboxN2.Size = new System.Drawing.Size(122, 31);
            this.txtboxN2.TabIndex = 4172;
            // 
            // lblN2Equal
            // 
            this.lblN2Equal.AutoSize = true;
            this.lblN2Equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN2Equal.Location = new System.Drawing.Point(600, 222);
            this.lblN2Equal.Name = "lblN2Equal";
            this.lblN2Equal.Size = new System.Drawing.Size(46, 25);
            this.lblN2Equal.TabIndex = 4176;
            this.lblN2Equal.Text = "n₂ =";
            // 
            // lblN1x10ToPowerOf
            // 
            this.lblN1x10ToPowerOf.AutoSize = true;
            this.lblN1x10ToPowerOf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN1x10ToPowerOf.Location = new System.Drawing.Point(416, 222);
            this.lblN1x10ToPowerOf.Name = "lblN1x10ToPowerOf";
            this.lblN1x10ToPowerOf.Size = new System.Drawing.Size(53, 25);
            this.lblN1x10ToPowerOf.TabIndex = 4177;
            this.lblN1x10ToPowerOf.Text = ".10 ^";
            // 
            // txtboxN1x10ToPowerOf
            // 
            this.txtboxN1x10ToPowerOf.Location = new System.Drawing.Point(475, 219);
            this.txtboxN1x10ToPowerOf.Name = "txtboxN1x10ToPowerOf";
            this.txtboxN1x10ToPowerOf.Size = new System.Drawing.Size(55, 31);
            this.txtboxN1x10ToPowerOf.TabIndex = 4173;
            // 
            // lblN2x10ToPowerOf
            // 
            this.lblN2x10ToPowerOf.AutoSize = true;
            this.lblN2x10ToPowerOf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN2x10ToPowerOf.Location = new System.Drawing.Point(787, 222);
            this.lblN2x10ToPowerOf.Name = "lblN2x10ToPowerOf";
            this.lblN2x10ToPowerOf.Size = new System.Drawing.Size(53, 25);
            this.lblN2x10ToPowerOf.TabIndex = 4177;
            this.lblN2x10ToPowerOf.Text = ".10 ^";
            // 
            // txtboxN2x10ToPowerOf
            // 
            this.txtboxN2x10ToPowerOf.Location = new System.Drawing.Point(846, 219);
            this.txtboxN2x10ToPowerOf.Name = "txtboxN2x10ToPowerOf";
            this.txtboxN2x10ToPowerOf.Size = new System.Drawing.Size(55, 31);
            this.txtboxN2x10ToPowerOf.TabIndex = 4173;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlus.Location = new System.Drawing.Point(554, 219);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(27, 29);
            this.lblPlus.TabIndex = 4177;
            this.lblPlus.Text = "+";
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
            this.btnInfo.TabIndex = 4178;
            this.btnInfo.Text = "i";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormPowerBase10AddSubtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtboxN2x10ToPowerOf);
            this.Controls.Add(this.txtboxN1x10ToPowerOf);
            this.Controls.Add(this.txtboxAnwser);
            this.Controls.Add(this.lblN2Equal);
            this.Controls.Add(this.lblN2x10ToPowerOf);
            this.Controls.Add(this.lblN1Equal);
            this.Controls.Add(this.lblN1x10ToPowerOf);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxN2);
            this.Controls.Add(this.txtboxN1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPowerBase10AddSubtraction";
            this.Text = "FormPowerBase10AddSubtraction1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxAnwser;
        private System.Windows.Forms.Label lblN1Equal;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxN1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtboxN2;
        private System.Windows.Forms.Label lblN2Equal;
        private System.Windows.Forms.Label lblN1x10ToPowerOf;
        private System.Windows.Forms.TextBox txtboxN1x10ToPowerOf;
        private System.Windows.Forms.Label lblN2x10ToPowerOf;
        private System.Windows.Forms.TextBox txtboxN2x10ToPowerOf;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Button btnInfo;
    }
}