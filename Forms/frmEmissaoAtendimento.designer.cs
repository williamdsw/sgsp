namespace SGSP___Desktop
{
    partial class frmEmissaoAtendimento
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
            this.gpbAluno = new System.Windows.Forms.GroupBox();
            this.cmbAluno = new MetroFramework.Controls.MetroComboBox();
            this.txtProntuarioAluno = new MetroFramework.Controls.MetroTextBox();
            this.lblProntuarioAluno = new MetroFramework.Controls.MetroLabel();
            this.lblNomeAluno = new MetroFramework.Controls.MetroLabel();
            this.lblCodAtendimento = new MetroFramework.Controls.MetroLabel();
            this.txtCodAtendimento = new MetroFramework.Controls.MetroTextBox();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.tbcAbas = new MetroFramework.Controls.MetroTabControl();
            this.tabDados = new MetroFramework.Controls.MetroTabPage();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.lblRequerente = new MetroFramework.Controls.MetroLabel();
            this.rbtVontadePropria = new MetroFramework.Controls.MetroRadioButton();
            this.rbtOutros = new MetroFramework.Controls.MetroRadioButton();
            this.gpbCodAtendimento = new System.Windows.Forms.GroupBox();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.gpbRequerente = new System.Windows.Forms.GroupBox();
            this.txtRequerente = new MetroFramework.Controls.MetroTextBox();
            this.lblNomeRequerente = new MetroFramework.Controls.MetroLabel();
            this.tabRelato = new MetroFramework.Controls.MetroTabPage();
            this.gpbRelato = new System.Windows.Forms.GroupBox();
            this.lblRelato = new MetroFramework.Controls.MetroLabel();
            this.txtRelato = new MetroFramework.Controls.MetroTextBox();
            this.tabProvidencias = new MetroFramework.Controls.MetroTabPage();
            this.gpbProvidencias = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new MetroFramework.Controls.MetroComboBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnConcluir = new MetroFramework.Controls.MetroButton();
            this.lblProvidencias = new MetroFramework.Controls.MetroLabel();
            this.txtProvidencias = new MetroFramework.Controls.MetroTextBox();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbAluno.SuspendLayout();
            this.tbcAbas.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            this.gpbCodAtendimento.SuspendLayout();
            this.gpbRequerente.SuspendLayout();
            this.tabRelato.SuspendLayout();
            this.gpbRelato.SuspendLayout();
            this.tabProvidencias.SuspendLayout();
            this.gpbProvidencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAluno
            // 
            this.gpbAluno.BackColor = System.Drawing.Color.Transparent;
            this.gpbAluno.Controls.Add(this.cmbAluno);
            this.gpbAluno.Controls.Add(this.txtProntuarioAluno);
            this.gpbAluno.Controls.Add(this.lblProntuarioAluno);
            this.gpbAluno.Controls.Add(this.lblNomeAluno);
            this.gpbAluno.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbAluno.Location = new System.Drawing.Point(3, 3);
            this.gpbAluno.Name = "gpbAluno";
            this.gpbAluno.Size = new System.Drawing.Size(492, 120);
            this.gpbAluno.TabIndex = 2;
            this.gpbAluno.TabStop = false;
            this.gpbAluno.Text = "Aluno";
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.ItemHeight = 23;
            this.cmbAluno.Items.AddRange(new object[] {
            ""});
            this.cmbAluno.Location = new System.Drawing.Point(5, 70);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(270, 29);
            this.cmbAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbAluno.TabIndex = 5;
            this.cmbAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbAluno, "Exemplo : \"João da Silva\"");
            this.cmbAluno.UseSelectable = true;
            this.cmbAluno.SelectedIndexChanged += new System.EventHandler(this.cmbAluno_SelectedIndexChanged);
            // 
            // txtProntuarioAluno
            // 
            // 
            // 
            // 
            this.txtProntuarioAluno.CustomButton.Image = null;
            this.txtProntuarioAluno.CustomButton.Location = new System.Drawing.Point(112, 1);
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
            this.txtProntuarioAluno.Location = new System.Drawing.Point(350, 74);
            this.txtProntuarioAluno.MaxLength = 32767;
            this.txtProntuarioAluno.Name = "txtProntuarioAluno";
            this.txtProntuarioAluno.PasswordChar = '\0';
            this.txtProntuarioAluno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProntuarioAluno.SelectedText = "";
            this.txtProntuarioAluno.SelectionLength = 0;
            this.txtProntuarioAluno.SelectionStart = 0;
            this.txtProntuarioAluno.Size = new System.Drawing.Size(136, 25);
            this.txtProntuarioAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtProntuarioAluno.TabIndex = 7;
            this.txtProntuarioAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtProntuarioAluno, "Exemplo : \"1545578\"");
            this.txtProntuarioAluno.UseSelectable = true;
            this.txtProntuarioAluno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProntuarioAluno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProntuarioAluno
            // 
            this.lblProntuarioAluno.AutoSize = true;
            this.lblProntuarioAluno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProntuarioAluno.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProntuarioAluno.Location = new System.Drawing.Point(350, 38);
            this.lblProntuarioAluno.Name = "lblProntuarioAluno";
            this.lblProntuarioAluno.Size = new System.Drawing.Size(99, 25);
            this.lblProntuarioAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblProntuarioAluno.TabIndex = 6;
            this.lblProntuarioAluno.Text = "Prontuário*";
            this.lblProntuarioAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProntuarioAluno.UseCustomForeColor = true;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeAluno.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeAluno.Location = new System.Drawing.Point(5, 38);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(66, 25);
            this.lblNomeAluno.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeAluno.TabIndex = 4;
            this.lblNomeAluno.Text = "Nome*";
            this.lblNomeAluno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeAluno.UseCustomForeColor = true;
            // 
            // lblCodAtendimento
            // 
            this.lblCodAtendimento.AutoSize = true;
            this.lblCodAtendimento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCodAtendimento.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodAtendimento.Location = new System.Drawing.Point(5, 24);
            this.lblCodAtendimento.Name = "lblCodAtendimento";
            this.lblCodAtendimento.Size = new System.Drawing.Size(207, 25);
            this.lblCodAtendimento.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblCodAtendimento.TabIndex = 9;
            this.lblCodAtendimento.Text = "Código do Atendimento* ";
            this.lblCodAtendimento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCodAtendimento.UseCustomForeColor = true;
            // 
            // txtCodAtendimento
            // 
            // 
            // 
            // 
            this.txtCodAtendimento.CustomButton.Image = null;
            this.txtCodAtendimento.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.txtCodAtendimento.CustomButton.Name = "";
            this.txtCodAtendimento.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCodAtendimento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodAtendimento.CustomButton.TabIndex = 1;
            this.txtCodAtendimento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodAtendimento.CustomButton.UseSelectable = true;
            this.txtCodAtendimento.CustomButton.Visible = false;
            this.txtCodAtendimento.Enabled = false;
            this.txtCodAtendimento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodAtendimento.Lines = new string[0];
            this.txtCodAtendimento.Location = new System.Drawing.Point(218, 24);
            this.txtCodAtendimento.MaxLength = 32767;
            this.txtCodAtendimento.Name = "txtCodAtendimento";
            this.txtCodAtendimento.PasswordChar = '\0';
            this.txtCodAtendimento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodAtendimento.SelectedText = "";
            this.txtCodAtendimento.SelectionLength = 0;
            this.txtCodAtendimento.SelectionStart = 0;
            this.txtCodAtendimento.Size = new System.Drawing.Size(268, 25);
            this.txtCodAtendimento.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtCodAtendimento.TabIndex = 10;
            this.txtCodAtendimento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodAtendimento.UseSelectable = true;
            this.txtCodAtendimento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodAtendimento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRetornar
            // 
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.Location = new System.Drawing.Point(4, 447);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(96, 33);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRetornar.TabIndex = 18;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnRetornar, "Clique para cancelar a emissão");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimpar.Location = new System.Drawing.Point(399, 447);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 33);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Clique para limpar os dados");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbcAbas
            // 
            this.tbcAbas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcAbas.Controls.Add(this.tabDados);
            this.tbcAbas.Controls.Add(this.tabRelato);
            this.tbcAbas.Controls.Add(this.tabProvidencias);
            this.tbcAbas.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbcAbas.Location = new System.Drawing.Point(23, 75);
            this.tbcAbas.Name = "tbcAbas";
            this.tbcAbas.SelectedIndex = 0;
            this.tbcAbas.Size = new System.Drawing.Size(507, 534);
            this.tbcAbas.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbcAbas.TabIndex = 1;
            this.tbcAbas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbcAbas.UseSelectable = true;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.gpbTipo);
            this.tabDados.Controls.Add(this.gpbCodAtendimento);
            this.tabDados.Controls.Add(this.lblDados);
            this.tabDados.Controls.Add(this.gpbRequerente);
            this.tabDados.Controls.Add(this.btnRetornar);
            this.tabDados.Controls.Add(this.btnLimpar);
            this.tabDados.Controls.Add(this.gpbAluno);
            this.tabDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDados.HorizontalScrollbarBarColor = true;
            this.tabDados.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDados.HorizontalScrollbarSize = 10;
            this.tabDados.Location = new System.Drawing.Point(4, 47);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(499, 483);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados";
            this.tabDados.VerticalScrollbarBarColor = true;
            this.tabDados.VerticalScrollbarHighlightOnWheel = false;
            this.tabDados.VerticalScrollbarSize = 10;
            // 
            // gpbTipo
            // 
            this.gpbTipo.BackColor = System.Drawing.Color.Transparent;
            this.gpbTipo.Controls.Add(this.lblRequerente);
            this.gpbTipo.Controls.Add(this.rbtVontadePropria);
            this.gpbTipo.Controls.Add(this.rbtOutros);
            this.gpbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipo.Location = new System.Drawing.Point(3, 201);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(492, 66);
            this.gpbTipo.TabIndex = 11;
            this.gpbTipo.TabStop = false;
            // 
            // lblRequerente
            // 
            this.lblRequerente.AutoSize = true;
            this.lblRequerente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRequerente.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRequerente.Location = new System.Drawing.Point(7, 24);
            this.lblRequerente.Name = "lblRequerente";
            this.lblRequerente.Size = new System.Drawing.Size(106, 25);
            this.lblRequerente.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblRequerente.TabIndex = 12;
            this.lblRequerente.Text = "Requerente*";
            this.lblRequerente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblRequerente.UseCustomForeColor = true;
            // 
            // rbtVontadePropria
            // 
            this.rbtVontadePropria.AutoSize = true;
            this.rbtVontadePropria.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbtVontadePropria.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbtVontadePropria.Location = new System.Drawing.Point(126, 24);
            this.rbtVontadePropria.Name = "rbtVontadePropria";
            this.rbtVontadePropria.Size = new System.Drawing.Size(152, 25);
            this.rbtVontadePropria.Style = MetroFramework.MetroColorStyle.Lime;
            this.rbtVontadePropria.TabIndex = 13;
            this.rbtVontadePropria.Text = "Vontade própria";
            this.rbtVontadePropria.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.rbtVontadePropria, "É por vontade própria do aluno");
            this.rbtVontadePropria.UseSelectable = true;
            this.rbtVontadePropria.CheckedChanged += new System.EventHandler(this.rbtVontadePropria_CheckedChanged);
            // 
            // rbtOutros
            // 
            this.rbtOutros.AutoSize = true;
            this.rbtOutros.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbtOutros.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbtOutros.Location = new System.Drawing.Point(317, 24);
            this.rbtOutros.Name = "rbtOutros";
            this.rbtOutros.Size = new System.Drawing.Size(80, 25);
            this.rbtOutros.Style = MetroFramework.MetroColorStyle.Lime;
            this.rbtOutros.TabIndex = 14;
            this.rbtOutros.Text = "Outros";
            this.rbtOutros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.rbtOutros, "É outro requerente, podendo ser funcionário ou familiar");
            this.rbtOutros.UseSelectable = true;
            this.rbtOutros.CheckedChanged += new System.EventHandler(this.rbtOutros_CheckedChanged);
            // 
            // gpbCodAtendimento
            // 
            this.gpbCodAtendimento.BackColor = System.Drawing.Color.Transparent;
            this.gpbCodAtendimento.Controls.Add(this.lblCodAtendimento);
            this.gpbCodAtendimento.Controls.Add(this.txtCodAtendimento);
            this.gpbCodAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCodAtendimento.Location = new System.Drawing.Point(3, 129);
            this.gpbCodAtendimento.Name = "gpbCodAtendimento";
            this.gpbCodAtendimento.Size = new System.Drawing.Size(492, 66);
            this.gpbCodAtendimento.TabIndex = 8;
            this.gpbCodAtendimento.TabStop = false;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDados.Location = new System.Drawing.Point(3, 407);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 17;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // gpbRequerente
            // 
            this.gpbRequerente.BackColor = System.Drawing.Color.Transparent;
            this.gpbRequerente.Controls.Add(this.txtRequerente);
            this.gpbRequerente.Controls.Add(this.lblNomeRequerente);
            this.gpbRequerente.Enabled = false;
            this.gpbRequerente.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbRequerente.Location = new System.Drawing.Point(4, 276);
            this.gpbRequerente.Name = "gpbRequerente";
            this.gpbRequerente.Size = new System.Drawing.Size(492, 119);
            this.gpbRequerente.TabIndex = 15;
            this.gpbRequerente.TabStop = false;
            this.gpbRequerente.Text = "Requerente";
            // 
            // txtRequerente
            // 
            // 
            // 
            // 
            this.txtRequerente.CustomButton.Image = null;
            this.txtRequerente.CustomButton.Location = new System.Drawing.Point(455, 1);
            this.txtRequerente.CustomButton.Name = "";
            this.txtRequerente.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRequerente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRequerente.CustomButton.TabIndex = 1;
            this.txtRequerente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRequerente.CustomButton.UseSelectable = true;
            this.txtRequerente.CustomButton.Visible = false;
            this.txtRequerente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRequerente.Lines = new string[0];
            this.txtRequerente.Location = new System.Drawing.Point(6, 69);
            this.txtRequerente.MaxLength = 32767;
            this.txtRequerente.Name = "txtRequerente";
            this.txtRequerente.PasswordChar = '\0';
            this.txtRequerente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRequerente.SelectedText = "";
            this.txtRequerente.SelectionLength = 0;
            this.txtRequerente.SelectionStart = 0;
            this.txtRequerente.Size = new System.Drawing.Size(479, 25);
            this.txtRequerente.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtRequerente.TabIndex = 16;
            this.txtRequerente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRequerente.UseSelectable = true;
            this.txtRequerente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRequerente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomeRequerente
            // 
            this.lblNomeRequerente.AutoSize = true;
            this.lblNomeRequerente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeRequerente.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeRequerente.Location = new System.Drawing.Point(5, 41);
            this.lblNomeRequerente.Name = "lblNomeRequerente";
            this.lblNomeRequerente.Size = new System.Drawing.Size(66, 25);
            this.lblNomeRequerente.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeRequerente.TabIndex = 17;
            this.lblNomeRequerente.Text = "Nome*";
            this.lblNomeRequerente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeRequerente.UseCustomForeColor = true;
            // 
            // tabRelato
            // 
            this.tabRelato.Controls.Add(this.gpbRelato);
            this.tabRelato.HorizontalScrollbarBarColor = true;
            this.tabRelato.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRelato.HorizontalScrollbarSize = 10;
            this.tabRelato.Location = new System.Drawing.Point(4, 47);
            this.tabRelato.Name = "tabRelato";
            this.tabRelato.Size = new System.Drawing.Size(499, 483);
            this.tabRelato.TabIndex = 2;
            this.tabRelato.Text = "Relato";
            this.tabRelato.VerticalScrollbarBarColor = true;
            this.tabRelato.VerticalScrollbarHighlightOnWheel = false;
            this.tabRelato.VerticalScrollbarSize = 10;
            // 
            // gpbRelato
            // 
            this.gpbRelato.BackColor = System.Drawing.Color.Transparent;
            this.gpbRelato.Controls.Add(this.lblRelato);
            this.gpbRelato.Controls.Add(this.txtRelato);
            this.gpbRelato.Location = new System.Drawing.Point(3, 3);
            this.gpbRelato.Name = "gpbRelato";
            this.gpbRelato.Size = new System.Drawing.Size(492, 477);
            this.gpbRelato.TabIndex = 20;
            this.gpbRelato.TabStop = false;
            // 
            // lblRelato
            // 
            this.lblRelato.AutoSize = true;
            this.lblRelato.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRelato.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRelato.Location = new System.Drawing.Point(6, 16);
            this.lblRelato.Name = "lblRelato";
            this.lblRelato.Size = new System.Drawing.Size(66, 25);
            this.lblRelato.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblRelato.TabIndex = 21;
            this.lblRelato.Text = "Relato*";
            this.lblRelato.UseCustomForeColor = true;
            // 
            // txtRelato
            // 
            // 
            // 
            // 
            this.txtRelato.CustomButton.Image = null;
            this.txtRelato.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.txtRelato.CustomButton.Name = "";
            this.txtRelato.CustomButton.Size = new System.Drawing.Size(395, 395);
            this.txtRelato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRelato.CustomButton.TabIndex = 1;
            this.txtRelato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRelato.CustomButton.UseSelectable = true;
            this.txtRelato.CustomButton.Visible = false;
            this.txtRelato.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRelato.Lines = new string[0];
            this.txtRelato.Location = new System.Drawing.Point(6, 44);
            this.txtRelato.MaxLength = 6000;
            this.txtRelato.Multiline = true;
            this.txtRelato.Name = "txtRelato";
            this.txtRelato.PasswordChar = '\0';
            this.txtRelato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRelato.SelectedText = "";
            this.txtRelato.SelectionLength = 0;
            this.txtRelato.SelectionStart = 0;
            this.txtRelato.Size = new System.Drawing.Size(480, 400);
            this.txtRelato.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtRelato.TabIndex = 22;
            this.txtRelato.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtRelato, "Descreva a demanda do aluno");
            this.txtRelato.UseSelectable = true;
            this.txtRelato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRelato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabProvidencias
            // 
            this.tabProvidencias.Controls.Add(this.gpbProvidencias);
            this.tabProvidencias.HorizontalScrollbarBarColor = true;
            this.tabProvidencias.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProvidencias.HorizontalScrollbarSize = 10;
            this.tabProvidencias.Location = new System.Drawing.Point(4, 47);
            this.tabProvidencias.Name = "tabProvidencias";
            this.tabProvidencias.Size = new System.Drawing.Size(499, 483);
            this.tabProvidencias.TabIndex = 3;
            this.tabProvidencias.Text = "Providências";
            this.tabProvidencias.VerticalScrollbarBarColor = true;
            this.tabProvidencias.VerticalScrollbarHighlightOnWheel = false;
            this.tabProvidencias.VerticalScrollbarSize = 10;
            // 
            // gpbProvidencias
            // 
            this.gpbProvidencias.BackColor = System.Drawing.Color.Transparent;
            this.gpbProvidencias.Controls.Add(this.cmbStatus);
            this.gpbProvidencias.Controls.Add(this.lblStatus);
            this.gpbProvidencias.Controls.Add(this.btnConcluir);
            this.gpbProvidencias.Controls.Add(this.lblProvidencias);
            this.gpbProvidencias.Controls.Add(this.txtProvidencias);
            this.gpbProvidencias.Location = new System.Drawing.Point(3, 3);
            this.gpbProvidencias.Name = "gpbProvidencias";
            this.gpbProvidencias.Size = new System.Drawing.Size(492, 477);
            this.gpbProvidencias.TabIndex = 23;
            this.gpbProvidencias.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 23;
            this.cmbStatus.Items.AddRange(new object[] {
            "Iniciado",
            "Pendente",
            "Encerrado"});
            this.cmbStatus.Location = new System.Drawing.Point(6, 430);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(171, 29);
            this.cmbStatus.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbStatus.TabIndex = 26;
            this.cmbStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbStatus, "Exemplo : \"Iniciado\"");
            this.cmbStatus.UseSelectable = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(6, 402);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 25);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status*";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblStatus.UseCustomForeColor = true;
            // 
            // btnConcluir
            // 
            this.btnConcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConcluir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnConcluir.Highlight = true;
            this.btnConcluir.Location = new System.Drawing.Point(384, 430);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(96, 33);
            this.btnConcluir.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConcluir.TabIndex = 27;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnConcluir, "Clique para concluir a emissão do atendimento");
            this.btnConcluir.UseSelectable = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblProvidencias
            // 
            this.lblProvidencias.AutoSize = true;
            this.lblProvidencias.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProvidencias.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProvidencias.Location = new System.Drawing.Point(6, 16);
            this.lblProvidencias.Name = "lblProvidencias";
            this.lblProvidencias.Size = new System.Drawing.Size(114, 25);
            this.lblProvidencias.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblProvidencias.TabIndex = 24;
            this.lblProvidencias.Text = "Providências*";
            this.lblProvidencias.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProvidencias.UseCustomForeColor = true;
            // 
            // txtProvidencias
            // 
            // 
            // 
            // 
            this.txtProvidencias.CustomButton.Image = null;
            this.txtProvidencias.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtProvidencias.CustomButton.Name = "";
            this.txtProvidencias.CustomButton.Size = new System.Drawing.Size(343, 343);
            this.txtProvidencias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProvidencias.CustomButton.TabIndex = 1;
            this.txtProvidencias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProvidencias.CustomButton.UseSelectable = true;
            this.txtProvidencias.CustomButton.Visible = false;
            this.txtProvidencias.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProvidencias.Lines = new string[0];
            this.txtProvidencias.Location = new System.Drawing.Point(6, 44);
            this.txtProvidencias.MaxLength = 6000;
            this.txtProvidencias.Multiline = true;
            this.txtProvidencias.Name = "txtProvidencias";
            this.txtProvidencias.PasswordChar = '\0';
            this.txtProvidencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProvidencias.SelectedText = "";
            this.txtProvidencias.SelectionLength = 0;
            this.txtProvidencias.SelectionStart = 0;
            this.txtProvidencias.Size = new System.Drawing.Size(480, 345);
            this.txtProvidencias.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtProvidencias.TabIndex = 25;
            this.txtProvidencias.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtProvidencias, "Descreva a demanda do aluno");
            this.txtProvidencias.UseSelectable = true;
            this.txtProvidencias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProvidencias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrRelogio_Tick);
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmEmissaoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 620);
            this.Controls.Add(this.tbcAbas);
            this.MaximizeBox = false;
            this.Name = "frmEmissaoAtendimento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Emissão do Atendimento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmissaoAtendimento_FormClosing);
            this.Load += new System.EventHandler(this.frmEmissaoAtendimento_Load);
            this.gpbAluno.ResumeLayout(false);
            this.gpbAluno.PerformLayout();
            this.tbcAbas.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.gpbCodAtendimento.ResumeLayout(false);
            this.gpbCodAtendimento.PerformLayout();
            this.gpbRequerente.ResumeLayout(false);
            this.gpbRequerente.PerformLayout();
            this.tabRelato.ResumeLayout(false);
            this.gpbRelato.ResumeLayout(false);
            this.gpbRelato.PerformLayout();
            this.tabProvidencias.ResumeLayout(false);
            this.gpbProvidencias.ResumeLayout(false);
            this.gpbProvidencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbAluno;
        public MetroFramework.Controls.MetroLabel lblNomeAluno;
        public MetroFramework.Controls.MetroTabControl tbcAbas;
        public MetroFramework.Controls.MetroTabPage tabDados;
        public MetroFramework.Controls.MetroTextBox txtProntuarioAluno;
        public MetroFramework.Controls.MetroLabel lblProntuarioAluno;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroComboBox cmbAluno;
        public System.Windows.Forms.GroupBox gpbRequerente;
        public MetroFramework.Controls.MetroLabel lblNomeRequerente;
        public MetroFramework.Controls.MetroLabel lblDados;
        public MetroFramework.Controls.MetroTabPage tabRelato;
        public System.Windows.Forms.GroupBox gpbRelato;
        public MetroFramework.Controls.MetroLabel lblRelato;
        public MetroFramework.Controls.MetroTabPage tabProvidencias;
        public System.Windows.Forms.GroupBox gpbProvidencias;
        public MetroFramework.Controls.MetroComboBox cmbStatus;
        public MetroFramework.Controls.MetroLabel lblStatus;
        public MetroFramework.Controls.MetroButton btnConcluir;
        public MetroFramework.Controls.MetroLabel lblProvidencias;
        public MetroFramework.Controls.MetroLabel lblCodAtendimento;
        public MetroFramework.Controls.MetroTextBox txtCodAtendimento;
        public MetroFramework.Controls.MetroRadioButton rbtVontadePropria;
        public MetroFramework.Controls.MetroRadioButton rbtOutros;
        public MetroFramework.Controls.MetroLabel lblRequerente;
        public System.Windows.Forms.GroupBox gpbCodAtendimento;
        public System.Windows.Forms.GroupBox gpbTipo;
        public System.Windows.Forms.Timer tmrRelogio;
        private MetroFramework.Components.MetroToolTip ttpDica;
        public MetroFramework.Controls.MetroTextBox txtRelato;
        public MetroFramework.Controls.MetroTextBox txtProvidencias;
        public MetroFramework.Controls.MetroTextBox txtRequerente;

    }
}