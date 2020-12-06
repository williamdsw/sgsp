namespace SGSP___Desktop
{
    partial class frmEncaminharAtendimento
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
            this.components = new System.ComponentModel.Container();
            this.gpbDadosAluno = new System.Windows.Forms.GroupBox();
            this.cmbNomeAluno = new MetroFramework.Controls.MetroComboBox();
            this.txtProntuarioAluno = new MetroFramework.Controls.MetroTextBox();
            this.lblProntuarioAluno = new MetroFramework.Controls.MetroLabel();
            this.lblNomeAluno = new MetroFramework.Controls.MetroLabel();
            this.gpbAgendar = new System.Windows.Forms.GroupBox();
            this.cmbTurno = new MetroFramework.Controls.MetroComboBox();
            this.cmbDiaSemana = new MetroFramework.Controls.MetroComboBox();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.cmbProfissional = new MetroFramework.Controls.MetroComboBox();
            this.lblProfissional = new MetroFramework.Controls.MetroLabel();
            this.cmbEncaminharCom = new MetroFramework.Controls.MetroComboBox();
            this.lblEncaminhar = new MetroFramework.Controls.MetroLabel();
            this.lblTurno = new MetroFramework.Controls.MetroLabel();
            this.lblDemanda = new MetroFramework.Controls.MetroLabel();
            this.lblDiaSemana = new MetroFramework.Controls.MetroLabel();
            this.txtDemanda = new MetroFramework.Controls.MetroTextBox();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.btnConcluir = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbDadosAluno.SuspendLayout();
            this.gpbAgendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosAluno
            // 
            this.gpbDadosAluno.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosAluno.Controls.Add(this.cmbNomeAluno);
            this.gpbDadosAluno.Controls.Add(this.txtProntuarioAluno);
            this.gpbDadosAluno.Controls.Add(this.lblProntuarioAluno);
            this.gpbDadosAluno.Controls.Add(this.lblNomeAluno);
            this.gpbDadosAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbDadosAluno.Location = new System.Drawing.Point(23, 71);
            this.gpbDadosAluno.Name = "gpbDadosAluno";
            this.gpbDadosAluno.Size = new System.Drawing.Size(518, 101);
            this.gpbDadosAluno.TabIndex = 0;
            this.gpbDadosAluno.TabStop = false;
            this.gpbDadosAluno.Text = "Dados do Aluno";
            // 
            // cmbNomeAluno
            // 
            this.cmbNomeAluno.FormattingEnabled = true;
            this.cmbNomeAluno.ItemHeight = 23;
            this.cmbNomeAluno.Location = new System.Drawing.Point(6, 53);
            this.cmbNomeAluno.Name = "cmbNomeAluno";
            this.cmbNomeAluno.Size = new System.Drawing.Size(270, 29);
            this.cmbNomeAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbNomeAluno.TabIndex = 2;
            this.cmbNomeAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbNomeAluno, "Exemplo : \"João da Silva\"");
            this.cmbNomeAluno.UseSelectable = true;
            this.cmbNomeAluno.SelectedIndexChanged += new System.EventHandler(this.cmbNomeAluno_SelectedIndexChanged);
            // 
            // txtProntuarioAluno
            // 
            // 
            // 
            // 
            this.txtProntuarioAluno.CustomButton.Image = null;
            this.txtProntuarioAluno.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtProntuarioAluno.CustomButton.Name = "";
            this.txtProntuarioAluno.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProntuarioAluno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProntuarioAluno.CustomButton.TabIndex = 1;
            this.txtProntuarioAluno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProntuarioAluno.CustomButton.UseSelectable = true;
            this.txtProntuarioAluno.CustomButton.Visible = false;
            this.txtProntuarioAluno.Enabled = false;
            this.txtProntuarioAluno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProntuarioAluno.Lines = new string[0];
            this.txtProntuarioAluno.Location = new System.Drawing.Point(407, 57);
            this.txtProntuarioAluno.MaxLength = 7;
            this.txtProntuarioAluno.Name = "txtProntuarioAluno";
            this.txtProntuarioAluno.PasswordChar = '\0';
            this.txtProntuarioAluno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProntuarioAluno.SelectedText = "";
            this.txtProntuarioAluno.SelectionLength = 0;
            this.txtProntuarioAluno.SelectionStart = 0;
            this.txtProntuarioAluno.Size = new System.Drawing.Size(105, 25);
            this.txtProntuarioAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtProntuarioAluno.TabIndex = 3;
            this.txtProntuarioAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtProntuarioAluno, "Exemplo : \"1542259\"");
            this.txtProntuarioAluno.UseSelectable = true;
            this.txtProntuarioAluno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProntuarioAluno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProntuarioAluno
            // 
            this.lblProntuarioAluno.AutoSize = true;
            this.lblProntuarioAluno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProntuarioAluno.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProntuarioAluno.Location = new System.Drawing.Point(406, 25);
            this.lblProntuarioAluno.Name = "lblProntuarioAluno";
            this.lblProntuarioAluno.Size = new System.Drawing.Size(99, 25);
            this.lblProntuarioAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblProntuarioAluno.TabIndex = 0;
            this.lblProntuarioAluno.Text = "Prontuário*";
            this.lblProntuarioAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProntuarioAluno.UseCustomForeColor = true;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeAluno.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeAluno.Location = new System.Drawing.Point(6, 25);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(66, 25);
            this.lblNomeAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome*";
            this.lblNomeAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeAluno.UseCustomForeColor = true;
            // 
            // gpbAgendar
            // 
            this.gpbAgendar.BackColor = System.Drawing.Color.Transparent;
            this.gpbAgendar.Controls.Add(this.cmbTurno);
            this.gpbAgendar.Controls.Add(this.cmbDiaSemana);
            this.gpbAgendar.Controls.Add(this.lblDados);
            this.gpbAgendar.Controls.Add(this.cmbProfissional);
            this.gpbAgendar.Controls.Add(this.lblProfissional);
            this.gpbAgendar.Controls.Add(this.cmbEncaminharCom);
            this.gpbAgendar.Controls.Add(this.lblEncaminhar);
            this.gpbAgendar.Controls.Add(this.lblTurno);
            this.gpbAgendar.Controls.Add(this.lblDemanda);
            this.gpbAgendar.Controls.Add(this.lblDiaSemana);
            this.gpbAgendar.Controls.Add(this.txtDemanda);
            this.gpbAgendar.Location = new System.Drawing.Point(23, 178);
            this.gpbAgendar.Name = "gpbAgendar";
            this.gpbAgendar.Size = new System.Drawing.Size(518, 452);
            this.gpbAgendar.TabIndex = 1;
            this.gpbAgendar.TabStop = false;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.ItemHeight = 23;
            this.cmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cmbTurno.Location = new System.Drawing.Point(314, 385);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(198, 29);
            this.cmbTurno.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbTurno.TabIndex = 8;
            this.cmbTurno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbTurno, "Exemplo : \"Noturno\"");
            this.cmbTurno.UseSelectable = true;
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.ItemHeight = 23;
            this.cmbDiaSemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira"});
            this.cmbDiaSemana.Location = new System.Drawing.Point(6, 385);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(177, 29);
            this.cmbDiaSemana.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbDiaSemana.TabIndex = 7;
            this.cmbDiaSemana.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbDiaSemana, "Exemplo : \"Segunda-Feira\"");
            this.cmbDiaSemana.UseSelectable = true;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDados.Location = new System.Drawing.Point(384, 430);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.Enabled = false;
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.ItemHeight = 23;
            this.cmbProfissional.Location = new System.Drawing.Point(314, 321);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(198, 29);
            this.cmbProfissional.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbProfissional.TabIndex = 6;
            this.cmbProfissional.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbProfissional, "Exemplo : \"Maria Ribeiro\"");
            this.cmbProfissional.UseSelectable = true;
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProfissional.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProfissional.Location = new System.Drawing.Point(314, 293);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(105, 25);
            this.lblProfissional.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblProfissional.TabIndex = 0;
            this.lblProfissional.Text = "Profissional*";
            this.lblProfissional.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProfissional.UseCustomForeColor = true;
            // 
            // cmbEncaminharCom
            // 
            this.cmbEncaminharCom.FormattingEnabled = true;
            this.cmbEncaminharCom.ItemHeight = 23;
            this.cmbEncaminharCom.Items.AddRange(new object[] {
            "Assistente Social",
            "Assistente Social/Coordenador(a)",
            "Assistente de Alunos",
            "Coordenador(a)"});
            this.cmbEncaminharCom.Location = new System.Drawing.Point(6, 321);
            this.cmbEncaminharCom.Name = "cmbEncaminharCom";
            this.cmbEncaminharCom.Size = new System.Drawing.Size(177, 29);
            this.cmbEncaminharCom.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbEncaminharCom.TabIndex = 5;
            this.cmbEncaminharCom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbEncaminharCom, "Exemplo : \"Professor\"");
            this.cmbEncaminharCom.UseSelectable = true;
            this.cmbEncaminharCom.SelectedIndexChanged += new System.EventHandler(this.cmbAgendarCom_SelectedIndexChanged);
            // 
            // lblEncaminhar
            // 
            this.lblEncaminhar.AutoSize = true;
            this.lblEncaminhar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEncaminhar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEncaminhar.Location = new System.Drawing.Point(6, 293);
            this.lblEncaminhar.Name = "lblEncaminhar";
            this.lblEncaminhar.Size = new System.Drawing.Size(150, 25);
            this.lblEncaminhar.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblEncaminhar.TabIndex = 0;
            this.lblEncaminhar.Text = "Encaminhar Com*";
            this.lblEncaminhar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEncaminhar.UseCustomForeColor = true;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTurno.Location = new System.Drawing.Point(314, 357);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(57, 25);
            this.lblTurno.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            this.lblTurno.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblDemanda
            // 
            this.lblDemanda.AutoSize = true;
            this.lblDemanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDemanda.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDemanda.Location = new System.Drawing.Point(6, 16);
            this.lblDemanda.Name = "lblDemanda";
            this.lblDemanda.Size = new System.Drawing.Size(93, 25);
            this.lblDemanda.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDemanda.TabIndex = 0;
            this.lblDemanda.Text = "Demanda*";
            this.lblDemanda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDemanda.UseCustomForeColor = true;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDiaSemana.Location = new System.Drawing.Point(6, 357);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(132, 25);
            this.lblDiaSemana.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDiaSemana.TabIndex = 0;
            this.lblDiaSemana.Text = "Dia da Semana ";
            this.lblDiaSemana.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtDemanda
            // 
            // 
            // 
            // 
            this.txtDemanda.CustomButton.Image = null;
            this.txtDemanda.CustomButton.Location = new System.Drawing.Point(262, 2);
            this.txtDemanda.CustomButton.Name = "";
            this.txtDemanda.CustomButton.Size = new System.Drawing.Size(241, 241);
            this.txtDemanda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDemanda.CustomButton.TabIndex = 1;
            this.txtDemanda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDemanda.CustomButton.UseSelectable = true;
            this.txtDemanda.CustomButton.Visible = false;
            this.txtDemanda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDemanda.Lines = new string[0];
            this.txtDemanda.Location = new System.Drawing.Point(6, 44);
            this.txtDemanda.MaxLength = 2147483647;
            this.txtDemanda.Multiline = true;
            this.txtDemanda.Name = "txtDemanda";
            this.txtDemanda.PasswordChar = '\0';
            this.txtDemanda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDemanda.SelectedText = "";
            this.txtDemanda.SelectionLength = 0;
            this.txtDemanda.SelectionStart = 0;
            this.txtDemanda.Size = new System.Drawing.Size(506, 246);
            this.txtDemanda.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDemanda.TabIndex = 4;
            this.txtDemanda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtDemanda, "Descreva a demanda do aluno");
            this.txtDemanda.UseSelectable = true;
            this.txtDemanda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDemanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRetornar
            // 
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.Location = new System.Drawing.Point(23, 636);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(96, 33);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnRetornar, "Cancela o encaminhamento");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Enabled = false;
            this.btnConcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConcluir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnConcluir.Highlight = true;
            this.btnConcluir.Location = new System.Drawing.Point(445, 636);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(96, 33);
            this.btnConcluir.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConcluir.TabIndex = 11;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnConcluir, "Conclui o encaminhamento");
            this.btnConcluir.UseSelectable = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrRelogio_Tick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimpar.Location = new System.Drawing.Point(237, 636);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 33);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Limpa os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmEncaminhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(567, 691);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.gpbDadosAluno);
            this.Controls.Add(this.gpbAgendar);
            this.MaximizeBox = false;
            this.Name = "frmEncaminhamento";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Encaminhar Atendimento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgendarAtendimento_FormClosing);
            this.Load += new System.EventHandler(this.frmAgendarAtendimento_Load);
            this.gpbDadosAluno.ResumeLayout(false);
            this.gpbDadosAluno.PerformLayout();
            this.gpbAgendar.ResumeLayout(false);
            this.gpbAgendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbAgendar;
        public System.Windows.Forms.GroupBox gpbDadosAluno;
        public MetroFramework.Controls.MetroComboBox cmbNomeAluno;
        public MetroFramework.Controls.MetroTextBox txtProntuarioAluno;
        public MetroFramework.Controls.MetroLabel lblProntuarioAluno;
        public MetroFramework.Controls.MetroLabel lblNomeAluno;
        public MetroFramework.Controls.MetroLabel lblDemanda;
        public MetroFramework.Controls.MetroComboBox cmbEncaminharCom;
        public MetroFramework.Controls.MetroLabel lblEncaminhar;
        public MetroFramework.Controls.MetroButton btnConcluir;
        public MetroFramework.Controls.MetroButton btnRetornar;
        private System.Windows.Forms.Timer tmrRelogio;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroComboBox cmbProfissional;
        public MetroFramework.Controls.MetroLabel lblProfissional;
        private MetroFramework.Components.MetroToolTip ttpDica;
        public MetroFramework.Controls.MetroTextBox txtDemanda;
        public MetroFramework.Controls.MetroLabel lblDados;
        public MetroFramework.Controls.MetroLabel lblDiaSemana;
        public MetroFramework.Controls.MetroComboBox cmbDiaSemana;
        public MetroFramework.Controls.MetroComboBox cmbTurno;
        public MetroFramework.Controls.MetroLabel lblTurno;
    }
}