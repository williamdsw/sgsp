namespace SGSP___Desktop
{
    partial class frmLogin
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
            this.trmRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.txtProntuario = new MetroFramework.Controls.MetroTextBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.lnkUsuario = new MetroFramework.Controls.MetroLink();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.lblProntuario = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.ptbConsulta = new System.Windows.Forms.PictureBox();
            this.gpbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // trmRelogio
            // 
            this.trmRelogio.Enabled = true;
            this.trmRelogio.Tick += new System.EventHandler(this.trmRelogio_Tick);
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtProntuario
            // 
            // 
            // 
            // 
            this.txtProntuario.CustomButton.Image = null;
            this.txtProntuario.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtProntuario.CustomButton.Name = "";
            this.txtProntuario.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProntuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProntuario.CustomButton.TabIndex = 1;
            this.txtProntuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProntuario.CustomButton.UseSelectable = true;
            this.txtProntuario.CustomButton.Visible = false;
            this.txtProntuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProntuario.Lines = new string[0];
            this.txtProntuario.Location = new System.Drawing.Point(226, 37);
            this.txtProntuario.MaxLength = 6;
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.PasswordChar = '\0';
            this.txtProntuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProntuario.SelectedText = "";
            this.txtProntuario.SelectionLength = 0;
            this.txtProntuario.SelectionStart = 0;
            this.txtProntuario.Size = new System.Drawing.Size(110, 25);
            this.txtProntuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtProntuario.TabIndex = 3;
            this.txtProntuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtProntuario, "Exemplo : \"123456\"");
            this.txtProntuario.UseSelectable = true;
            this.txtProntuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProntuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Enabled = false;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEntrar.Location = new System.Drawing.Point(244, 167);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(92, 34);
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnEntrar, "Clique para logar no sistema");
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lnkUsuario
            // 
            this.lnkUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkUsuario.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkUsuario.Location = new System.Drawing.Point(6, 178);
            this.lnkUsuario.Name = "lnkUsuario";
            this.lnkUsuario.Size = new System.Drawing.Size(132, 23);
            this.lnkUsuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.lnkUsuario.TabIndex = 7;
            this.lnkUsuario.Text = "Cadastrar Usuário";
            this.lnkUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.lnkUsuario, "Clique para criar um usuário novo caso você não tenha");
            this.lnkUsuario.UseSelectable = true;
            this.lnkUsuario.Click += new System.EventHandler(this.lnkUsuario_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSenha.Location = new System.Drawing.Point(128, 97);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 25);
            this.lblSenha.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProntuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProntuario.Location = new System.Drawing.Point(128, 37);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(92, 25);
            this.lblProntuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "Prontuário";
            this.lblProntuario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(226, 97);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(110, 25);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.lnkUsuario);
            this.gpbLogin.Controls.Add(this.ptbConsulta);
            this.gpbLogin.Controls.Add(this.btnEntrar);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lblProntuario);
            this.gpbLogin.Controls.Add(this.txtProntuario);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Location = new System.Drawing.Point(23, 56);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(354, 221);
            this.gpbLogin.TabIndex = 1;
            this.gpbLogin.TabStop = false;
            // 
            // ptbConsulta
            // 
            this.ptbConsulta.BackgroundImage = global::SGSP___Desktop.Properties.Resources.png_Fechadura;
            this.ptbConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbConsulta.Location = new System.Drawing.Point(7, 16);
            this.ptbConsulta.Name = "ptbConsulta";
            this.ptbConsulta.Size = new System.Drawing.Size(115, 124);
            this.ptbConsulta.TabIndex = 11;
            this.ptbConsulta.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.gpbLogin);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SGSP - Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer trmRelogio;
        private MetroFramework.Components.MetroToolTip ttpDica;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtProntuario;
        private MetroFramework.Controls.MetroLabel lblProntuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnEntrar;
        private System.Windows.Forms.GroupBox gpbLogin;
        private MetroFramework.Controls.MetroLink lnkUsuario;
        private System.Windows.Forms.PictureBox ptbConsulta;
    }
}