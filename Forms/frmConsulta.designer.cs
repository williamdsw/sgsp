namespace SGSP___Desktop
{
    partial class frmConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvDados = new MetroFramework.Controls.MetroGrid();
            this.cmbParametro = new MetroFramework.Controls.MetroComboBox();
            this.txtPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.lblPalavraChave = new MetroFramework.Controls.MetroLabel();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.ctmMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tspDados = new System.Windows.Forms.ToolStripMenuItem();
            this.tspExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tspHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEmitir = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpDica = new MetroFramework.Components.MetroToolTip();
            this.gpbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.ctmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.dgvDados);
            this.gpbConsulta.Location = new System.Drawing.Point(23, 63);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(805, 310);
            this.gpbConsulta.TabIndex = 2;
            this.gpbConsulta.TabStop = false;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
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
            this.dgvDados.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.ShowEditingIcon = false;
            this.dgvDados.Size = new System.Drawing.Size(790, 280);
            this.dgvDados.Style = MetroFramework.MetroColorStyle.Lime;
            this.dgvDados.TabIndex = 2;
            this.dgvDados.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvDados.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvDados_MouseUp);
            // 
            // cmbParametro
            // 
            this.cmbParametro.FormattingEnabled = true;
            this.cmbParametro.ItemHeight = 23;
            this.cmbParametro.Location = new System.Drawing.Point(6, 19);
            this.cmbParametro.Name = "cmbParametro";
            this.cmbParametro.PromptText = "Parâmetro";
            this.cmbParametro.Size = new System.Drawing.Size(200, 29);
            this.cmbParametro.Style = MetroFramework.MetroColorStyle.Lime;
            this.cmbParametro.TabIndex = 3;
            this.cmbParametro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.cmbParametro, "Exemplo : \"NOME\"");
            this.cmbParametro.UseSelectable = true;
            this.cmbParametro.SelectedIndexChanged += new System.EventHandler(this.cmbParametro_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            // 
            // 
            // 
            this.txtPesquisar.CustomButton.Image = null;
            this.txtPesquisar.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPesquisar.CustomButton.Name = "";
            this.txtPesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisar.CustomButton.TabIndex = 1;
            this.txtPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisar.CustomButton.UseSelectable = true;
            this.txtPesquisar.CustomButton.Visible = false;
            this.txtPesquisar.Enabled = false;
            this.txtPesquisar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisar.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPesquisar.Lines = new string[] {
        "Pesquisar"};
            this.txtPesquisar.Location = new System.Drawing.Point(352, 25);
            this.txtPesquisar.MaxLength = 30;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(200, 23);
            this.txtPesquisar.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.txtPesquisar, "Exemplo : \"João\"");
            this.txtPesquisar.UseSelectable = true;
            this.txtPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPalavraChave.Location = new System.Drawing.Point(212, 23);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(135, 25);
            this.lblPalavraChave.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblPalavraChave.TabIndex = 4;
            this.lblPalavraChave.Text = "Palavra(s)-chave";
            this.lblPalavraChave.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.cmbParametro);
            this.gpbPesquisa.Controls.Add(this.lblPalavraChave);
            this.gpbPesquisa.Controls.Add(this.txtPesquisar);
            this.gpbPesquisa.Location = new System.Drawing.Point(23, 379);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(805, 62);
            this.gpbPesquisa.TabIndex = 8;
            this.gpbPesquisa.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Silver;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeletar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeletar.Highlight = true;
            this.btnDeletar.Location = new System.Drawing.Point(673, 467);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(155, 45);
            this.btnDeletar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnDeletar, "Clique para excluir um registro");
            this.btnDeletar.UseSelectable = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditar.Highlight = true;
            this.btnEditar.Location = new System.Drawing.Point(355, 467);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 45);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnEditar, "Clique para editar um registro");
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNovo.Highlight = true;
            this.btnNovo.Location = new System.Drawing.Point(23, 467);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(155, 45);
            this.btnNovo.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttpDica.SetToolTip(this.btnNovo, "Clique para cadastrar um registro");
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ctmMenu
            // 
            this.ctmMenu.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.ctmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDados,
            this.tspExportar,
            this.tspHistorico,
            this.tspEmitir});
            this.ctmMenu.Name = "ctmMenu";
            this.ctmMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctmMenu.Size = new System.Drawing.Size(197, 100);
            this.ctmMenu.Style = MetroFramework.MetroColorStyle.Lime;
            this.ctmMenu.Text = "Opções";
            this.ctmMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tspDados
            // 
            this.tspDados.Name = "tspDados";
            this.tspDados.Size = new System.Drawing.Size(196, 24);
            this.tspDados.Text = "Dados completos";
            this.tspDados.Click += new System.EventHandler(this.tspDados_Click);
            // 
            // tspExportar
            // 
            this.tspExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspExcel,
            this.tspPDF});
            this.tspExportar.Name = "tspExportar";
            this.tspExportar.Size = new System.Drawing.Size(196, 24);
            this.tspExportar.Text = "Exportar dados";
            // 
            // tspExcel
            // 
            this.tspExcel.Name = "tspExcel";
            this.tspExcel.Size = new System.Drawing.Size(111, 24);
            this.tspExcel.Text = "Excel";
            this.tspExcel.Click += new System.EventHandler(this.tspExcel_Click);
            // 
            // tspPDF
            // 
            this.tspPDF.Name = "tspPDF";
            this.tspPDF.Size = new System.Drawing.Size(111, 24);
            this.tspPDF.Text = "PDF";
            this.tspPDF.Click += new System.EventHandler(this.tspPDF_Click);
            // 
            // tspHistorico
            // 
            this.tspHistorico.Name = "tspHistorico";
            this.tspHistorico.Size = new System.Drawing.Size(196, 24);
            this.tspHistorico.Text = "Histórico";
            this.tspHistorico.Click += new System.EventHandler(this.tpsHistorico_Click);
            // 
            // tspEmitir
            // 
            this.tspEmitir.Name = "tspEmitir";
            this.tspEmitir.Size = new System.Drawing.Size(196, 24);
            this.tspEmitir.Text = "Emitir";
            this.tspEmitir.Click += new System.EventHandler(this.tpsEmitir_Click);
            // 
            // ttpDica
            // 
            this.ttpDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttpDica.StyleManager = null;
            this.ttpDica.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 535);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.gpbPesquisa);
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Consulta";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.gpbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ctmMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsulta;
        public MetroFramework.Controls.MetroGrid dgvDados;
        private MetroFramework.Controls.MetroComboBox cmbParametro;
        public MetroFramework.Controls.MetroTextBox txtPesquisar;
        private MetroFramework.Controls.MetroLabel lblPalavraChave;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private MetroFramework.Controls.MetroButton btnDeletar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnNovo;
        private System.Windows.Forms.Timer tmrRelogio;
        public MetroFramework.Controls.MetroContextMenu ctmMenu;
        public System.Windows.Forms.ToolStripMenuItem tspDados;
        public System.Windows.Forms.ToolStripMenuItem tspExportar;
        public System.Windows.Forms.ToolStripMenuItem tspHistorico;
        private System.Windows.Forms.ToolStripMenuItem tspExcel;
        private System.Windows.Forms.ToolStripMenuItem tspPDF;
        public System.Windows.Forms.ToolStripMenuItem tspEmitir;
        private MetroFramework.Components.MetroToolTip ttpDica;
    }
}