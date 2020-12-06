namespace SGSP___Desktop
{
    partial class frmCadastroPerfil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomePerfil = new MetroFramework.Controls.MetroLabel();
            this.txtNomePerfil = new MetroFramework.Controls.MetroTextBox();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.clmPermissao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnRetornar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.lblDados = new MetroFramework.Controls.MetroLabel();
            this.gpbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomePerfil.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomePerfil.Location = new System.Drawing.Point(23, 58);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(66, 25);
            this.lblNomePerfil.Style = MetroFramework.MetroColorStyle.Black;
            this.lblNomePerfil.TabIndex = 0;
            this.lblNomePerfil.Text = "Nome*";
            this.lblNomePerfil.UseCustomForeColor = true;
            // 
            // txtNomePerfil
            // 
            // 
            // 
            // 
            this.txtNomePerfil.CustomButton.Image = null;
            this.txtNomePerfil.CustomButton.Location = new System.Drawing.Point(492, 1);
            this.txtNomePerfil.CustomButton.Name = "";
            this.txtNomePerfil.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomePerfil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomePerfil.CustomButton.TabIndex = 1;
            this.txtNomePerfil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomePerfil.CustomButton.UseSelectable = true;
            this.txtNomePerfil.CustomButton.Visible = false;
            this.txtNomePerfil.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomePerfil.Lines = new string[0];
            this.txtNomePerfil.Location = new System.Drawing.Point(23, 86);
            this.txtNomePerfil.MaxLength = 32767;
            this.txtNomePerfil.Name = "txtNomePerfil";
            this.txtNomePerfil.PasswordChar = '\0';
            this.txtNomePerfil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomePerfil.SelectedText = "";
            this.txtNomePerfil.SelectionLength = 0;
            this.txtNomePerfil.SelectionStart = 0;
            this.txtNomePerfil.Size = new System.Drawing.Size(514, 23);
            this.txtNomePerfil.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtNomePerfil.TabIndex = 1;
            this.txtNomePerfil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtNomePerfil, "Exemplo : \"Administrador\"");
            this.txtNomePerfil.UseSelectable = true;
            this.txtNomePerfil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomePerfil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.dgvDados);
            this.gpbConsulta.Location = new System.Drawing.Point(23, 115);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(514, 421);
            this.gpbConsulta.TabIndex = 2;
            this.gpbConsulta.TabStop = false;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPermissao,
            this.clmModulo});
            this.dgvDados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(502, 396);
            this.dgvDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgvDados.TabIndex = 3;
            this.dgvDados.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // clmPermissao
            // 
            this.clmPermissao.DividerWidth = 1;
            this.clmPermissao.FillWeight = 150F;
            this.clmPermissao.HeaderText = "Permissão*";
            this.clmPermissao.Name = "clmPermissao";
            this.clmPermissao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPermissao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmPermissao.Width = 225;
            // 
            // clmModulo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmModulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmModulo.DividerWidth = 1;
            this.clmModulo.FillWeight = 150F;
            this.clmModulo.HeaderText = "Módulo*";
            this.clmModulo.Name = "clmModulo";
            this.clmModulo.Width = 225;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(439, 575);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 35);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnCadastrar, "Clique para finalizar o cadastramento");
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRetornar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRetornar.Location = new System.Drawing.Point(23, 575);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(96, 35);
            this.btnRetornar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRetornar.TabIndex = 4;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnRetornar, "Clique para cancelar o cadastramento");
            this.btnRetornar.UseSelectable = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpar.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLimpar.Location = new System.Drawing.Point(220, 575);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 35);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnLimpar, "Clique para limpar os campos");
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.ForeColor = System.Drawing.Color.Green;
            this.lblDados.Location = new System.Drawing.Point(409, 539);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(128, 19);
            this.lblDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDados.TabIndex = 42;
            this.lblDados.Text = "Dados obrigatórios*";
            this.lblDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDados.UseCustomForeColor = true;
            // 
            // frmCadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 626);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.txtNomePerfil);
            this.Controls.Add(this.lblNomePerfil);
            this.MaximizeBox = false;
            this.Name = "frmCadastroPerfil";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cadastro de Perfil";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroFuncionario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastroPerfil_Load);
            this.gpbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroGrid dgvDados;
        public MetroFramework.Controls.MetroLabel lblNomePerfil;
        public MetroFramework.Controls.MetroTextBox txtNomePerfil;
        public System.Windows.Forms.GroupBox gpbConsulta;
        public MetroFramework.Controls.MetroButton btnCadastrar;
        public MetroFramework.Controls.MetroButton btnRetornar;
        public MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Components.MetroToolTip ttpDica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPermissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModulo;
        public MetroFramework.Controls.MetroLabel lblDados;
    }
}