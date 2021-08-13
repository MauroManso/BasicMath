
namespace BasicMathBase
{
    partial class FormPower
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
            this.lblAnwser = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxToPowerOf = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtboxBase = new System.Windows.Forms.TextBox();
            this.lblToPowerOf = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(478, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Potência";
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
            // txtboxAnwser
            // 
            this.txtboxAnwser.Location = new System.Drawing.Point(501, 388);
            this.txtboxAnwser.Name = "txtboxAnwser";
            this.txtboxAnwser.Size = new System.Drawing.Size(126, 31);
            this.txtboxAnwser.TabIndex = 502;
            // 
            // lblAnwser
            // 
            this.lblAnwser.AutoSize = true;
            this.lblAnwser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnwser.Location = new System.Drawing.Point(411, 391);
            this.lblAnwser.Name = "lblAnwser";
            this.lblAnwser.Size = new System.Drawing.Size(84, 25);
            this.lblAnwser.TabIndex = 4163;
            this.lblAnwser.Text = "Resposta";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(813, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 504;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtboxToPowerOf
            // 
            this.txtboxToPowerOf.Location = new System.Drawing.Point(254, 369);
            this.txtboxToPowerOf.Name = "txtboxToPowerOf";
            this.txtboxToPowerOf.Size = new System.Drawing.Size(122, 31);
            this.txtboxToPowerOf.TabIndex = 501;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(648, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 55);
            this.btnCalculate.TabIndex = 503;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBase.Location = new System.Drawing.Point(187, 409);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(48, 25);
            this.lblBase.TabIndex = 4163;
            this.lblBase.Text = "Base";
            // 
            // txtboxBase
            // 
            this.txtboxBase.Location = new System.Drawing.Point(254, 406);
            this.txtboxBase.Name = "txtboxBase";
            this.txtboxBase.Size = new System.Drawing.Size(122, 31);
            this.txtboxBase.TabIndex = 500;
            // 
            // lblToPowerOf
            // 
            this.lblToPowerOf.AutoSize = true;
            this.lblToPowerOf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToPowerOf.Location = new System.Drawing.Point(150, 372);
            this.lblToPowerOf.Name = "lblToPowerOf";
            this.lblToPowerOf.Size = new System.Drawing.Size(85, 25);
            this.lblToPowerOf.TabIndex = 4163;
            this.lblToPowerOf.Text = "Expoente";
            // 
            // FormPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.txtboxAnwser);
            this.Controls.Add(this.lblToPowerOf);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblAnwser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxBase);
            this.Controls.Add(this.txtboxToPowerOf);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPower";
            this.Text = "FormPower";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxAnwser;
        private System.Windows.Forms.Label lblAnwser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxToPowerOf;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtboxBase;
        private System.Windows.Forms.Label lblToPowerOf;
    }
}