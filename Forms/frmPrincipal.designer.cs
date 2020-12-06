namespace SGSP___Desktop
{
    partial class frmPrincipal
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
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menSGSP = new System.Windows.Forms.MenuStrip();
            this.mniGerenciarAtendimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEncaminhar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEmitir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarEncaminhamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarEmissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrarPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastrarOutros = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarOutros = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarModulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotificacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotificacoesEnviar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotificacoesConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotificacoesNovas = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNotificacoesTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOutros = new System.Windows.Forms.ToolStripMenuItem();
            this.mniManualUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDeslogar = new System.Windows.Forms.ToolStripMenuItem();
            this.ninNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menSGSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblData.Location = new System.Drawing.Point(6, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 25);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "data";
            // 
            // ptbImagem
            // 
            this.ptbImagem.BackgroundImage = global::SGSP___Desktop.Properties.Resources.png_sgsp;
            this.ptbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagem.Location = new System.Drawing.Point(20, 120);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(545, 226);
            this.ptbImagem.TabIndex = 36;
            this.ptbImagem.TabStop = false;
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(378, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(22, 25);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "a";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Location = new System.Drawing.Point(20, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // menSGSP
            // 
            this.menSGSP.BackColor = System.Drawing.Color.White;
            this.menSGSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.menSGSP.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menSGSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menSGSP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGerenciarAtendimentos,
            this.mniCadastrar,
            this.mniConsultar,
            this.mniNotificacoes,
            this.mniOutros});
            this.menSGSP.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menSGSP.Location = new System.Drawing.Point(20, 60);
            this.menSGSP.Name = "menSGSP";
            this.menSGSP.Size = new System.Drawing.Size(548, 28);
            this.menSGSP.TabIndex = 13;
            // 
            // mniGerenciarAtendimentos
            // 
            this.mniGerenciarAtendimentos.BackColor = System.Drawing.Color.White;
            this.mniGerenciarAtendimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEncaminhar,
            this.mniEmitir,
            this.mniConsultarEncaminhamentos,
            this.mniConsultarEmissoes});
            this.mniGerenciarAtendimentos.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.mniGerenciarAtendimentos.Name = "mniGerenciarAtendimentos";
            this.mniGerenciarAtendimentos.Size = new System.Drawing.Size(185, 24);
            this.mniGerenciarAtendimentos.Text = "Gerenciar Atendimentos";
            // 
            // mniEncaminhar
            // 
            this.mniEncaminhar.Name = "mniEncaminhar";
            this.mniEncaminhar.Size = new System.Drawing.Size(272, 24);
            this.mniEncaminhar.Text = "Encaminhar";
            this.mniEncaminhar.Click += new System.EventHandler(this.mniEncaminhar_Click);
            // 
            // mniEmitir
            // 
            this.mniEmitir.Name = "mniEmitir";
            this.mniEmitir.Size = new System.Drawing.Size(272, 24);
            this.mniEmitir.Text = "Emitir";
            this.mniEmitir.Click += new System.EventHandler(this.mniEmitir_Click);
            // 
            // mniConsultarEncaminhamentos
            // 
            this.mniConsultarEncaminhamentos.Name = "mniConsultarEncaminhamentos";
            this.mniConsultarEncaminhamentos.Size = new System.Drawing.Size(272, 24);
            this.mniConsultarEncaminhamentos.Text = "Consultar Encaminhamentos";
            this.mniConsultarEncaminhamentos.Click += new System.EventHandler(this.mniConsultarEncaminhamentos_Click);
            // 
            // mniConsultarEmissoes
            // 
            this.mniConsultarEmissoes.Name = "mniConsultarEmissoes";
            this.mniConsultarEmissoes.Size = new System.Drawing.Size(272, 24);
            this.mniConsultarEmissoes.Text = "Consultar Emissões";
            this.mniConsultarEmissoes.Click += new System.EventHandler(this.mniConsultarEmissoes_Click);
            // 
            // mniCadastrar
            // 
            this.mniCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastrarAluno,
            this.mniCadastrarFuncionario,
            this.mniCadastrarPerfil,
            this.mniCadastrarUsuario,
            this.mniCadastrarOutros});
            this.mniCadastrar.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.mniCadastrar.Name = "mniCadastrar";
            this.mniCadastrar.Size = new System.Drawing.Size(87, 24);
            this.mniCadastrar.Text = "Cadastrar";
            // 
            // mniCadastrarAluno
            // 
            this.mniCadastrarAluno.Name = "mniCadastrarAluno";
            this.mniCadastrarAluno.Size = new System.Drawing.Size(152, 24);
            this.mniCadastrarAluno.Text = "Aluno";
            this.mniCadastrarAluno.Click += new System.EventHandler(this.mniCadastrarAluno_Click);
            // 
            // mniCadastrarFuncionario
            // 
            this.mniCadastrarFuncionario.Name = "mniCadastrarFuncionario";
            this.mniCadastrarFuncionario.Size = new System.Drawing.Size(152, 24);
            this.mniCadastrarFuncionario.Text = "Servidor";
            this.mniCadastrarFuncionario.Click += new System.EventHandler(this.mniCadastrarFuncionario_Click);
            // 
            // mniCadastrarPerfil
            // 
            this.mniCadastrarPerfil.Name = "mniCadastrarPerfil";
            this.mniCadastrarPerfil.Size = new System.Drawing.Size(152, 24);
            this.mniCadastrarPerfil.Text = "Perfil";
            this.mniCadastrarPerfil.Click += new System.EventHandler(this.mniCadastrarPerfil_Click);
            // 
            // mniCadastrarUsuario
            // 
            this.mniCadastrarUsuario.Name = "mniCadastrarUsuario";
            this.mniCadastrarUsuario.Size = new System.Drawing.Size(152, 24);
            this.mniCadastrarUsuario.Text = "Usuário";
            this.mniCadastrarUsuario.Click += new System.EventHandler(this.mniCadastrarUsuario_Click);
            // 
            // mniCadastrarOutros
            // 
            this.mniCadastrarOutros.Name = "mniCadastrarOutros";
            this.mniCadastrarOutros.Size = new System.Drawing.Size(152, 24);
            this.mniCadastrarOutros.Text = "Outros...";
            this.mniCadastrarOutros.Click += new System.EventHandler(this.mniCadastrarOutros_Click);
            // 
            // mniConsultar
            // 
            this.mniConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniConsultarAluno,
            this.mniConsultarFuncionario,
            this.mniConsultarPerfil,
            this.mniConsultarUsuario,
            this.mniConsultarOutros});
            this.mniConsultar.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.mniConsultar.Name = "mniConsultar";
            this.mniConsultar.Size = new System.Drawing.Size(86, 24);
            this.mniConsultar.Text = "Consultar";
            // 
            // mniConsultarAluno
            // 
            this.mniConsultarAluno.Name = "mniConsultarAluno";
            this.mniConsultarAluno.Size = new System.Drawing.Size(152, 24);
            this.mniConsultarAluno.Text = "Aluno";
            this.mniConsultarAluno.Click += new System.EventHandler(this.mniConsultarAluno_Click);
            // 
            // mniConsultarFuncionario
            // 
            this.mniConsultarFuncionario.Name = "mniConsultarFuncionario";
            this.mniConsultarFuncionario.Size = new System.Drawing.Size(152, 24);
            this.mniConsultarFuncionario.Text = "Servidor";
            this.mniConsultarFuncionario.Click += new System.EventHandler(this.mniConsultarFuncionario_Click);
            // 
            // mniConsultarPerfil
            // 
            this.mniConsultarPerfil.Name = "mniConsultarPerfil";
            this.mniConsultarPerfil.Size = new System.Drawing.Size(152, 24);
            this.mniConsultarPerfil.Text = "Perfil";
            this.mniConsultarPerfil.Click += new System.EventHandler(this.mniConsultarPerfil_Click);
            // 
            // mniConsultarUsuario
            // 
            this.mniConsultarUsuario.Name = "mniConsultarUsuario";
            this.mniConsultarUsuario.Size = new System.Drawing.Size(152, 24);
            this.mniConsultarUsuario.Text = "Usuário";
            this.mniConsultarUsuario.Click += new System.EventHandler(this.mniConsultarUsuario_Click);
            // 
            // mniConsultarOutros
            // 
            this.mniConsultarOutros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniConsultarCurso,
            this.mniConsultarModulo,
            this.mniConsultarTurma});
            this.mniConsultarOutros.Name = "mniConsultarOutros";
            this.mniConsultarOutros.Size = new System.Drawing.Size(152, 24);
            this.mniConsultarOutros.Text = "Outros...";
            // 
            // mniConsultarCurso
            // 
            this.mniConsultarCurso.Name = "mniConsultarCurso";
            this.mniConsultarCurso.Size = new System.Drawing.Size(130, 24);
            this.mniConsultarCurso.Text = "Curso";
            this.mniConsultarCurso.Click += new System.EventHandler(this.mniConsultarCurso_Click);
            // 
            // mniConsultarModulo
            // 
            this.mniConsultarModulo.Name = "mniConsultarModulo";
            this.mniConsultarModulo.Size = new System.Drawing.Size(130, 24);
            this.mniConsultarModulo.Text = "Módulo";
            this.mniConsultarModulo.Click += new System.EventHandler(this.mniConsultarModulo_Click);
            // 
            // mniConsultarTurma
            // 
            this.mniConsultarTurma.Name = "mniConsultarTurma";
            this.mniConsultarTurma.Size = new System.Drawing.Size(130, 24);
            this.mniConsultarTurma.Text = "Turma";
            this.mniConsultarTurma.Click += new System.EventHandler(this.mniConsultarTurma_Click);
            // 
            // mniNotificacoes
            // 
            this.mniNotificacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNotificacoesEnviar,
            this.mniNotificacoesConsultar});
            this.mniNotificacoes.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.mniNotificacoes.Name = "mniNotificacoes";
            this.mniNotificacoes.Size = new System.Drawing.Size(103, 24);
            this.mniNotificacoes.Text = "Notificações";
            // 
            // mniNotificacoesEnviar
            // 
            this.mniNotificacoesEnviar.Name = "mniNotificacoesEnviar";
            this.mniNotificacoesEnviar.Size = new System.Drawing.Size(152, 24);
            this.mniNotificacoesEnviar.Text = "Enviar";
            this.mniNotificacoesEnviar.Click += new System.EventHandler(this.mniNotificacoesEnviar_Click);
            // 
            // mniNotificacoesConsultar
            // 
            this.mniNotificacoesConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNotificacoesNovas,
            this.mniNotificacoesTodas});
            this.mniNotificacoesConsultar.Name = "mniNotificacoesConsultar";
            this.mniNotificacoesConsultar.Size = new System.Drawing.Size(152, 24);
            this.mniNotificacoesConsultar.Text = "Consultar";
            // 
            // mniNotificacoesNovas
            // 
            this.mniNotificacoesNovas.Name = "mniNotificacoesNovas";
            this.mniNotificacoesNovas.Size = new System.Drawing.Size(120, 24);
            this.mniNotificacoesNovas.Text = "Novas";
            this.mniNotificacoesNovas.Click += new System.EventHandler(this.mniNotificacoesNovas_Click);
            // 
            // mniNotificacoesTodas
            // 
            this.mniNotificacoesTodas.Name = "mniNotificacoesTodas";
            this.mniNotificacoesTodas.Size = new System.Drawing.Size(120, 24);
            this.mniNotificacoesTodas.Text = "Todas";
            this.mniNotificacoesTodas.Click += new System.EventHandler(this.mniNotificacoesTodas_Click);
            // 
            // mniOutros
            // 
            this.mniOutros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniManualUsuario,
            this.mniSobre,
            this.mniDeslogar});
            this.mniOutros.Font = new System.Drawing.Font("Open Sans Light", 11F);
            this.mniOutros.Name = "mniOutros";
            this.mniOutros.Size = new System.Drawing.Size(68, 24);
            this.mniOutros.Text = "Outros";
            // 
            // mniManualUsuario
            // 
            this.mniManualUsuario.Name = "mniManualUsuario";
            this.mniManualUsuario.Size = new System.Drawing.Size(207, 24);
            this.mniManualUsuario.Text = "Manual do Usuário";
            this.mniManualUsuario.Click += new System.EventHandler(this.mniManualUsuario_Click);
            // 
            // mniSobre
            // 
            this.mniSobre.Name = "mniSobre";
            this.mniSobre.Size = new System.Drawing.Size(207, 24);
            this.mniSobre.Text = "Sobre...";
            this.mniSobre.Click += new System.EventHandler(this.mniSobre_Click);
            // 
            // mniDeslogar
            // 
            this.mniDeslogar.Name = "mniDeslogar";
            this.mniDeslogar.Size = new System.Drawing.Size(207, 24);
            this.mniDeslogar.Text = "Deslogar";
            this.mniDeslogar.Click += new System.EventHandler(this.mniDeslogar_Click);
            // 
            // ninNotificacao
            // 
            this.ninNotificacao.BalloonTipClicked += new System.EventHandler(this.ninNotificacao_BalloonTipClicked);
            this.ninNotificacao.BalloonTipClosed += new System.EventHandler(this.ninNotificacao_BalloonTipClosed);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 453);
            this.Controls.Add(this.ptbImagem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menSGSP);
            this.MainMenuStrip = this.menSGSP;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SGSP - Tela Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menSGSP.ResumeLayout(false);
            this.menSGSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblData;
        private System.Windows.Forms.Timer tmrRelogio;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menSGSP;
        private System.Windows.Forms.ToolStripMenuItem mniGerenciarAtendimentos;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrar;
        private System.Windows.Forms.ToolStripMenuItem mniConsultar;
        private System.Windows.Forms.ToolStripMenuItem mniEncaminhar;
        private System.Windows.Forms.ToolStripMenuItem mniEmitir;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarEncaminhamentos;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarEmissoes;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrarPerfil;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mniCadastrarOutros;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarAluno;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarPerfil;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarOutros;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarCurso;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarModulo;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarTurma;
        private System.Windows.Forms.ToolStripMenuItem mniNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem mniOutros;
        private System.Windows.Forms.ToolStripMenuItem mniManualUsuario;
        private System.Windows.Forms.ToolStripMenuItem mniSobre;
        private System.Windows.Forms.ToolStripMenuItem mniDeslogar;
        private System.Windows.Forms.ToolStripMenuItem mniNotificacoesEnviar;
        private System.Windows.Forms.ToolStripMenuItem mniNotificacoesConsultar;
        private System.Windows.Forms.ToolStripMenuItem mniNotificacoesNovas;
        private System.Windows.Forms.ToolStripMenuItem mniNotificacoesTodas;
        public System.Windows.Forms.PictureBox ptbImagem;
        private System.Windows.Forms.NotifyIcon ninNotificacao;
    }
}