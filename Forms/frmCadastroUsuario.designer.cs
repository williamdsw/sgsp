namespace SGSP___Desktop
{
    partial class frmCadastroUsuario
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
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.lblForca = new MetroFramework.Controls.MetroLabel();
            this.txtProntuario = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmeSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblConSenha = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.lblProntuario = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.gpbOutros = new System.Windows.Forms.GroupBox();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.cmbPerfil = new MetroFramework.Controls.MetroComboBox();
            this.lblPerfil = new MetroFramework.Controls.MetroLabel();
            this.cmbStatus = new MetroFramework.Controls.MetroComboBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbLogin.SuspendLayout();
            this.gpbOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.lblForca);
            this.gpbLogin.Controls.Add(this.txtProntuario);
            this.gpbLogin.Controls.Add(this.txtConfirmeSenha);
            this.gpbLogin.Controls.Add(this.lblConSenha);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.lblProntuario);
            this.gpbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbLogin.Location = new System.Drawing.Point(23, 63);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(204, 246);
            this.gpbLogin.TabIndex = 1;
            this.gpbLogin.TabStop = false;
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.Location = new System.Drawing.Point(22, 224);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(42, 19);
            this.lblForca.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblForca.TabIndex = 14;
            this.lblForca.Text = "Força";
            this.lblForca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblForca.Visible = false;
            // 
            // txtProntuario
            // 
            // 
            // 
            // 
            this.txtProntuario.CustomButton.Image = null;
            this.txtProntuario.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtProntuario.CustomButton.Name = "";
            this.txtProntuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProntuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProntuario.CustomButton.TabIndex = 1;
            this.txtProntuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProntuario.CustomButton.UseSelectable = true;
            this.txtProntuario.CustomButton.Visible = false;
            this.txtProntuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProntuario.Lines = new string[0];
            this.txtProntuario.Location = new System.Drawing.Point(25, 50);
            this.txtProntuario.MaxLength = 6;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.PasswordChar = '\0';
            this.txtProntuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProntuario.SelectedText = "";
            this.txtProntuario.SelectionLength = 0;
            this.txtProntuario.SelectionStart = 0;
            this.txtProntuario.Size = new System.Drawing.Size(147, 23);
            this.txtProntuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtProntuario.TabIndex = 4;
            this.txtProntuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtProntuario, "Exemplo : \"154218\"");
            this.txtProntuario.UseSelectable = true;
            this.txtProntuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProntuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtConfirmeSenha.CustomButton.Image = null;
            this.txtConfirmeSenha.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtConfirmeSenha.CustomButton.Name = "";
            this.txtConfirmeSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmeSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmeSenha.CustomButton.TabIndex = 1;
            this.txtConfirmeSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmeSenha.CustomButton.UseSelectable = true;
            this.txtConfirmeSenha.CustomButton.Visible = false;
            this.txtConfirmeSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtConfirmeSenha.Lines = new string[0];
            this.txtConfirmeSenha.Location = new System.Drawing.Point(25, 185);
            this.txtConfirmeSenha.MaxLength = 20;
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.PasswordChar = '●';
            this.txtConfirmeSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmeSenha.SelectedText = "";
            this.txtConfirmeSenha.SelectionLength = 0;
            this.txtConfirmeSenha.SelectionStart = 0;
            this.txtConfirmeSenha.Size = new System.Drawing.Size(147, 23);
            this.txtConfirmeSenha.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtConfirmeSenha.TabIndex = 8;
            this.txtConfirmeSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtConfirmeSenha, "Confirme a senha escrita na caixa anterior");
            this.txtConfirmeSenha.UseSelectable = true;
            this.txtConfirmeSenha.UseSystemPasswordChar = true;
            this.txtConfirmeSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmeSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblConSenha
            // 
            this.lblConSenha.AutoSize = true;
            this.lblConSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblConSenha.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblConSenha.Location = new System.Drawing.Point(22, 155);
            this.lblConSenha.Name = "lblConSenha";
            this.lblConSenha.Size = new System.Drawing.Size(153, 25);
            this.lblConSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.lblConSenha.TabIndex = 7;
            this.lblConSenha.Text = "Confirme a senha*";
            this.lblConSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblConSenha.UseCustomForeColor = true;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(25, 115);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(147, 23);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtSenha, "A-Z, a-z, caracteres especiais, números, e no mínimo 8 caracteres");
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSenha.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSenha.Location = new System.Drawing.Point(22, 85);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 25);
            this.lblSenha.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha*";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSenha.UseCustomForeColor = true;
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProntuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProntuario.Location = new System.Drawing.Point(22, 22);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(99, 25);
            this.lblProntuario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblProntuario.TabIndex = 3;
            this.lblProntuario.Text = "Prontuário*";
            this.lblProntuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblProntuario.UseCustomForeColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(337, 327);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCadastrar, "Cliqu para finalizar o cadastro");
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbOutros
            // 
            this.gpbOutros.Controls.Add(this.lblDados);
            this.gpbOutros.Controls.Add(this.cmbPerfil);
            this.gpbOutros.Controls.Add(this.lblPerfil);
            this.gpbOutros.Controls.Add(this.cmbStatus);
            this.gpbOutros.Controls.Add(this.lblStatus);
            this.gpbOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbOutros.Location = new System.Drawing.Point(233, 63);
            this.gpbOutros.Name = "gpbOutros";
            this.gpbOutros.Size = new System.Drawing.Size(204, 246);
            this.gpbOutros.TabIndex = 2;
            this.gpbOutros.TabStop = false;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDados.Location = new System.Drawing.Point(6, 224);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 14;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.ItemHeight = 23;
            this.cmbPerfil.Location = new System.Drawing.Point(29, 155);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(147, 29);
            this.cmbPerfil.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbPerfil.TabIndex = 13;
            this.cmbPerfil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbPerfil, "Exemplo : \"Total\"");
            this.cmbPerfil.UseSelectable = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPerfil.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPerfil.Location = new System.Drawing.Point(26, 127);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(57, 25);
            this.lblPerfil.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPerfil.TabIndex = 12;
            this.lblPerfil.Text = "Perfil*";
            this.lblPerfil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPerfil.UseCustomForeColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 23;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(29, 81);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(147, 29);
            this.cmbStatus.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbStatus.TabIndex = 11;
            this.cmbStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbStatus, "Exemplo : \"Ativo\"");
            this.cmbStatus.UseSelectable = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(26, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 25);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Red;
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status*";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblStatus.UseCustomForeColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(178, 327);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Clique para limpar os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.LightGray;
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRetornar.Location = new System.Drawing.Point(23, 327);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 30);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRetornar.TabIndex = 15;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnRetornar, "Clique para cancelar o cadastro");
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
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 385);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbOutros);
            this.Controls.Add(this.gpbLogin);
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cadastrar Usuário";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastroLogin_Load);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.gpbOutros.ResumeLayout(false);
            this.gpbOutros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtProntuario;
        public MetroFramework.Controls.MetroTextBox txtConfirmeSenha;
        public MetroFramework.Controls.MetroTextBox txtSenha;
        public MetroFramework.Controls.MetroButton btnCadastrar;
        public MetroFramework.Controls.MetroComboBox cmbStatus;
        public MetroFramework.Controls.MetroComboBox cmbPerfil;
        public System.Windows.Forms.GroupBox gpbLogin;
        public MetroFramework.Controls.MetroLabel lblConSenha;
        public MetroFramework.Controls.MetroLabel lblSenha;
        public MetroFramework.Controls.MetroLabel lblProntuario;
        public System.Windows.Forms.GroupBox gpbOutros;
        public MetroFramework.Controls.MetroLabel lblStatus;
        public MetroFramework.Controls.MetroLabel lblPerfil;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroLabel lblDados;
        private System.Windows.Forms.Timer tmrRelogio;
        public MetroFramework.Controls.MetroLabel lblForca;
        private MetroFramework.Components.MetroToolTip ttpDica;
    }
}