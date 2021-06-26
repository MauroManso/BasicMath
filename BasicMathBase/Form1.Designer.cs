
namespace BasicMathBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMmcMdc = new System.Windows.Forms.Button();
            this.btnPrimePower = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSomaPrimos = new System.Windows.Forms.Button();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.btnNaturalSomaPotencia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnMmcMdc);
            this.panel1.Controls.Add(this.btnPrimePower);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSomaPrimos);
            this.panel1.Controls.Add(this.btnPrimos);
            this.panel1.Controls.Add(this.btnNaturalSomaPotencia);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 452);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 213);
            this.pnlNav.TabIndex = 11;
            // 
            // btnMmcMdc
            // 
            this.btnMmcMdc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMmcMdc.FlatAppearance.BorderSize = 0;
            this.btnMmcMdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMmcMdc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMmcMdc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMmcMdc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMmcMdc.Location = new System.Drawing.Point(0, 387);
            this.btnMmcMdc.Name = "btnMmcMdc";
            this.btnMmcMdc.Size = new System.Drawing.Size(289, 65);
            this.btnMmcMdc.TabIndex = 5;
            this.btnMmcMdc.Text = "MMC e MDC";
            this.btnMmcMdc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMmcMdc.UseVisualStyleBackColor = true;
            this.btnMmcMdc.Click += new System.EventHandler(this.btnMmcMdc_Click);
            this.btnMmcMdc.Leave += new System.EventHandler(this.btnMmcMdc_Leave);
            // 
            // btnPrimePower
            // 
            this.btnPrimePower.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrimePower.FlatAppearance.BorderSize = 0;
            this.btnPrimePower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimePower.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrimePower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrimePower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimePower.Location = new System.Drawing.Point(0, 322);
            this.btnPrimePower.Name = "btnPrimePower";
            this.btnPrimePower.Size = new System.Drawing.Size(289, 65);
            this.btnPrimePower.TabIndex = 4;
            this.btnPrimePower.Text = "n = P₀.10⁰+P₁.10¹ + ... Pₖ.10ᵏ";
            this.btnPrimePower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimePower.UseVisualStyleBackColor = true;
            this.btnPrimePower.Click += new System.EventHandler(this.btnPrimePower_Click);
            this.btnPrimePower.Leave += new System.EventHandler(this.btnPrimePower_Leave);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(0, 665);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(289, 55);
            this.btnAjuda.TabIndex = 1;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            this.btnAjuda.Leave += new System.EventHandler(this.btnAjuda_Leave);
            // 
            // btnSomaPrimos
            // 
            this.btnSomaPrimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSomaPrimos.FlatAppearance.BorderSize = 0;
            this.btnSomaPrimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomaPrimos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSomaPrimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSomaPrimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSomaPrimos.Location = new System.Drawing.Point(0, 257);
            this.btnSomaPrimos.Name = "btnSomaPrimos";
            this.btnSomaPrimos.Size = new System.Drawing.Size(289, 65);
            this.btnSomaPrimos.TabIndex = 3;
            this.btnSomaPrimos.Text = "Crivo";
            this.btnSomaPrimos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSomaPrimos.UseVisualStyleBackColor = true;
            this.btnSomaPrimos.Click += new System.EventHandler(this.btnSomaPrimos_Click);
            this.btnSomaPrimos.Leave += new System.EventHandler(this.btnSomaPrimos_Leave);
            // 
            // btnPrimos
            // 
            this.btnPrimos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrimos.FlatAppearance.BorderSize = 0;
            this.btnPrimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimos.Location = new System.Drawing.Point(0, 192);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(289, 65);
            this.btnPrimos.TabIndex = 2;
            this.btnPrimos.Text = "Números Primos";
            this.btnPrimos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            this.btnPrimos.Leave += new System.EventHandler(this.btnPrimos_Leave);
            // 
            // btnNaturalSomaPotencia
            // 
            this.btnNaturalSomaPotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnNaturalSomaPotencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNaturalSomaPotencia.FlatAppearance.BorderSize = 0;
            this.btnNaturalSomaPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaturalSomaPotencia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNaturalSomaPotencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNaturalSomaPotencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNaturalSomaPotencia.Location = new System.Drawing.Point(0, 127);
            this.btnNaturalSomaPotencia.Name = "btnNaturalSomaPotencia";
            this.btnNaturalSomaPotencia.Size = new System.Drawing.Size(289, 65);
            this.btnNaturalSomaPotencia.TabIndex = 1;
            this.btnNaturalSomaPotencia.Text = "n = a₀.10⁰+a₁.10¹ + ... aₖ.10ᵏ";
            this.btnNaturalSomaPotencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNaturalSomaPotencia.UseVisualStyleBackColor = false;
            this.btnNaturalSomaPotencia.Click += new System.EventHandler(this.BtnNaturalSomaPotencia_Click);
            this.btnNaturalSomaPotencia.Leave += new System.EventHandler(this.btnNaturalSomaPotencia_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 127);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(289, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(997, 720);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1286, 720);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Math v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNaturalSomaPotencia;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSomaPrimos;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMmcMdc;
        private System.Windows.Forms.Button btnPrimePower;
    }
}

