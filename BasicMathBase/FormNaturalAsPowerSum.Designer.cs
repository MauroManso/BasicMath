
namespace BasicMathBase
{
    partial class FormNaturalAsPowerSum
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.checkboxOrdemClasse = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbResposta = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.checkboxParidade = new System.Windows.Forms.CheckBox();
            this.lblParidade = new System.Windows.Forms.Label();
            this.radioButtonPar = new System.Windows.Forms.RadioButton();
            this.radioButtonImpar = new System.Windows.Forms.RadioButton();
            this.panelTable = new System.Windows.Forms.Panel();
            this.tb_uUnidade = new System.Windows.Forms.TextBox();
            this.tb_uMilhar = new System.Windows.Forms.TextBox();
            this.tb_uMilhao = new System.Windows.Forms.TextBox();
            this.tb_dUnidade = new System.Windows.Forms.TextBox();
            this.tb_dMilhar = new System.Windows.Forms.TextBox();
            this.tb_dMilhao = new System.Windows.Forms.TextBox();
            this.tb_cUnidade = new System.Windows.Forms.TextBox();
            this.tb_cMilhar = new System.Windows.Forms.TextBox();
            this.tb_cMilhao = new System.Windows.Forms.TextBox();
            this.lbl_Unidades = new System.Windows.Forms.Label();
            this.lbl_Milhares = new System.Windows.Forms.Label();
            this.lbl_Milhões = new System.Windows.Forms.Label();
            this.tlbOrdemClase = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.tlbOrdemClase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatAppearance.BorderSize = 2;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(336, 622);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(135, 65);
            this.btn_Limpar.TabIndex = 44;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // checkboxOrdemClasse
            // 
            this.checkboxOrdemClasse.AutoSize = true;
            this.checkboxOrdemClasse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkboxOrdemClasse.Location = new System.Drawing.Point(380, 395);
            this.checkboxOrdemClasse.Name = "checkboxOrdemClasse";
            this.checkboxOrdemClasse.Size = new System.Drawing.Size(162, 29);
            this.checkboxOrdemClasse.TabIndex = 32;
            this.checkboxOrdemClasse.Text = "Ordem e Classe";
            this.checkboxOrdemClasse.UseVisualStyleBackColor = true;
            this.checkboxOrdemClasse.CheckedChanged += new System.EventHandler(this.cb_ModoOrdemClasse_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 95);
            this.panel3.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(184, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(705, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Natural como Soma de Potências de Base 10";
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.FlatAppearance.BorderSize = 2;
            this.btnCorrigir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrigir.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCorrigir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCorrigir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrigir.Location = new System.Drawing.Point(541, 622);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(280, 65);
            this.btnCorrigir.TabIndex = 45;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(375, 215);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(203, 31);
            this.tbNum.TabIndex = 30;
            // 
            // tbResposta
            // 
            this.tbResposta.Location = new System.Drawing.Point(375, 327);
            this.tbResposta.Name = "tbResposta";
            this.tbResposta.Size = new System.Drawing.Size(459, 31);
            this.tbResposta.TabIndex = 31;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErro.Location = new System.Drawing.Point(375, 274);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 25);
            this.lblErro.TabIndex = 16;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta.Location = new System.Drawing.Point(267, 327);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(84, 25);
            this.lblResposta.TabIndex = 17;
            this.lblResposta.Text = "Resposta";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum.Location = new System.Drawing.Point(323, 215);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(22, 25);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "n";
            // 
            // checkboxParidade
            // 
            this.checkboxParidade.AutoSize = true;
            this.checkboxParidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkboxParidade.Location = new System.Drawing.Point(377, 273);
            this.checkboxParidade.Name = "checkboxParidade";
            this.checkboxParidade.Size = new System.Drawing.Size(106, 29);
            this.checkboxParidade.TabIndex = 46;
            this.checkboxParidade.Text = "Paridade";
            this.checkboxParidade.UseVisualStyleBackColor = true;
            this.checkboxParidade.CheckedChanged += new System.EventHandler(this.checkboxParidade_CheckedChanged);
            // 
            // lblParidade
            // 
            this.lblParidade.AutoSize = true;
            this.lblParidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParidade.Location = new System.Drawing.Point(499, 275);
            this.lblParidade.Name = "lblParidade";
            this.lblParidade.Size = new System.Drawing.Size(111, 25);
            this.lblParidade.TabIndex = 15;
            this.lblParidade.Text = "O número é:";
            // 
            // radioButtonPar
            // 
            this.radioButtonPar.AutoSize = true;
            this.radioButtonPar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonPar.Location = new System.Drawing.Point(634, 273);
            this.radioButtonPar.Name = "radioButtonPar";
            this.radioButtonPar.Size = new System.Drawing.Size(61, 29);
            this.radioButtonPar.TabIndex = 47;
            this.radioButtonPar.TabStop = true;
            this.radioButtonPar.Text = "Par";
            this.radioButtonPar.UseVisualStyleBackColor = true;
            // 
            // radioButtonImpar
            // 
            this.radioButtonImpar.AutoSize = true;
            this.radioButtonImpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonImpar.Location = new System.Drawing.Point(716, 272);
            this.radioButtonImpar.Name = "radioButtonImpar";
            this.radioButtonImpar.Size = new System.Drawing.Size(84, 29);
            this.radioButtonImpar.TabIndex = 47;
            this.radioButtonImpar.TabStop = true;
            this.radioButtonImpar.Text = "Impar";
            this.radioButtonImpar.UseVisualStyleBackColor = true;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.tb_uUnidade);
            this.panelTable.Controls.Add(this.tb_uMilhar);
            this.panelTable.Controls.Add(this.tb_uMilhao);
            this.panelTable.Controls.Add(this.tb_dUnidade);
            this.panelTable.Controls.Add(this.tb_dMilhar);
            this.panelTable.Controls.Add(this.tb_dMilhao);
            this.panelTable.Controls.Add(this.tb_cUnidade);
            this.panelTable.Controls.Add(this.tb_cMilhar);
            this.panelTable.Controls.Add(this.tb_cMilhao);
            this.panelTable.Controls.Add(this.lbl_Unidades);
            this.panelTable.Controls.Add(this.lbl_Milhares);
            this.panelTable.Controls.Add(this.lbl_Milhões);
            this.panelTable.Controls.Add(this.tlbOrdemClase);
            this.panelTable.Location = new System.Drawing.Point(276, 430);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(623, 183);
            this.panelTable.TabIndex = 48;
            // 
            // tb_uUnidade
            // 
            this.tb_uUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_uUnidade.BackColor = System.Drawing.Color.White;
            this.tb_uUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_uUnidade.Location = new System.Drawing.Point(496, 112);
            this.tb_uUnidade.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_uUnidade.Name = "tb_uUnidade";
            this.tb_uUnidade.Size = new System.Drawing.Size(41, 31);
            this.tb_uUnidade.TabIndex = 56;
            this.tb_uUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_uMilhar
            // 
            this.tb_uMilhar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_uMilhar.BackColor = System.Drawing.Color.White;
            this.tb_uMilhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_uMilhar.Location = new System.Drawing.Point(332, 112);
            this.tb_uMilhar.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_uMilhar.Name = "tb_uMilhar";
            this.tb_uMilhar.Size = new System.Drawing.Size(41, 31);
            this.tb_uMilhar.TabIndex = 53;
            this.tb_uMilhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_uMilhao
            // 
            this.tb_uMilhao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_uMilhao.BackColor = System.Drawing.Color.White;
            this.tb_uMilhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_uMilhao.Location = new System.Drawing.Point(168, 112);
            this.tb_uMilhao.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_uMilhao.Name = "tb_uMilhao";
            this.tb_uMilhao.Size = new System.Drawing.Size(41, 31);
            this.tb_uMilhao.TabIndex = 50;
            this.tb_uMilhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_dUnidade
            // 
            this.tb_dUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_dUnidade.BackColor = System.Drawing.Color.White;
            this.tb_dUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dUnidade.Location = new System.Drawing.Point(455, 112);
            this.tb_dUnidade.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_dUnidade.Name = "tb_dUnidade";
            this.tb_dUnidade.Size = new System.Drawing.Size(41, 31);
            this.tb_dUnidade.TabIndex = 55;
            this.tb_dUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_dMilhar
            // 
            this.tb_dMilhar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_dMilhar.BackColor = System.Drawing.Color.White;
            this.tb_dMilhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dMilhar.Location = new System.Drawing.Point(291, 112);
            this.tb_dMilhar.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_dMilhar.Name = "tb_dMilhar";
            this.tb_dMilhar.Size = new System.Drawing.Size(41, 31);
            this.tb_dMilhar.TabIndex = 52;
            this.tb_dMilhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_dMilhao
            // 
            this.tb_dMilhao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_dMilhao.BackColor = System.Drawing.Color.White;
            this.tb_dMilhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dMilhao.Location = new System.Drawing.Point(127, 112);
            this.tb_dMilhao.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_dMilhao.Name = "tb_dMilhao";
            this.tb_dMilhao.Size = new System.Drawing.Size(41, 31);
            this.tb_dMilhao.TabIndex = 49;
            this.tb_dMilhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cUnidade
            // 
            this.tb_cUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_cUnidade.BackColor = System.Drawing.Color.White;
            this.tb_cUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cUnidade.Location = new System.Drawing.Point(413, 112);
            this.tb_cUnidade.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_cUnidade.Name = "tb_cUnidade";
            this.tb_cUnidade.Size = new System.Drawing.Size(42, 31);
            this.tb_cUnidade.TabIndex = 54;
            this.tb_cUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cMilhar
            // 
            this.tb_cMilhar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_cMilhar.BackColor = System.Drawing.Color.White;
            this.tb_cMilhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cMilhar.Location = new System.Drawing.Point(249, 112);
            this.tb_cMilhar.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_cMilhar.Name = "tb_cMilhar";
            this.tb_cMilhar.Size = new System.Drawing.Size(42, 31);
            this.tb_cMilhar.TabIndex = 51;
            this.tb_cMilhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cMilhao
            // 
            this.tb_cMilhao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_cMilhao.BackColor = System.Drawing.Color.White;
            this.tb_cMilhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cMilhao.Location = new System.Drawing.Point(85, 112);
            this.tb_cMilhao.MinimumSize = new System.Drawing.Size(2, 40);
            this.tb_cMilhao.Name = "tb_cMilhao";
            this.tb_cMilhao.Size = new System.Drawing.Size(42, 31);
            this.tb_cMilhao.TabIndex = 48;
            this.tb_cMilhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Unidades
            // 
            this.lbl_Unidades.AutoSize = true;
            this.lbl_Unidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Unidades.Location = new System.Drawing.Point(436, 25);
            this.lbl_Unidades.Name = "lbl_Unidades";
            this.lbl_Unidades.Size = new System.Drawing.Size(86, 25);
            this.lbl_Unidades.TabIndex = 45;
            this.lbl_Unidades.Text = "Unidades";
            // 
            // lbl_Milhares
            // 
            this.lbl_Milhares.AutoSize = true;
            this.lbl_Milhares.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Milhares.Location = new System.Drawing.Point(274, 25);
            this.lbl_Milhares.Name = "lbl_Milhares";
            this.lbl_Milhares.Size = new System.Drawing.Size(78, 25);
            this.lbl_Milhares.TabIndex = 46;
            this.lbl_Milhares.Text = "Milhares";
            // 
            // lbl_Milhões
            // 
            this.lbl_Milhões.AutoSize = true;
            this.lbl_Milhões.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Milhões.Location = new System.Drawing.Point(121, 25);
            this.lbl_Milhões.Name = "lbl_Milhões";
            this.lbl_Milhões.Size = new System.Drawing.Size(74, 25);
            this.lbl_Milhões.TabIndex = 47;
            this.lbl_Milhões.Text = "Milhões";
            // 
            // tlbOrdemClase
            // 
            this.tlbOrdemClase.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlbOrdemClase.ColumnCount = 11;
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlbOrdemClase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlbOrdemClase.Controls.Add(this.label3, 9, 0);
            this.tlbOrdemClase.Controls.Add(this.label4, 8, 0);
            this.tlbOrdemClase.Controls.Add(this.label5, 6, 0);
            this.tlbOrdemClase.Controls.Add(this.label6, 5, 0);
            this.tlbOrdemClase.Controls.Add(this.label7, 4, 0);
            this.tlbOrdemClase.Controls.Add(this.label8, 2, 0);
            this.tlbOrdemClase.Controls.Add(this.label9, 1, 0);
            this.tlbOrdemClase.Controls.Add(this.label10, 0, 0);
            this.tlbOrdemClase.Controls.Add(this.label1, 10, 0);
            this.tlbOrdemClase.Location = new System.Drawing.Point(86, 59);
            this.tlbOrdemClase.Name = "tlbOrdemClase";
            this.tlbOrdemClase.RowCount = 1;
            this.tlbOrdemClase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlbOrdemClase.Size = new System.Drawing.Size(451, 54);
            this.tlbOrdemClase.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(378, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "d";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(339, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(256, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "u";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(214, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "d";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(175, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "c";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(92, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "u";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(50, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "d";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(11, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(414, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "u";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNaturalAsPowerSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1128, 894);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.radioButtonImpar);
            this.Controls.Add(this.radioButtonPar);
            this.Controls.Add(this.checkboxParidade);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.checkboxOrdemClasse);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCorrigir);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.tbResposta);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblParidade);
            this.Controls.Add(this.lblNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNaturalAsPowerSum";
            this.Text = "Form3";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.tlbOrdemClase.ResumeLayout(false);
            this.tlbOrdemClase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.CheckBox checkboxOrdemClasse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbResposta;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.CheckBox checkboxParidade;
        private System.Windows.Forms.Label lblParidade;
        private System.Windows.Forms.RadioButton radioButtonPar;
        private System.Windows.Forms.RadioButton radioButtonImpar;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.TextBox tb_uUnidade;
        private System.Windows.Forms.TextBox tb_uMilhar;
        private System.Windows.Forms.TextBox tb_uMilhao;
        private System.Windows.Forms.TextBox tb_dUnidade;
        private System.Windows.Forms.TextBox tb_dMilhar;
        private System.Windows.Forms.TextBox tb_dMilhao;
        private System.Windows.Forms.TextBox tb_cUnidade;
        private System.Windows.Forms.TextBox tb_cMilhar;
        private System.Windows.Forms.TextBox tb_cMilhao;
        private System.Windows.Forms.Label lbl_Unidades;
        private System.Windows.Forms.Label lbl_Milhares;
        private System.Windows.Forms.Label lbl_Milhões;
        private System.Windows.Forms.TableLayoutPanel tlbOrdemClase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}