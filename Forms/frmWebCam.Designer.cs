namespace SGSP___Desktop
{
    partial class frmWebCam
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
            this.gpbImagem = new System.Windows.Forms.GroupBox();
            this.ptbCamera = new System.Windows.Forms.PictureBox();
            this.cmbDispositivos = new MetroFramework.Controls.MetroComboBox();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnTirar = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbImagem
            // 
            this.gpbImagem.Controls.Add(this.ptbCamera);
            this.gpbImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbImagem.Location = new System.Drawing.Point(23, 63);
            this.gpbImagem.Name = "gpbImagem";
            this.gpbImagem.Size = new System.Drawing.Size(474, 344);
            this.gpbImagem.TabIndex = 0;
            this.gpbImagem.TabStop = false;
            // 
            // ptbCamera
            // 
            this.ptbCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbCamera.Location = new System.Drawing.Point(6, 25);
            this.ptbCamera.Name = "ptbCamera";
            this.ptbCamera.Size = new System.Drawing.Size(462, 300);
            this.ptbCamera.TabIndex = 35;
            this.ptbCamera.TabStop = false;
            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDispositivos.FormattingEnabled = true;
            this.cmbDispositivos.ItemHeight = 23;
            this.cmbDispositivos.Location = new System.Drawing.Point(23, 439);
            this.cmbDispositivos.Name = "cmbDispositivos";
            this.cmbDispositivos.Size = new System.Drawing.Size(178, 29);
            this.cmbDispositivos.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbDispositivos.TabIndex = 1;
            this.cmbDispositivos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbDispositivos, "Escolha o dispostivo instalado");
            this.cmbDispositivos.UseSelectable = true;
            this.cmbDispositivos.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivos_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSalvar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(397, 438);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnSalvar, "Clique para salvar a foto");
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTirar
            // 
            this.btnTirar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTirar.BackColor = System.Drawing.Color.LightGray;
            this.btnTirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTirar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTirar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnTirar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTirar.Location = new System.Drawing.Point(251, 438);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(100, 30);
            this.btnTirar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnTirar.TabIndex = 2;
            this.btnTirar.Text = "Tirar!";
            this.btnTirar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnTirar, "Clique para tirar a foto ou tirar de novo");
            this.btnTirar.UseSelectable = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
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
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbDispositivos);
            this.Controls.Add(this.gpbImagem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWebCam";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Capturar imagem da webcam";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmWebCam_Load);
            this.gpbImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbImagem;
        public System.Windows.Forms.PictureBox ptbCamera;
        public MetroFramework.Controls.MetroComboBox cmbDispositivos;
        public MetroFramework.Controls.MetroButton btnSalvar;
        public MetroFramework.Controls.MetroButton btnTirar;
        private System.Windows.Forms.Timer tmrRelogio;
        private MetroFramework.Components.MetroToolTip ttpDica;
    }
}