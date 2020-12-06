namespace SGSP___Desktop
{
    partial class frmCadastrarOutros
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
            this.lblNomeModulo = new MetroFramework.Controls.MetroLabel();
            this.txtNomeModulo = new MetroFramework.Controls.MetroTextBox();
            this.lblPlataforma = new MetroFramework.Controls.MetroLabel();
            this.cmbPlataforma = new MetroFramework.Controls.MetroComboBox();
            this.btnCadastrarModulo = new MetroFramework.Controls.MetroButton();
            this.gpbModulo = new System.Windows.Forms.GroupBox();
            this.gpbCurso = new System.Windows.Forms.GroupBox();
            this.btnCadastrarCurso = new MetroFramework.Controls.MetroButton();
            this.lblNivel = new MetroFramework.Controls.MetroLabel();
            this.txtNivel = new MetroFramework.Controls.MetroTextBox();
            this.lblNomeCurso = new MetroFramework.Controls.MetroLabel();
            this.txtNomeCurso = new MetroFramework.Controls.MetroTextBox();
            this.cmbPeriodo = new MetroFramework.Controls.MetroComboBox();
            this.lblPeriodo = new MetroFramework.Controls.MetroLabel();
            this.lblNumeroAlunos = new MetroFramework.Controls.MetroLabel();
            this.txtTempoDuracao = new MetroFramework.Controls.MetroTextBox();
            this.lblTempoDuracao = new MetroFramework.Controls.MetroLabel();
            this.txtSemestre = new MetroFramework.Controls.MetroTextBox();
            this.lblSemestre = new MetroFramework.Controls.MetroLabel();
            this.cmbCurso = new MetroFramework.Controls.MetroComboBox();
            this.txtAnoInicio = new MetroFramework.Controls.MetroTextBox();
            this.btnCadastrarTurma = new MetroFramework.Controls.MetroButton();
            this.lblAnoInicio = new MetroFramework.Controls.MetroLabel();
            this.gpbTurma = new System.Windows.Forms.GroupBox();
            this.lblCurso = new MetroFramework.Controls.MetroLabel();
            this.txtNumeroAlunos = new MetroFramework.Controls.MetroTextBox();
            this.lblNomeTurma = new MetroFramework.Controls.MetroLabel();
            this.txtNomeTurma = new MetroFramework.Controls.MetroTextBox();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.ctmMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tspModulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.tspTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbModulo.SuspendLayout();
            this.gpbCurso.SuspendLayout();
            this.gpbTurma.SuspendLayout();
            this.ctmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeModulo
            // 
            this.lblNomeModulo.AutoSize = true;
            this.lblNomeModulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeModulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeModulo.Location = new System.Drawing.Point(6, 35);
            this.lblNomeModulo.Name = "lblNomeModulo";
            this.lblNomeModulo.Size = new System.Drawing.Size(66, 25);
            this.lblNomeModulo.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeModulo.TabIndex = 3;
            this.lblNomeModulo.Text = "Nome*";
            this.lblNomeModulo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeModulo.UseCustomForeColor = true;
            // 
            // txtNomeModulo
            // 
            // 
            // 
            // 
            this.txtNomeModulo.CustomButton.Image = null;
            this.txtNomeModulo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNomeModulo.CustomButton.Name = "";
            this.txtNomeModulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeModulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeModulo.CustomButton.TabIndex = 1;
            this.txtNomeModulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeModulo.CustomButton.UseSelectable = true;
            this.txtNomeModulo.CustomButton.Visible = false;
            this.txtNomeModulo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeModulo.Lines = new string[0];
            this.txtNomeModulo.Location = new System.Drawing.Point(124, 37);
            this.txtNomeModulo.MaxLength = 50;
            this.txtNomeModulo.Name = "txtNomeModulo";
            this.txtNomeModulo.PasswordChar = '\0';
            this.txtNomeModulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeModulo.SelectedText = "";
            this.txtNomeModulo.SelectionLength = 0;
            this.txtNomeModulo.SelectionStart = 0;
            this.txtNomeModulo.Size = new System.Drawing.Size(200, 23);
            this.txtNomeModulo.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNomeModulo.TabIndex = 4;
            this.txtNomeModulo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNomeModulo, "Exemplo : \"Tela Principal\"");
            this.txtNomeModulo.UseSelectable = true;
            this.txtNomeModulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeModulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPlataforma.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPlataforma.Location = new System.Drawing.Point(6, 85);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(101, 25);
            this.lblPlataforma.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblPlataforma.TabIndex = 7;
            this.lblPlataforma.Text = "Plataforma*";
            this.lblPlataforma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPlataforma.UseCustomForeColor = true;
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPlataforma.FormattingEnabled = true;
            this.cmbPlataforma.ItemHeight = 23;
            this.cmbPlataforma.Items.AddRange(new object[] {
            "Desktop",
            "Mobile",
            "Web"});
            this.cmbPlataforma.Location = new System.Drawing.Point(124, 83);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(200, 29);
            this.cmbPlataforma.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbPlataforma.TabIndex = 8;
            this.cmbPlataforma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbPlataforma, "Exemplo : \"Desktop\"");
            this.cmbPlataforma.UseSelectable = true;
            // 
            // btnCadastrarModulo
            // 
            this.btnCadastrarModulo.BackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarModulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarModulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarModulo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrarModulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarModulo.Highlight = true;
            this.btnCadastrarModulo.Location = new System.Drawing.Point(174, 132);
            this.btnCadastrarModulo.Name = "btnCadastrarModulo";
            this.btnCadastrarModulo.Size = new System.Drawing.Size(150, 30);
            this.btnCadastrarModulo.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCadastrarModulo.TabIndex = 9;
            this.btnCadastrarModulo.Text = "Cadastrar módulo";
            this.btnCadastrarModulo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCadastrarModulo, "Conclui o cadastramento do módulo");
            this.btnCadastrarModulo.UseSelectable = true;
            this.btnCadastrarModulo.Click += new System.EventHandler(this.btnCadastrarModulo_Click);
            // 
            // gpbModulo
            // 
            this.gpbModulo.Controls.Add(this.lblNomeModulo);
            this.gpbModulo.Controls.Add(this.txtNomeModulo);
            this.gpbModulo.Controls.Add(this.btnCadastrarModulo);
            this.gpbModulo.Controls.Add(this.cmbPlataforma);
            this.gpbModulo.Controls.Add(this.lblPlataforma);
            this.gpbModulo.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbModulo.Location = new System.Drawing.Point(23, 63);
            this.gpbModulo.Name = "gpbModulo";
            this.gpbModulo.Size = new System.Drawing.Size(340, 170);
            this.gpbModulo.TabIndex = 1;
            this.gpbModulo.TabStop = false;
            this.gpbModulo.Text = "Cadastrar Módulo";
            // 
            // gpbCurso
            // 
            this.gpbCurso.BackColor = System.Drawing.Color.Transparent;
            this.gpbCurso.Controls.Add(this.btnCadastrarCurso);
            this.gpbCurso.Controls.Add(this.lblNivel);
            this.gpbCurso.Controls.Add(this.txtNivel);
            this.gpbCurso.Controls.Add(this.lblNomeCurso);
            this.gpbCurso.Controls.Add(this.txtNomeCurso);
            this.gpbCurso.Controls.Add(this.cmbPeriodo);
            this.gpbCurso.Controls.Add(this.lblPeriodo);
            this.gpbCurso.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbCurso.Location = new System.Drawing.Point(23, 239);
            this.gpbCurso.Name = "gpbCurso";
            this.gpbCurso.Size = new System.Drawing.Size(340, 165);
            this.gpbCurso.TabIndex = 10;
            this.gpbCurso.TabStop = false;
            this.gpbCurso.Text = "Cadastrar Curso";
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.BackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCurso.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrarCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarCurso.Highlight = true;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(174, 130);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(150, 30);
            this.btnCadastrarCurso.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCadastrarCurso.TabIndex = 18;
            this.btnCadastrarCurso.Text = "Cadastrar curso";
            this.btnCadastrarCurso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCadastrarCurso, "Conclui o cadastramento do curso");
            this.btnCadastrarCurso.UseSelectable = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNivel.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNivel.Location = new System.Drawing.Point(6, 99);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(57, 25);
            this.lblNivel.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNivel.TabIndex = 16;
            this.lblNivel.Text = "Nível*";
            this.lblNivel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNivel.UseCustomForeColor = true;
            // 
            // txtNivel
            // 
            // 
            // 
            // 
            this.txtNivel.CustomButton.Image = null;
            this.txtNivel.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNivel.CustomButton.Name = "";
            this.txtNivel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNivel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNivel.CustomButton.TabIndex = 1;
            this.txtNivel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNivel.CustomButton.UseSelectable = true;
            this.txtNivel.CustomButton.Visible = false;
            this.txtNivel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNivel.Lines = new string[0];
            this.txtNivel.Location = new System.Drawing.Point(124, 101);
            this.txtNivel.MaxLength = 50;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.PasswordChar = '\0';
            this.txtNivel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNivel.SelectedText = "";
            this.txtNivel.SelectionLength = 0;
            this.txtNivel.SelectionStart = 0;
            this.txtNivel.Size = new System.Drawing.Size(200, 23);
            this.txtNivel.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNivel.TabIndex = 17;
            this.txtNivel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNivel, "Exemplo : \"Técnico\"");
            this.txtNivel.UseSelectable = true;
            this.txtNivel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNivel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeCurso.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeCurso.Location = new System.Drawing.Point(6, 35);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(66, 25);
            this.lblNomeCurso.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeCurso.TabIndex = 12;
            this.lblNomeCurso.Text = "Nome*";
            this.lblNomeCurso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeCurso.UseCustomForeColor = true;
            // 
            // txtNomeCurso
            // 
            // 
            // 
            // 
            this.txtNomeCurso.CustomButton.Image = null;
            this.txtNomeCurso.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNomeCurso.CustomButton.Name = "";
            this.txtNomeCurso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeCurso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeCurso.CustomButton.TabIndex = 1;
            this.txtNomeCurso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeCurso.CustomButton.UseSelectable = true;
            this.txtNomeCurso.CustomButton.Visible = false;
            this.txtNomeCurso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeCurso.Lines = new string[0];
            this.txtNomeCurso.Location = new System.Drawing.Point(124, 37);
            this.txtNomeCurso.MaxLength = 50;
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.PasswordChar = '\0';
            this.txtNomeCurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCurso.SelectedText = "";
            this.txtNomeCurso.SelectionLength = 0;
            this.txtNomeCurso.SelectionStart = 0;
            this.txtNomeCurso.Size = new System.Drawing.Size(200, 23);
            this.txtNomeCurso.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNomeCurso.TabIndex = 13;
            this.txtNomeCurso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNomeCurso, "Exemplo : \"Técnico em Informática\"");
            this.txtNomeCurso.UseSelectable = true;
            this.txtNomeCurso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCurso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.ItemHeight = 23;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cmbPeriodo.Location = new System.Drawing.Point(124, 66);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(200, 29);
            this.cmbPeriodo.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbPeriodo.TabIndex = 15;
            this.cmbPeriodo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbPeriodo, "Exemplo : \"Noturno\"");
            this.cmbPeriodo.UseSelectable = true;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPeriodo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPeriodo.Location = new System.Drawing.Point(6, 70);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(78, 25);
            this.lblPeriodo.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "Período*";
            this.lblPeriodo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPeriodo.UseCustomForeColor = true;
            // 
            // lblNumeroAlunos
            // 
            this.lblNumeroAlunos.AutoSize = true;
            this.lblNumeroAlunos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumeroAlunos.Location = new System.Drawing.Point(6, 128);
            this.lblNumeroAlunos.Name = "lblNumeroAlunos";
            this.lblNumeroAlunos.Size = new System.Drawing.Size(111, 25);
            this.lblNumeroAlunos.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNumeroAlunos.TabIndex = 25;
            this.lblNumeroAlunos.Text = "Nº de alunos";
            this.lblNumeroAlunos.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtTempoDuracao
            // 
            // 
            // 
            // 
            this.txtTempoDuracao.CustomButton.Image = null;
            this.txtTempoDuracao.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtTempoDuracao.CustomButton.Name = "";
            this.txtTempoDuracao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTempoDuracao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTempoDuracao.CustomButton.TabIndex = 1;
            this.txtTempoDuracao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTempoDuracao.CustomButton.UseSelectable = true;
            this.txtTempoDuracao.CustomButton.Visible = false;
            this.txtTempoDuracao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTempoDuracao.Lines = new string[0];
            this.txtTempoDuracao.Location = new System.Drawing.Point(172, 248);
            this.txtTempoDuracao.MaxLength = 20;
            this.txtTempoDuracao.Name = "txtTempoDuracao";
            this.txtTempoDuracao.PasswordChar = '\0';
            this.txtTempoDuracao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempoDuracao.SelectedText = "";
            this.txtTempoDuracao.SelectionLength = 0;
            this.txtTempoDuracao.SelectionStart = 0;
            this.txtTempoDuracao.Size = new System.Drawing.Size(200, 23);
            this.txtTempoDuracao.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtTempoDuracao.TabIndex = 32;
            this.txtTempoDuracao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtTempoDuracao, "Exemplo : \"4 semestres\"");
            this.txtTempoDuracao.UseSelectable = true;
            this.txtTempoDuracao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTempoDuracao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTempoDuracao
            // 
            this.lblTempoDuracao.AutoSize = true;
            this.lblTempoDuracao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTempoDuracao.Location = new System.Drawing.Point(6, 246);
            this.lblTempoDuracao.Name = "lblTempoDuracao";
            this.lblTempoDuracao.Size = new System.Drawing.Size(156, 25);
            this.lblTempoDuracao.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblTempoDuracao.TabIndex = 31;
            this.lblTempoDuracao.Text = "Tempo de duração";
            this.lblTempoDuracao.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSemestre
            // 
            // 
            // 
            // 
            this.txtSemestre.CustomButton.Image = null;
            this.txtSemestre.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSemestre.CustomButton.Name = "";
            this.txtSemestre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSemestre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSemestre.CustomButton.TabIndex = 1;
            this.txtSemestre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSemestre.CustomButton.UseSelectable = true;
            this.txtSemestre.CustomButton.Visible = false;
            this.txtSemestre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSemestre.Lines = new string[0];
            this.txtSemestre.Location = new System.Drawing.Point(172, 211);
            this.txtSemestre.MaxLength = 1;
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.PasswordChar = '\0';
            this.txtSemestre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSemestre.SelectedText = "";
            this.txtSemestre.SelectionLength = 0;
            this.txtSemestre.SelectionStart = 0;
            this.txtSemestre.Size = new System.Drawing.Size(200, 23);
            this.txtSemestre.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSemestre.TabIndex = 30;
            this.txtSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtSemestre, "Exemplo : \"1\"");
            this.txtSemestre.UseSelectable = true;
            this.txtSemestre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSemestre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSemestre.Location = new System.Drawing.Point(6, 209);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(81, 25);
            this.lblSemestre.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblSemestre.TabIndex = 29;
            this.lblSemestre.Text = "Semestre";
            this.lblSemestre.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.ItemHeight = 23;
            this.cmbCurso.Location = new System.Drawing.Point(172, 83);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(200, 29);
            this.cmbCurso.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbCurso.TabIndex = 24;
            this.cmbCurso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbCurso, "Exemplo : \"Técnico em Informática\"");
            this.cmbCurso.UseSelectable = true;
            // 
            // txtAnoInicio
            // 
            // 
            // 
            // 
            this.txtAnoInicio.CustomButton.Image = null;
            this.txtAnoInicio.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAnoInicio.CustomButton.Name = "";
            this.txtAnoInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAnoInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnoInicio.CustomButton.TabIndex = 1;
            this.txtAnoInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnoInicio.CustomButton.UseSelectable = true;
            this.txtAnoInicio.CustomButton.Visible = false;
            this.txtAnoInicio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAnoInicio.Lines = new string[0];
            this.txtAnoInicio.Location = new System.Drawing.Point(172, 172);
            this.txtAnoInicio.MaxLength = 4;
            this.txtAnoInicio.Name = "txtAnoInicio";
            this.txtAnoInicio.PasswordChar = '\0';
            this.txtAnoInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnoInicio.SelectedText = "";
            this.txtAnoInicio.SelectionLength = 0;
            this.txtAnoInicio.SelectionStart = 0;
            this.txtAnoInicio.Size = new System.Drawing.Size(200, 23);
            this.txtAnoInicio.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAnoInicio.TabIndex = 28;
            this.txtAnoInicio.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtAnoInicio, "Exemplo : \"2015\"");
            this.txtAnoInicio.UseSelectable = true;
            this.txtAnoInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnoInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarTurma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarTurma.BackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarTurma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarTurma.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrarTurma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarTurma.Highlight = true;
            this.btnCadastrarTurma.Location = new System.Drawing.Point(222, 292);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(150, 30);
            this.btnCadastrarTurma.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCadastrarTurma.TabIndex = 33;
            this.btnCadastrarTurma.Text = "Cadastrar turma";
            this.btnCadastrarTurma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCadastrarTurma, "Conclui o cadastramento da turma");
            this.btnCadastrarTurma.UseSelectable = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // lblAnoInicio
            // 
            this.lblAnoInicio.AutoSize = true;
            this.lblAnoInicio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAnoInicio.Location = new System.Drawing.Point(6, 170);
            this.lblAnoInicio.Name = "lblAnoInicio";
            this.lblAnoInicio.Size = new System.Drawing.Size(112, 25);
            this.lblAnoInicio.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblAnoInicio.TabIndex = 27;
            this.lblAnoInicio.Text = "Ano de ínicio";
            this.lblAnoInicio.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // gpbTurma
            // 
            this.gpbTurma.Controls.Add(this.btnCadastrarTurma);
            this.gpbTurma.Controls.Add(this.txtTempoDuracao);
            this.gpbTurma.Controls.Add(this.lblTempoDuracao);
            this.gpbTurma.Controls.Add(this.lblNumeroAlunos);
            this.gpbTurma.Controls.Add(this.lblCurso);
            this.gpbTurma.Controls.Add(this.lblSemestre);
            this.gpbTurma.Controls.Add(this.txtSemestre);
            this.gpbTurma.Controls.Add(this.txtNumeroAlunos);
            this.gpbTurma.Controls.Add(this.txtAnoInicio);
            this.gpbTurma.Controls.Add(this.lblAnoInicio);
            this.gpbTurma.Controls.Add(this.cmbCurso);
            this.gpbTurma.Controls.Add(this.lblNomeTurma);
            this.gpbTurma.Controls.Add(this.txtNomeTurma);
            this.gpbTurma.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbTurma.Location = new System.Drawing.Point(369, 63);
            this.gpbTurma.Name = "gpbTurma";
            this.gpbTurma.Size = new System.Drawing.Size(385, 341);
            this.gpbTurma.TabIndex = 19;
            this.gpbTurma.TabStop = false;
            this.gpbTurma.Text = "Cadastrar Turma";
            this.ttpDica.SetToolTip(this.gpbTurma, "Conclui o cadastramento da turma");
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurso.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCurso.Location = new System.Drawing.Point(6, 83);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(63, 25);
            this.lblCurso.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblCurso.TabIndex = 23;
            this.lblCurso.Text = "Curso*";
            this.lblCurso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCurso.UseCustomForeColor = true;
            // 
            // txtNumeroAlunos
            // 
            // 
            // 
            // 
            this.txtNumeroAlunos.CustomButton.Image = null;
            this.txtNumeroAlunos.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNumeroAlunos.CustomButton.Name = "";
            this.txtNumeroAlunos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroAlunos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroAlunos.CustomButton.TabIndex = 1;
            this.txtNumeroAlunos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroAlunos.CustomButton.UseSelectable = true;
            this.txtNumeroAlunos.CustomButton.Visible = false;
            this.txtNumeroAlunos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNumeroAlunos.Lines = new string[0];
            this.txtNumeroAlunos.Location = new System.Drawing.Point(172, 130);
            this.txtNumeroAlunos.MaxLength = 50;
            this.txtNumeroAlunos.Name = "txtNumeroAlunos";
            this.txtNumeroAlunos.PasswordChar = '\0';
            this.txtNumeroAlunos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroAlunos.SelectedText = "";
            this.txtNumeroAlunos.SelectionLength = 0;
            this.txtNumeroAlunos.SelectionStart = 0;
            this.txtNumeroAlunos.Size = new System.Drawing.Size(200, 23);
            this.txtNumeroAlunos.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNumeroAlunos.TabIndex = 26;
            this.txtNumeroAlunos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNumeroAlunos, "Exemplo : \"40\"");
            this.txtNumeroAlunos.UseSelectable = true;
            this.txtNumeroAlunos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroAlunos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeTurma.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeTurma.Location = new System.Drawing.Point(6, 41);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(66, 25);
            this.lblNomeTurma.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNomeTurma.TabIndex = 21;
            this.lblNomeTurma.Text = "Nome*";
            this.lblNomeTurma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNomeTurma.UseCustomForeColor = true;
            // 
            // txtNomeTurma
            // 
            // 
            // 
            // 
            this.txtNomeTurma.CustomButton.Image = null;
            this.txtNomeTurma.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNomeTurma.CustomButton.Name = "";
            this.txtNomeTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeTurma.CustomButton.TabIndex = 1;
            this.txtNomeTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeTurma.CustomButton.UseSelectable = true;
            this.txtNomeTurma.CustomButton.Visible = false;
            this.txtNomeTurma.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeTurma.Lines = new string[0];
            this.txtNomeTurma.Location = new System.Drawing.Point(172, 43);
            this.txtNomeTurma.MaxLength = 50;
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.PasswordChar = '\0';
            this.txtNomeTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeTurma.SelectedText = "";
            this.txtNomeTurma.SelectionLength = 0;
            this.txtNomeTurma.SelectionStart = 0;
            this.txtNomeTurma.Size = new System.Drawing.Size(200, 23);
            this.txtNomeTurma.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNomeTurma.TabIndex = 22;
            this.txtNomeTurma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNomeTurma, "Exemplo : \"TEC INF 2015 SEM1\"");
            this.txtNomeTurma.UseSelectable = true;
            this.txtNomeTurma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeTurma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimpar.Location = new System.Drawing.Point(658, 429);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 33);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Limpa os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseUp);
            // 
            // ctmMenu
            // 
            this.ctmMenu.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.ctmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspModulo,
            this.tspCurso,
            this.tspTurma});
            this.ctmMenu.Name = "ctmMenu";
            this.ctmMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctmMenu.Size = new System.Drawing.Size(131, 76);
            this.ctmMenu.Style = MetroFramework.MetroColorStyle.Lime;
            this.ctmMenu.Text = "Limpar...";
            this.ctmMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tspModulo
            // 
            this.tspModulo.Name = "tspModulo";
            this.tspModulo.Size = new System.Drawing.Size(130, 24);
            this.tspModulo.Text = "Módulo";
            this.tspModulo.Click += new System.EventHandler(this.tspModulo_Click);
            // 
            // tspCurso
            // 
            this.tspCurso.Name = "tspCurso";
            this.tspCurso.Size = new System.Drawing.Size(130, 24);
            this.tspCurso.Text = "Curso";
            this.tspCurso.Click += new System.EventHandler(this.tspCurso_Click);
            // 
            // tspTurma
            // 
            this.tspTurma.Name = "tspTurma";
            this.tspTurma.Size = new System.Drawing.Size(130, 24);
            this.tspTurma.Text = "Turma";
            this.tspTurma.Click += new System.EventHandler(this.tspTurma_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDados.Location = new System.Drawing.Point(23, 407);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 34;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.LightGray;
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetornar.Location = new System.Drawing.Point(23, 429);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 30);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRetornar.TabIndex = 35;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnRetornar, "Cancela o cadastramento");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
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
            // frmCadastrarOutros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpbTurma);
            this.Controls.Add(this.gpbModulo);
            this.Controls.Add(this.gpbCurso);
            this.MaximizeBox = false;
            this.Name = "frmCadastrarOutros";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cadastrar outros itens...";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarOutros_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastrarOutros_Load);
            this.gpbModulo.ResumeLayout(false);
            this.gpbModulo.PerformLayout();
            this.gpbCurso.ResumeLayout(false);
            this.gpbCurso.PerformLayout();
            this.gpbTurma.ResumeLayout(false);
            this.gpbTurma.PerformLayout();
            this.ctmMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroComboBox cmbPlataforma;
        public MetroFramework.Controls.MetroComboBox cmbPeriodo;
        public MetroFramework.Controls.MetroComboBox cmbCurso;
        public MetroFramework.Controls.MetroLabel lblNomeModulo;
        public MetroFramework.Controls.MetroTextBox txtNomeModulo;
        public MetroFramework.Controls.MetroLabel lblPlataforma;
        public MetroFramework.Controls.MetroButton btnCadastrarModulo;
        public System.Windows.Forms.GroupBox gpbModulo;
        public System.Windows.Forms.GroupBox gpbCurso;
        public MetroFramework.Controls.MetroLabel lblNomeCurso;
        public MetroFramework.Controls.MetroTextBox txtNomeCurso;
        public MetroFramework.Controls.MetroLabel lblPeriodo;
        public MetroFramework.Controls.MetroTextBox txtAnoInicio;
        public MetroFramework.Controls.MetroButton btnCadastrarTurma;
        public MetroFramework.Controls.MetroLabel lblAnoInicio;
        public MetroFramework.Controls.MetroTextBox txtTempoDuracao;
        public MetroFramework.Controls.MetroLabel lblTempoDuracao;
        public MetroFramework.Controls.MetroTextBox txtSemestre;
        public MetroFramework.Controls.MetroLabel lblSemestre;
        public MetroFramework.Controls.MetroLabel lblNumeroAlunos;
        public MetroFramework.Controls.MetroButton btnCadastrarCurso;
        public System.Windows.Forms.GroupBox gpbTurma;
        public MetroFramework.Controls.MetroLabel lblCurso;
        public MetroFramework.Controls.MetroTextBox txtNumeroAlunos;
        public MetroFramework.Controls.MetroLabel lblNomeTurma;
        public MetroFramework.Controls.MetroTextBox txtNomeTurma;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroContextMenu ctmMenu;
        public System.Windows.Forms.ToolStripMenuItem tspModulo;
        public System.Windows.Forms.ToolStripMenuItem tspCurso;
        public System.Windows.Forms.ToolStripMenuItem tspTurma;
        public MetroFramework.Controls.MetroLabel lblDados;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroLabel lblNivel;
        public MetroFramework.Controls.MetroTextBox txtNivel;
        private System.Windows.Forms.Timer tmrRelogio;
        private MetroFramework.Components.MetroToolTip ttpDica;
    }
}