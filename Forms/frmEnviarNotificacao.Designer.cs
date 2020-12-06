namespace SGSP___Desktop
{
    partial class frmEnviarNotificacao
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
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.cmbPara = new MetroFramework.Controls.MetroComboBox();
            this.lblPara = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblDe = new MetroFramework.Controls.MetroLabel();
            this.lblAssunto = new MetroFramework.Controls.MetroLabel();
            this.txtAssunto = new MetroFramework.Controls.MetroTextBox();
            this.gpbMensagem = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new MetroFramework.Controls.MetroTextBox();
            this.lblPrioridade = new MetroFramework.Controls.MetroLabel();
            this.cmbPrioridade = new MetroFramework.Controls.MetroComboBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnEnviar = new MetroFramework.Controls.MetroButton();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbDados.SuspendLayout();
            this.gpbMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.cmbPara);
            this.gpbDados.Controls.Add(this.lblPara);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Controls.Add(this.lblDe);
            this.gpbDados.Controls.Add(this.lblAssunto);
            this.gpbDados.Controls.Add(this.txtAssunto);
            this.gpbDados.Location = new System.Drawing.Point(23, 63);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(601, 123);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            // 
            // cmbPara
            // 
            this.cmbPara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPara.FormattingEnabled = true;
            this.cmbPara.ItemHeight = 23;
            this.cmbPara.Location = new System.Drawing.Point(91, 19);
            this.cmbPara.Name = "cmbPara";
            this.cmbPara.Size = new System.Drawing.Size(504, 29);
            this.cmbPara.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbPara.TabIndex = 1;
            this.cmbPara.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbPara, "Exemplo : \"João da Silva\"");
            this.cmbPara.UseSelectable = true;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPara.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPara.Location = new System.Drawing.Point(6, 23);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(53, 25);
            this.lblPara.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para*";
            this.lblPara.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPara.UseCustomForeColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(91, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 25);
            this.lblNome.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDe.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDe.Location = new System.Drawing.Point(6, 52);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(40, 25);
            this.lblDe.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De*";
            this.lblDe.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDe.UseCustomForeColor = true;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAssunto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAssunto.Location = new System.Drawing.Point(6, 83);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(79, 25);
            this.lblAssunto.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblAssunto.TabIndex = 0;
            this.lblAssunto.Text = "Assunto*";
            this.lblAssunto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAssunto.UseCustomForeColor = true;
            // 
            // txtAssunto
            // 
            // 
            // 
            // 
            this.txtAssunto.CustomButton.Image = null;
            this.txtAssunto.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.txtAssunto.CustomButton.Name = "";
            this.txtAssunto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAssunto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAssunto.CustomButton.TabIndex = 1;
            this.txtAssunto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAssunto.CustomButton.UseSelectable = true;
            this.txtAssunto.CustomButton.Visible = false;
            this.txtAssunto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAssunto.Lines = new string[0];
            this.txtAssunto.Location = new System.Drawing.Point(91, 83);
            this.txtAssunto.MaxLength = 50;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.PasswordChar = '\0';
            this.txtAssunto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAssunto.SelectedText = "";
            this.txtAssunto.SelectionLength = 0;
            this.txtAssunto.SelectionStart = 0;
            this.txtAssunto.Size = new System.Drawing.Size(504, 23);
            this.txtAssunto.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAssunto.TabIndex = 3;
            this.txtAssunto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtAssunto, "Exemplo : \"Preciso falar com você\"");
            this.txtAssunto.UseSelectable = true;
            this.txtAssunto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAssunto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gpbMensagem
            // 
            this.gpbMensagem.Controls.Add(this.txtMensagem);
            this.gpbMensagem.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.gpbMensagem.ForeColor = System.Drawing.Color.DarkGreen;
            this.gpbMensagem.Location = new System.Drawing.Point(23, 192);
            this.gpbMensagem.Name = "gpbMensagem";
            this.gpbMensagem.Size = new System.Drawing.Size(601, 285);
            this.gpbMensagem.TabIndex = 1;
            this.gpbMensagem.TabStop = false;
            this.gpbMensagem.Text = "Mensagem*";
            // 
            // txtMensagem
            // 
            // 
            // 
            // 
            this.txtMensagem.CustomButton.Image = null;
            this.txtMensagem.CustomButton.Location = new System.Drawing.Point(345, 2);
            this.txtMensagem.CustomButton.Name = "";
            this.txtMensagem.CustomButton.Size = new System.Drawing.Size(241, 241);
            this.txtMensagem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMensagem.CustomButton.TabIndex = 1;
            this.txtMensagem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMensagem.CustomButton.UseSelectable = true;
            this.txtMensagem.CustomButton.Visible = false;
            this.txtMensagem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMensagem.Lines = new string[0];
            this.txtMensagem.Location = new System.Drawing.Point(6, 25);
            this.txtMensagem.MaxLength = 6000;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.SelectionLength = 0;
            this.txtMensagem.SelectionStart = 0;
            this.txtMensagem.Size = new System.Drawing.Size(589, 246);
            this.txtMensagem.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMensagem.TabIndex = 33;
            this.txtMensagem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtMensagem, "Descreva a demanda do aluno");
            this.txtMensagem.UseSelectable = true;
            this.txtMensagem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMensagem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrioridade.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrioridade.Location = new System.Drawing.Point(23, 480);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(97, 25);
            this.lblPrioridade.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblPrioridade.TabIndex = 0;
            this.lblPrioridade.Text = "Prioridade*";
            this.lblPrioridade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPrioridade.UseCustomForeColor = true;
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.ItemHeight = 23;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "Normal",
            "Média",
            "Grave"});
            this.cmbPrioridade.Location = new System.Drawing.Point(23, 508);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(177, 29);
            this.cmbPrioridade.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbPrioridade.TabIndex = 2;
            this.cmbPrioridade.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbPrioridade, "Exemplo : \"Média\"");
            this.cmbPrioridade.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancelar.Location = new System.Drawing.Point(23, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 33);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCancelar, "Clique para cancelar o envio da notificação");
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEnviar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEnviar.Highlight = true;
            this.btnEnviar.Location = new System.Drawing.Point(528, 543);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 33);
            this.btnEnviar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnEnviar, "Clique para enviar a notificação");
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDados.Location = new System.Drawing.Point(496, 486);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(270, 547);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Clique para limpar os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // frmEnviarNotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.gpbMensagem);
            this.Controls.Add(this.gpbDados);
            this.MaximizeBox = false;
            this.Name = "frmEnviarNotificacao";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Enviar Notificação";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEscreverNotificacao_FormClosing);
            this.Load += new System.EventHandler(this.frmEscreverNotificacao_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbMensagem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbDados;
        public MetroFramework.Controls.MetroLabel lblPara;
        public MetroFramework.Controls.MetroLabel lblAssunto;
        public MetroFramework.Controls.MetroTextBox txtAssunto;
        public System.Windows.Forms.GroupBox gpbMensagem;
        public MetroFramework.Controls.MetroLabel lblDe;
        public MetroFramework.Controls.MetroLabel lblPrioridade;
        public MetroFramework.Controls.MetroComboBox cmbPara;
        public MetroFramework.Controls.MetroLabel lblDados;
        public MetroFramework.Controls.MetroButton btnLimpar;
        public MetroFramework.Controls.MetroComboBox cmbPrioridade;
        public MetroFramework.Controls.MetroButton btnCancelar;
        public MetroFramework.Controls.MetroButton btnEnviar;
        public MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.Timer tmrRelogio;
        private MetroFramework.Components.MetroToolTip ttpDica;
        public MetroFramework.Controls.MetroTextBox txtMensagem;
    }
}