using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;

namespace SGSP___Desktop
{
    public partial class frmPrincipal : MetroForm
    {
        #region Variáveis

        //Variáveis private utilizadas em Encapsuladores
        private string _Usuario, _TipoPerfil;

        private int _IdLogin;

        //três vetores de string usados para pegar os nome dos menus das telas
        private string[] _MenuPai = new string[5];
        private string[] _MenuFilho = new string[5];
        private string[] _MenuNeto = new string[3];

        //um timer para ativar a notificação por timer
        Timer tmrAtualizado = new Timer();

        #endregion

        #region Encapsuladores

        public int IdLogin
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string TipoPerfil
        {
            get { return _TipoPerfil; }
            set { _TipoPerfil = value; }
        }

        //-----------------Encapsuladores privados para tratar o recebimento e informações de mensagens----//

        private int _IdNotificacao
        {
            get;
            set;
        }

        private string _Situacao
        {
            get;
            set;
        }

        private string _Assunto
        {
            get;
            set;
        }

        private string _Mensagem
        {
            get;
            set;
        }

        private string _Prioridade
        {
            get;
            set;
        }

        private string _Remetente
        {
            get;
            set;
        }

        private string _Destinatario
        {
            get;
            set;
        }

        private string _Tipo
        {
            get;
            set;
        }

        private string _idEncaminhamento
        {
            get;
            set;
        }

        //----------------Encapsuladores para tratar valores de permisões dos Menus-------------//

        public string[] MenuPai
        {
            get { return _MenuPai; }
            set { _MenuPai = value; }
        }

        public string[] MenuFilho
        {
            get { return _MenuFilho; }
            set { _MenuFilho = value; }
        }

        public string[] MenuNeto
        {
            get { return _MenuNeto; }
            set { _MenuNeto = value; }
        }

        #endregion

        //Instância do Banco
        Banco bd = new Banco();

        //-----------------------------------------Eventos--------------------------------------//

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Evento que carrega os métodos (Load)

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //inicia o timer
            tmrRelogio.Start();

            Controle();

            ninNotificacao.Icon = Properties.Resources.ico_Notification;

            //mostrará todas as notificações não vistas
            Notificacao("load");
        }

        #endregion

        #region Evento que carrega a data, hora e nome do usuário (Tick)

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString().ToString();

