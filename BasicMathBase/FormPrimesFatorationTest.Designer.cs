
namespace BasicMathBase
{
    partial class FormPrimesFatorationTest
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
            this.lblTitlePrimePower = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearNum = new System.Windows.Forms.Button();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePrimePower
            // 
            this.lblTitlePrimePower.AutoSize = true;
            this.lblTitlePrimePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitlePrimePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitlePrimePower.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitlePrimePower.Location = new System.Drawing.Point(277, 27);
            this.lblTitlePrimePower.Name = "lblTitlePrimePower";
            this.lblTitlePrimePower.Size = new System.Drawing.Size(420, 37);
            this.lblTitlePrimePower.TabIndex = 2;
            this.lblTitlePrimePower.Text = "Fatoração em primos de K";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelTitle.Controls.Add(this.lblTitlePrimePower);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(984, 95);
            this.panelTitle.TabIndex = 25;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(570, 206);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 55);
            this.btnCalculate.TabIndex = 4147;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearNum
            // 
            this.btnClearNum.FlatAppearance.BorderSize = 2;
            this.btnClearNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNum.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClearNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearNum.Location = new System.Drawing.Point(726, 206);
            this.btnClearNum.Name = "btnClearNum";
            this.btnClearNum.Size = new System.Drawing.Size(108, 55);
            this.btnClearNum.TabIndex = 4146;
            this.btnClearNum.Text = "Limpar";
            this.btnClearNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearNum.UseVisualStyleBackColor = true;
            this.btnClearNum.Click += new System.EventHandler(this.btnClearNum_Click);
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(317, 219);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(203, 31);
            this.txtboxNum.TabIndex = 4145;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum.Location = new System.Drawing.Point(265, 219);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 25);
            this.lblNum.TabIndex = 4144;
            this.lblNum.Text = "n";
            // 
            // FormPrimesFatorationTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClearNum);
            this.Controls.Add(this.txtboxNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimesFatorationTest";
            this.Text = "FormPrimesFatorationTest";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePrimePower;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearNum;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.Label lblNum;
    }
}