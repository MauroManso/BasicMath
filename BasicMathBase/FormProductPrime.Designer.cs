
namespace BasicMathBase
{
    partial class FormProductPrime
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
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCorrectNum = new System.Windows.Forms.Button();
            this.btnClearNum = new System.Windows.Forms.Button();
            this.txtboxResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePrimePower
            // 
            this.lblTitlePrimePower.AutoSize = true;
            this.lblTitlePrimePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitlePrimePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitlePrimePower.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitlePrimePower.Location = new System.Drawing.Point(244, 28);
            this.lblTitlePrimePower.Name = "lblTitlePrimePower";
            this.lblTitlePrimePower.Size = new System.Drawing.Size(515, 37);
            this.lblTitlePrimePower.TabIndex = 2;
            this.lblTitlePrimePower.Text = "Natural como Produto de Primos";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelTitle.Controls.Add(this.lblTitlePrimePower);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(984, 95);
            this.panelTitle.TabIndex = 24;
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(340, 146);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(203, 31);
            this.txtboxNum.TabIndex = 32;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum.Location = new System.Drawing.Point(288, 146);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 25);
            this.lblNum.TabIndex = 31;
            this.lblNum.Text = "n";
            // 
            // btnCorrectNum
            // 
            this.btnCorrectNum.FlatAppearance.BorderSize = 2;
            this.btnCorrectNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectNum.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCorrectNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCorrectNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrectNum.Location = new System.Drawing.Point(325, 318);
            this.btnCorrectNum.Name = "btnCorrectNum";
            this.btnCorrectNum.Size = new System.Drawing.Size(108, 43);
            this.btnCorrectNum.TabIndex = 4141;
            this.btnCorrectNum.Text = "Corrigir";
            this.btnCorrectNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrectNum.UseVisualStyleBackColor = true;
            this.btnCorrectNum.Click += new System.EventHandler(this.btnCorrectNum_Click);
            // 
            // btnClearNum
            // 
            this.btnClearNum.FlatAppearance.BorderSize = 2;
            this.btnClearNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNum.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClearNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearNum.Location = new System.Drawing.Point(569, 318);
            this.btnClearNum.Name = "btnClearNum";
            this.btnClearNum.Size = new System.Drawing.Size(108, 43);
            this.btnClearNum.TabIndex = 4140;
            this.btnClearNum.Text = "Limpar";
            this.btnClearNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearNum.UseVisualStyleBackColor = true;
            this.btnClearNum.Click += new System.EventHandler(this.btnClearNum_Click);
            // 
            // txtboxResposta
            // 
            this.txtboxResposta.Location = new System.Drawing.Point(340, 223);
            this.txtboxResposta.Name = "txtboxResposta";
            this.txtboxResposta.Size = new System.Drawing.Size(459, 31);
            this.txtboxResposta.TabIndex = 4143;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta.Location = new System.Drawing.Point(232, 223);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(84, 25);
            this.lblResposta.TabIndex = 4142;
            this.lblResposta.Text = "Resposta";
            // 
            // FormProductPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.txtboxResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCorrectNum);
            this.Controls.Add(this.btnClearNum);
            this.Controls.Add(this.txtboxNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductPrime";
            this.Text = "FormPrimePower";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePrimePower;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnCorrectNum;
        private System.Windows.Forms.Button btnClearNum;
        private System.Windows.Forms.TextBox txtboxResposta;
        private System.Windows.Forms.Label lblResposta;
    }
}