            lblUsuario.Text = Usuario;
        }

        #endregion

        #region Evento carrega a notificação simultânea (Tick)

        private void tmrAtualizado_Tick(object sender, EventArgs e)
        {
            Notificacao("timer");
        }

        #endregion

        #region Eventos que abrem/fecham forms (Click)

        #region Menu "Gerenciar Atendimentos"

        private void mniEncaminhar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmEncaminharAtendimento"] == null)
                {
                    frmEncaminharAtendimento frm = new frmEncaminharAtendimento();

                    frm.IdLogin = this.IdLogin;

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmEncaminhamento"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }

        }

        private void mniEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmEmissaoAtendimento"] == null)
                {
                    frmEmissaoAtendimento frm = new frmEmissaoAtendimento();

                    frm.IdLogin = this.IdLogin;

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmEmissaoAtendimento"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarEncaminhamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "encaminhamento";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarEmissoes_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "emissao";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Menu "Cadastrar"

        private void mniCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastroAluno"] == null)
                {
                    frmCadastroAluno frm = new frmCadastroAluno();

                    frm.IdLogin = this.IdLogin;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmCadastroAluno"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void mniCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastroFuncionario"] == null)
                {
                    frmCadastroFuncionario frm = new frmCadastroFuncionario();

                    frm.IdLogin = this.IdLogin;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmCadastroFuncionario"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniCadastrarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastroPerfil"] == null)
                {
                    frmCadastroPerfil frm = new frmCadastroPerfil();

                    frm.IdLogin = this.IdLogin;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmCadastroPerfil"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastroUsuario"] == null)
                {
                    frmCadastroUsuario frm = new frmCadastroUsuario();

                    frm.IdUser = this.IdLogin;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmCadastroUsuario"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniCadastrarOutros_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastrarOutros"] == null)
                {
                    frmCadastrarOutros frm = new frmCadastrarOutros();

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.IdLogin = this.IdLogin;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmCadastrarOutros"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Menu "Consultar"

        private void mniConsultarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "aluno";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void mniConsultarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "funcionario";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "perfil";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "usuario";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "curso";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarModulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "modulo";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniConsultarTurma_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmConsulta"] == null)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.IdLogin = this.IdLogin;

                    frm.Consulta = "turma";

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.tspExportar.Visible = false;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmConsulta"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Menu "Notificações"

        private void mniNotificacoesEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmEnviarNotificacao"] == null)
                {
                    frmEnviarNotificacao frm = new frmEnviarNotificacao();

                    frm.IdRemetente = this.IdLogin;

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.Show();
                }
                else
                {
                    Application.OpenForms["frmEnviarNotificacao"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void mniNotificacoesNovas_Click(object sender, EventArgs e)
        {
            try
            {
                Notificacao not = new Notificacao();

                if (not.NotificacoesNovas(IdLogin).Rows.Count > 0)
                {
                    if (Application.OpenForms["frmConsulta"] == null)
                    {
                        frmConsulta frm = new frmConsulta();

                        frm.IdLogin = this.IdLogin;

                        frm.Consulta = "notificacoes novas";

                        frm.TipoPerfil = this.TipoPerfil;

                        frm.tspExportar.Visible = false;

                        frm.Show();
                    }
                    else
                    {
                        Application.OpenForms["frmConsulta"].Focus();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Não existem notificações novas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        private void mniNotificacoesTodas_Click(object sender, EventArgs e)
        {
            try
            {
                Notificacao not = new Notificacao();

                if (not.Notificacoes(IdLogin).Rows.Count > 0)
                {
                    if (Application.OpenForms["frmConsulta"] == null)
                    {
                        frmConsulta frm = new frmConsulta();

                        frm.IdLogin = this.IdLogin;

                        frm.Consulta = "notificacoes";

                        frm.TipoPerfil = this.TipoPerfil;

                        frm.tspExportar.Visible = false;

                        frm.Show();
                    }
                    else
                    {
                        Application.OpenForms["frmConsulta"].Focus();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Não existem notificações recebidas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Menu "Outros"

        private void mniManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //COLOQUE AQUI O CAMINHO DO ARQUIVO DO MANUAL DO USUÁRIO
                //indica o caminho do arquivo PDF
                /*String caminhoPDF = @"Manual do usuário.pdf";

                //instancia o método WriteAllBytes() da classe File
                File.WriteAllBytes(caminhoPDF, SGSP___Desktop.Properties.Resources.Manual_do_usuário);

                //Abre o arquivo PDF pelo método Start() da classe Process
                Process.Start(caminhoPDF);*/
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void mniSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();

            sobre.ShowDialog();
        }

        private void mniDeslogar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #endregion

        #region Evento pra abrir tela de login quando fechar o Form (FormClosing)

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (!Application.OpenForms["frmLogin"].IsAccessible)
                    {
                        Application.OpenForms["frmLogin"].Controls["gpbLogin"].Controls["txtProntuario"].Text = "";

                        Application.OpenForms["frmLogin"].Controls["gpbLogin"].Controls["txtSenha"].Text = "";

                        Application.OpenForms["frmLogin"].Show();

                        Application.OpenForms["frmLogin"].Focus();
                    }
                }
                else
                {
                    e.Cancel = true;
                }

                if (ninNotificacao.Visible == true)
                {
                    ninNotificacao.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento que realiza quaisquer ações sobre o clique da notificação (BalloonTipClicked)

        private void ninNotificacao_BalloonTipClicked(object sender, EventArgs e)
        {
            try
            {
                Notificacao nt = new Notificacao();

                switch (_Situacao)
                {
                    #region Load...

                    case "load":

                        int numero = nt.NotificacoesNovas(IdLogin).Rows.Count;

                        if (numero == 1)
                        {
                            frmEnviarNotificacao fnt = new frmEnviarNotificacao();

                            fnt.Text = "Dados da Notificação";

                            fnt.btnEnviar.Visible = false;
                            fnt.btnLimpar.Visible = false;

                            fnt.Entrada = "visualizacao";

                            fnt.txtAssunto.Text = _Assunto;
                            fnt.txtMensagem.Text = _Mensagem;
                            fnt.cmbPrioridade.PromptText = _Prioridade;
                            fnt.lblNome.Text = _Remetente;
                            fnt.cmbPara.PromptText = _Destinatario;

                            nt.Altera(_IdNotificacao);

                            fnt.Show();
                        }
                        else
                            if (numero >= 1)
                            {
                                //instancia o form
                                frmConsulta frm = new frmConsulta();

                                //algumas configurações
                                frm.IdLogin = this.IdLogin;

                                frm.Consulta = "notificacoes novas";

                                frm.TipoPerfil = this.TipoPerfil;

                                frm.tspHistorico.Visible = false;
                                frm.tspExportar.Visible = false;
                                frm.tspEmitir.Visible = false;

                                frm.Show();
                            }

                        //desabilita a notificação
                        ninNotificacao.Visible = false;

                        //inicia o timer e "seta" o evento dele
                        tmrAtualizado.Start();

                        tmrAtualizado.Tick += tmrAtualizado_Tick;

                        break;

                    #endregion

                    #region Timer...

                    case "timer":

                        switch (_Tipo)
                        {
                            case "notificacao":
                                {
                                    frmEnviarNotificacao fnt = new frmEnviarNotificacao();

                                    fnt.Text = "Dados da Notificação";

                                    fnt.btnEnviar.Visible = false;
                                    fnt.btnLimpar.Visible = false;

                                    fnt.Entrada = "visualizacao";

                                    fnt.txtAssunto.Text = _Assunto;
                                    fnt.txtMensagem.Text = _Mensagem;
                                    fnt.cmbPrioridade.PromptText = _Prioridade;
                                    fnt.lblNome.Text = _Remetente;
                                    fnt.cmbPara.PromptText = _Destinatario;

                                    nt.Altera(_IdNotificacao);

                                    fnt.Show();

                                    //desabilita a notificação
                                    ninNotificacao.Visible = false;
                                }

                                break;

                            case "encaminhamento":
                                {
                                    frmConsulta frc = new frmConsulta();

                                    frc.IdLogin = this.IdLogin;

                                    frc.Consulta = "encaminhamento";

                                    frc.TipoPerfil = this.TipoPerfil;

                                    frc.tspHistorico.Visible = false;
                                    frc.tspExportar.Visible = false;

                                    frc.Show();

                                    foreach (DataGridViewRow row in frc.dgvDados.Rows)
                                    {
                                        if (row.Cells[0].Value.ToString() == _idEncaminhamento)
                                        {
                                            row.Selected = true;
                                        }

                                        frc.dgvDados.Sort(frc.dgvDados.Columns[0], ListSortDirection.Descending);
                                    }

                                    //desabilita a notificação
                                    ninNotificacao.Visible = false;
                                }

                                break;
                        }

                        break;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento que realiza qualquer ação no fechamento da notificação (BalloonTipClosed)

        private void ninNotificacao_BalloonTipClosed(object sender, EventArgs e)
        {
            try
            {
                //desablita a notificação
                ninNotificacao.Visible = false;           

                //se o timer não ter sido iniciado ainda
                if(tmrAtualizado.Enabled != true)
                {
                    tmrAtualizado.Start();

                    tmrAtualizado.Tick += tmrAtualizado_Tick;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para definir controle dos objetos do form de acordo com o perfil do usuário 

        private void Controle()
        {
            try
            {
                bool permissao = false;

                int idPerfil = bd.GetID(TipoPerfil, "ID_PERFIL", "perfil");

                int idModulo = 0;

                string modulo = null;

                ModuloPerfil mp = new ModuloPerfil();

                //Esse é um for que pega os items "pais" do menu SGSP items
                for (int a = 0; a < menSGSP.Items.Count; a++)
                {
                    MenuPai[a] = menSGSP.Items[a].ToString();
                }

                //Esse é um for que vai determinar as permissões
                for (int b = 0; b < MenuPai.Length; b++)
                {
                    //Esse é um switch que vai delimitar todas as permissões
                    switch (MenuPai[b])
                    {
                        #region Configurações do Item de menu Gerenciar Atendimentos

                        case "Gerenciar Atendimentos":

                            //utilizo outro for para pegar o conteúdo do DropDownItems do item de menu mniCadastrar
                            for (int c = 0; c < mniGerenciarAtendimentos.DropDownItems.Count; c++)
                            {
                                MenuFilho[c] = mniGerenciarAtendimentos.DropDownItems[c].ToString();
                            }

                            for (int d = 0; d < MenuFilho.Length; d++)
                            {
                                switch (MenuFilho[d])
                                {
                                    #region Configurações do item de menu Encaminhar

                                    case "Encaminhar":

                                        //modulo receberá o valor do _MenuFilho[posição do vetor]
                                        modulo = MenuFilho[d].ToString();

                                        //modulo receberá o valor dele mesmo utilizando o método Replace(), que substitui o valor que ele contém
                                        modulo = modulo.Replace("Encaminhar", "Encaminhar Atendimento");

                                        //idModulo receberá o valor do método GetID()
                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        //permissao receberá o valor do método GetPermissao()
                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        //Se o "status" de habilitado do menu for igual ao valor da variável permissão, o menu será acessível, senão, ficará bloqueado
                                        if (mniEncaminhar.Enabled == permissao)
                                        {
                                            mniEncaminhar.Enabled = true;
                                        }
                                        else
                                        {
                                            mniEncaminhar.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Emitir

                                    case "Emitir":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Emitir", "Emissão Atendimento");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniEmitir.Enabled == permissao)
                                        {
                                            mniEmitir.Enabled = true;
                                        }
                                        else
                                        {
                                            mniEmitir.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Consultar Encaminhamentos

                                    case "Consultar Encaminhamentos":

                                        modulo = MenuFilho[d].ToString();

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniConsultarEncaminhamentos.Enabled == permissao)
                                        {
                                            mniConsultarEncaminhamentos.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarEncaminhamentos.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Consultar Emissões

                                    case "Consultar Emissões":

                                        modulo = MenuFilho[d].ToString();

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniConsultarEmissoes.Enabled == permissao)
                                        {
                                            mniConsultarEmissoes.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarEmissoes.Enabled = false; ;
                                        }

                                        break;

                                    #endregion
                                }
                            }

                            break;

                        #endregion

                        #region Configurações do item de menu Cadastrar

                        case "Cadastrar":

                            //utilizo outro for para pegar o conteúdo do DropDownItems do item de menu mniCadastrar
                            for (int c = 0; c < mniCadastrar.DropDownItems.Count; c++)
                            {
                                MenuFilho[c] = mniCadastrar.DropDownItems[c].ToString();
                            }

                            for (int d = 0; d < MenuFilho.Length; d++)
                            {
                                switch (MenuFilho[d])
                                {
                                    #region Configurações do item de menu Aluno

                                    case "Aluno":

                                        //modulo receberá o valor do _MenuFilho[posição do vetor]
                                        modulo = MenuFilho[d].ToString();

                                        //modulo receberá o valor dele mesmo utilizando o método Replace(), que substitui o valor que ele contém
                                        modulo = modulo.Replace("Aluno", "Cadastro Aluno");

                                        //idModulo receberá o valor do método GetID()
                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        //permissao receberá o valor do método GetPermissao()
                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        //Se o "status" de habilitado do menu for igual ao valor da variável permissão, o menu será acessível, senão, ficará bloqueado
                                        if (mniCadastrarAluno.Enabled == permissao)
                                        {
                                            mniCadastrarAluno.Enabled = true;
                                        }
                                        else
                                        {
                                            mniCadastrarAluno.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Funcionário

                                    case "Servidor":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Servidor", "Cadastro Servidor");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniCadastrarFuncionario.Enabled == permissao)
                                        {
                                            mniCadastrarFuncionario.Enabled = true;
                                        }
                                        else
                                        {
                                            mniCadastrarFuncionario.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Perfil

                                    case "Perfil":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Perfil", "Cadastro Perfil");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniCadastrarPerfil.Enabled == permissao)
                                        {
                                            mniCadastrarPerfil.Enabled = true;
                                        }
                                        else
                                        {
                                            mniCadastrarPerfil.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Usuário

                                    case "Usuário":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Usuário", "Cadastro Usuário");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniCadastrarUsuario.Enabled == permissao)
                                        {
                                            mniCadastrarUsuario.Enabled = true;
                                        }
                                        else
                                        {
                                            mniCadastrarUsuario.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Outros

                                    case "Outros..":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Outros...", "Cadastro Outros");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniCadastrarOutros.Enabled == permissao)
                                        {
                                            mniCadastrarOutros.Enabled = true;
                                        }
                                        else
                                        {
                                            mniCadastrarOutros.Enabled = false; ;
                                        }

                                        break;

                                    #endregion
                                }
                            }

                            break;

                        #endregion

                        #region Configurações do item de menu Consultar

                        case "Consultar":

                            //utilizo outro for para pegar o conteúdo do DropDownItems do item de menu mniCadastrar
                            for (int c = 0; c < mniConsultar.DropDownItems.Count; c++)
                            {
                                MenuFilho[c] = mniConsultar.DropDownItems[c].ToString();
                            }

                            for (int d = 0; d < MenuFilho.Length; d++)
                            {
                                switch (MenuFilho[d])
                                {
                                    #region Configurações do item de menu Aluno

                                    case "Aluno":

                                        //modulo receberá o valor do MenuFilho[posição do vetor]
                                        modulo = MenuFilho[d].ToString();

                                        //modulo receberá o valor dele mesmo utilizando o método Replace(), que substitui o valor que ele contém
                                        modulo = modulo.Replace("Aluno", "Consulta Aluno");

                                        //idModulo receberá o valor do método GetID()
                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        //permissao receberá o valor do método GetPermissao()
                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        //Se o "status" de habilitado do menu for igual ao valor da variável permissão, o menu será acessível, senão, ficará bloqueado
                                        if (mniConsultarAluno.Enabled == permissao)
                                        {
                                            mniConsultarAluno.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarAluno.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Funcionário

                                    case "Servidor":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Servidor", "Consulta Servidor");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniConsultarFuncionario.Enabled == permissao)
                                        {
                                            mniConsultarFuncionario.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarFuncionario.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Perfil

                                    case "Perfil":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Perfil", "Consulta Perfil");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniConsultarPerfil.Enabled == permissao)
                                        {
                                            mniConsultarPerfil.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarPerfil.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Usuário

                                    case "Usuário":

                                        modulo = MenuFilho[d].ToString();

                                        modulo = modulo.Replace("Usuário", "Consulta Usuário");

                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        if (mniConsultarUsuario.Enabled == permissao)
                                        {
                                            mniConsultarUsuario.Enabled = true;
                                        }
                                        else
                                        {
                                            mniConsultarUsuario.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Outros

                                    case "Outros...":

                                        for (int e = 0; e < mniOutros.DropDownItems.Count; e++)
                                        {
                                            MenuNeto[e] = mniConsultarOutros.DropDownItems[e].ToString();
                                        }

                                        for (int f = 0; f < MenuNeto.Length; f++)
                                        {
                                            switch (MenuNeto[f])
                                            {
                                                #region Configurações do item de menu Curso

                                                case "Curso":

                                                    modulo = MenuNeto[f].ToString();

                                                    modulo = modulo.Replace("Curso", "Consulta Curso");

                                                    idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                                    permissao = mp.GetPermissao(idModulo, idPerfil);

                                                    if (mniConsultarCurso.Enabled == permissao)
                                                    {
                                                        mniConsultarCurso.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        mniConsultarCurso.Enabled = false; ;
                                                    }

                                                    break;

                                                #endregion

                                                #region Configurações do item de menu Módulo

                                                case "Módulo":

                                                    modulo = MenuNeto[f].ToString();

                                                    modulo = modulo.Replace("Módulo", "Consulta Módulo");

                                                    idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                                    permissao = mp.GetPermissao(idModulo, idPerfil);

                                                    if (mniConsultarModulo.Enabled == permissao)
                                                    {
                                                        mniConsultarModulo.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        mniConsultarModulo.Enabled = false; ;
                                                    }

                                                    break;

                                                #endregion

                                                #region Configurações do item de menu Turma

                                                case "Turma":

                                                    modulo = MenuNeto[f].ToString();

                                                    modulo = modulo.Replace("Turma", "Consulta Turma");

                                                    idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                                    permissao = mp.GetPermissao(idModulo, idPerfil);

                                                    if (mniConsultarTurma.Enabled == permissao)
                                                    {
                                                        mniConsultarTurma.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        mniConsultarTurma.Enabled = false; ;
                                                    }

                                                    break;

                                                #endregion
                                            }
                                        }

                                        break;

                                    #endregion
                                }
                            }

                            break;

                        #endregion

                        #region Configurações do item de menu Notificações

                        case "Notificacoes":

                            //utilizo outro for para pegar o conteúdo do DropDownItems do item de menu mniCadastrar
                            for (int c = 0; c < mniNotificacoes.DropDownItems.Count; c++)
                            {
                                MenuFilho[c] = mniNotificacoes.DropDownItems[c].ToString();
                            }

                            for (int d = 0; d < MenuFilho.Length; d++)
                            {
                                switch (MenuFilho[d])
                                {
                                    #region Configurações do item de menu Enviar

                                    case "Enviar":

                                        //modulo receberá o valor do MenuFilho[posição do vetor]
                                        modulo = MenuFilho[d].ToString();

                                        //modulo receberá o valor dele mesmo utilizando o método Replace(), que substitui o valor que ele contém
                                        modulo = modulo.Replace("Enviar", "Enviar Notificação");

                                        //idModulo receberá o valor do método GetID()
                                        idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                        //permissao receberá o valor do método GetPermissao()
                                        permissao = mp.GetPermissao(idModulo, idPerfil);

                                        //Se o "status" de habilitado do menu for igual ao valor da variável permissão, o menu será acessível, senão, ficará bloqueado
                                        if (mniNotificacoesEnviar.Enabled == permissao)
                                        {
                                            mniNotificacoesEnviar.Enabled = true;
                                        }
                                        else
                                        {
                                            mniNotificacoesEnviar.Enabled = false; ;
                                        }

                                        break;

                                    #endregion

                                    #region Configurações do item de menu Consultar

                                    case "Consultar":

                                        for (int e = 0; e < mniNotificacoesConsultar.DropDownItems.Count; e++)
                                        {
                                            _MenuNeto[e] = mniNotificacoesConsultar.DropDownItems[e].ToString();
                                        }

                                        for (int f = 0; f < _MenuNeto.Length; f++)
                                        {
                                            switch (_MenuNeto[f])
                                            {
                                                #region Configurações do item de menu Novas

                                                case "Novas":

                                                    modulo = _MenuNeto[f].ToString();

                                                    modulo = modulo.Replace("Novas", "Consulta Notificação Nova");

                                                    idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                                    permissao = mp.GetPermissao(idModulo, idPerfil);

                                                    if (mniNotificacoesNovas.Enabled == permissao)
                                                    {
                                                        mniNotificacoesNovas.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        mniNotificacoesNovas.Enabled = false; ;
                                                    }

                                                    break;

                                                #endregion

                                                #region Configurações do item de menu Todas

                                                case "Todas":

                                                    modulo = _MenuNeto[f].ToString();

                                                    modulo = modulo.Replace("Todas", "Consulta Notificação");

                                                    idModulo = bd.GetID(modulo, "ID_MODULO", "modulo");

                                                    permissao = mp.GetPermissao(idModulo, idPerfil);

                                                    if (mniNotificacoesTodas.Enabled == permissao)
                                                    {
                                                        mniNotificacoesTodas.Enabled = true;
                                                    }
                                                    else
                                                    {
                                                        mniNotificacoesTodas.Enabled = false; ;
                                                    }

                                                    break;

                                                #endregion
                                            }
                                        }

                                        break;

                                    #endregion
                                }
                            }

                            break;

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para mostrar as notificações 

        private void Notificacao(string situacao)
        {
            Notificacao nt = new Notificacao();

            try
            {
                _Situacao = situacao;

                switch (_Situacao)
                {
                    #region Load...

                    case "load":
                        {
                            int numero = nt.NotificacoesNovas(IdLogin).Rows.Count;

                            if (numero == 1)
                            {
                                foreach (DataRow row in nt.NotificacoesNovas(IdLogin).Rows)
                                {
                                    _IdNotificacao = Convert.ToInt16(row[0]);
                                    _Assunto = row[1].ToString();
                                    _Mensagem = row[2].ToString();
                                    _Prioridade = row[3].ToString();

                                    string prontuario = bd.GetProntuario("ID_LOGIN", row[5].ToString(), "login");

                                    _Remetente = bd.GetNome("PRONTUARIO", prontuario, "funcionarios");

                                    prontuario = bd.GetProntuario("ID_LOGIN", row[6].ToString(), "login");

                                    _Destinatario = bd.GetNome("PRONTUARIO", prontuario, "funcionarios");
                                }

                                ninNotificacao.Visible = true;

                                ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você contém " + numero + " nova notificação, clique para visualizar", ToolTipIcon.Info);
                            }
                            else
                                if (numero > 1)
                                {
                                    ninNotificacao.Visible = true;

                                    ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você contém " + numero + " novas notificações, clique para visualizar", ToolTipIcon.Info);
                                }
                                else
                                {
                                    ninNotificacao.Visible = true;

                                    ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você não contém novas notificações", ToolTipIcon.Info);
                                }                         
                        }

                        break;

                    #endregion

                    #region Timer...

                    case "timer":
                        {
                            #region Notificações de Mensagens

                            bool novaMensagem = false;

                            foreach (DataRow row in nt.NotificacaoNova(IdLogin, out novaMensagem).Rows)
                            {
                                _IdNotificacao = Convert.ToInt16(row[0]);
                                _Assunto = row[1].ToString();
                                _Mensagem = row[2].ToString();
                                _Prioridade = row[3].ToString();

                                string prontuario = bd.GetProntuario("ID_LOGIN", row[5].ToString(), "login");

                                _Remetente = bd.GetNome("PRONTUARIO", prontuario, "funcionarios");

                                prontuario = bd.GetProntuario("ID_LOGIN", row[6].ToString(), "login");

                                _Destinatario = bd.GetNome("PRONTUARIO", prontuario, "funcionarios");
                            }

                            if (novaMensagem == true)
                            {
                                _Tipo = "notificacao";

                                if (ninNotificacao.Visible == true)
                                {
                                    ninNotificacao.Visible = false;

                                    ninNotificacao.Visible = true;

                                    ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você contém 1 nova notificação de prioridade " + _Prioridade + ", clique para visualizar", ToolTipIcon.Warning);
                                }
                                else
                                {
                                    ninNotificacao.Visible = true;

                                    ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você contém 1 nova notificação de prioridade " + _Prioridade + ", clique para visualizar", ToolTipIcon.Warning);

                                    tmrAtualizado.Stop();
                                }
                            }

                            #endregion

                            #region Notificações do Encaminhamento

                            bool novoEncaminhamento = false;

                            string nome = bd.GetNome("ID_LOGIN", IdLogin.ToString(), "funcionarios");

                            foreach (DataRow row in nt.EncaminhamentoNovo(nome, out novoEncaminhamento).Rows)
                            {
                                _idEncaminhamento = row[0].ToString();
                            }

                            if (novoEncaminhamento == true)
                            {
                                _Tipo = "encaminhamento";

                                if (ninNotificacao.Visible != true)
                                {
                                    ninNotificacao.Visible = true;

                                    ninNotificacao.ShowBalloonTip(1000, "Atenção!", "Você contém um novo encaminhamento, clique para visualizá-lo", ToolTipIcon.Warning);
                                }
                            }

                            #endregion
                        }

                        break;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion
    }
}

