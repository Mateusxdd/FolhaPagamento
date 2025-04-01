namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.dtpFolha = new System.Windows.Forms.DateTimePicker();
            this.pnlFolhaPagamento = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.chkPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.pnlFolhaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Location = new System.Drawing.Point(118, 102);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(113, 18);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // dtpFolha
            // 
            this.dtpFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFolha.Location = new System.Drawing.Point(122, 125);
            this.dtpFolha.Name = "dtpFolha";
            this.dtpFolha.Size = new System.Drawing.Size(118, 24);
            this.dtpFolha.TabIndex = 1;
            this.dtpFolha.Value = new System.DateTime(2013, 5, 12, 0, 0, 0, 0);
            // 
            // pnlFolhaPagamento
            // 
            this.pnlFolhaPagamento.Controls.Add(this.btnSair);
            this.pnlFolhaPagamento.Controls.Add(this.btnLimpar);
            this.pnlFolhaPagamento.Controls.Add(this.txtSalarioLiquido);
            this.pnlFolhaPagamento.Controls.Add(this.txtImpostoRenda);
            this.pnlFolhaPagamento.Controls.Add(this.txtSalarioFolha);
            this.pnlFolhaPagamento.Controls.Add(this.lblSalarioLiquido);
            this.pnlFolhaPagamento.Controls.Add(this.label3);
            this.pnlFolhaPagamento.Controls.Add(this.label2);
            this.pnlFolhaPagamento.Controls.Add(this.btnCalcular);
            this.pnlFolhaPagamento.Controls.Add(this.cbbClubeLazer);
            this.pnlFolhaPagamento.Controls.Add(this.lblClubeLazer);
            this.pnlFolhaPagamento.Controls.Add(this.txtSalario);
            this.pnlFolhaPagamento.Controls.Add(this.chkPlanoSaude);
            this.pnlFolhaPagamento.Controls.Add(this.lblSalario);
            this.pnlFolhaPagamento.Controls.Add(this.dtpFolha);
            this.pnlFolhaPagamento.Controls.Add(this.lblDataFolha);
            this.pnlFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFolhaPagamento.Location = new System.Drawing.Point(2, 2);
            this.pnlFolhaPagamento.Name = "pnlFolhaPagamento";
            this.pnlFolhaPagamento.Size = new System.Drawing.Size(784, 561);
            this.pnlFolhaPagamento.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(560, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 39);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(382, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 39);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(534, 292);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(187, 24);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Location = new System.Drawing.Point(534, 225);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(187, 24);
            this.txtImpostoRenda.TabIndex = 11;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Location = new System.Drawing.Point(534, 154);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(187, 24);
            this.txtSalarioFolha.TabIndex = 9;
            this.txtSalarioFolha.TextChanged += new System.EventHandler(this.txtSalarioFolha_TextChanged);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(378, 295);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(120, 18);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Imposto de Renda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salário da Folha";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(382, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 39);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubeLazer.Location = new System.Drawing.Point(122, 385);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(187, 26);
            this.cbbClubeLazer.TabIndex = 6;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Location = new System.Drawing.Point(118, 362);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(121, 18);
            this.lblClubeLazer.TabIndex = 5;
            this.lblClubeLazer.Text = "Clube de Lazer";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Location = new System.Drawing.Point(122, 221);
            this.txtSalario.MaxLength = 6;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(187, 24);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // chkPlanoSaude
            // 
            this.chkPlanoSaude.AutoSize = true;
            this.chkPlanoSaude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkPlanoSaude.Location = new System.Drawing.Point(122, 290);
            this.chkPlanoSaude.Name = "chkPlanoSaude";
            this.chkPlanoSaude.Size = new System.Drawing.Size(141, 22);
            this.chkPlanoSaude.TabIndex = 4;
            this.chkPlanoSaude.Text = "Plano de saúde";
            this.chkPlanoSaude.UseVisualStyleBackColor = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(118, 198);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 18);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlFolhaPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de pagamento";
            this.pnlFolhaPagamento.ResumeLayout(false);
            this.pnlFolhaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpFolha;
        private System.Windows.Forms.Panel pnlFolhaPagamento;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox chkPlanoSaude;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}