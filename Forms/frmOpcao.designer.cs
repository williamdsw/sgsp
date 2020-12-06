namespace SGSP___Desktop
{
    partial class frmOpcao
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
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.btnFuncionario = new MetroFramework.Controls.MetroButton();
            this.btnUsuario = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFuncionario.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFuncionario.Highlight = true;
            this.btnFuncionario.Location = new System.Drawing.Point(23, 102);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(104, 34);
            this.btnFuncionario.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnFuncionario.TabIndex = 7;
            this.btnFuncionario.Text = "Servidor(a)";
            this.btnFuncionario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnFuncionario, "Cadastrar um servidor");
            this.btnFuncionario.UseSelectable = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUsuario.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUsuario.Location = new System.Drawing.Point(134, 102);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(104, 34);
            this.btnUsuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnUsuario.TabIndex = 8;
            this.btnUsuario.Text = "Usuário(a)";
            this.btnUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnUsuario, "Cadastrar um usuário para o funcionário existente");
            this.btnUsuario.UseSelectable = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // frmOpcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFuncionario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpcao";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cadastrar...";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip ttpDica;
        private MetroFramework.Controls.MetroButton btnFuncionario;
        private MetroFramework.Controls.MetroButton btnUsuario;
    }
}