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

namespace SGSP___Desktop
{
    public partial class frmEnviarNotificacao : MetroForm
    {
        #region Variáveis

        private int _IdDestinatario, _IdRemetente;

        private string _Prontuario, _Entrada, _TipoPerfil;

        #endregion

        #region Encapsuladores

        public string Entrada
        {
            get { return _Entrada; }
            set { _Entrada = value; }
        }

        public string TipoPerfil
        {
            get { return _TipoPerfil; }
            set { _TipoPerfil = value; }
        }

        public int IdRemetente
        {
            get { return _IdRemetente; }
            set { _IdRemetente = value; }
        }

        #endregion

        //Instância do banco
        Banco bd = new Banco();

        //-----------------------------------------Eventos--------------------------------------//

        public frmEnviarNotificacao()
        {
            InitializeComponent();
        }

        #region Evento para carregar dados e itens (Load)

        private void frmEscreverNotificacao_Load(object sender, EventArgs e)
        {
            if (Entrada != "visualizacao")
            {
                nomeDestinatario();

                lblNome.Text = bd.GetNome("ID_LOGIN", IdRemetente.ToString(), "funcionarios");

                tmrRelogio.Start();
            }
        }

        #endregion

        #region Evento para cadastrar os dados da notificação (Click)

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Login lg = new Login();

                _Prontuario = bd.GetProntuario("NOME", cmbPara.SelectedItem.ToString(), "funcionarios");

                _IdDestinatario = lg.GetIDLogin(_Prontuario);

                #region Cadastrar notificação no banco

                Notificacao not = new Notificacao(txtAssunto.Text, txtMensagem.Text, cmbPrioridade.SelectedItem.ToString(),
                                                  IdRemetente, _IdDestinatario);

                MetroMessageBox.Show(this, not.Insere(txtAssunto.Text, txtMensagem.Text, cmbPrioridade.SelectedItem.ToString(),
                                           IdRemetente, _IdDestinatario), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                #endregion

                #region Saindo ou limpando campos do formulário

                //pergunta se quer fechar o form ou não
                var sair = MetroMessageBox.Show(this, "Fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (sair == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    LimparCampos();
                }

                #endregion
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para limpar campos (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para fechar o form (Click)

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento pra abrir tela de consulta quando fechar o Form (FormClosing)

        private void frmEscreverNotificacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    switch (Entrada)
                    {
                        case "consulta":

                            frmConsulta con = new frmConsulta();

                            con.IdLogin = this.IdRemetente;

                            con.Consulta = "notificacoes";

                            con.TipoPerfil = this.TipoPerfil;

                            con.tspEmitir.Visible = false;
                            con.tspExportar.Visible = false;
                            con.tspHistorico.Visible = false;

                            con.Show();

                            break;

                        case "notificacao nova":

                            frmConsulta csl = new frmConsulta();

                            csl.IdLogin = this.IdRemetente;

                            csl.Consulta = "notificacoes novas";

                            csl.TipoPerfil = this.TipoPerfil;

                            csl.tspEmitir.Visible = false;
                            csl.tspExportar.Visible = false;

                            csl.Show();

                            break;

                        default:

                            if(Application.OpenForms["frmPrincipal"] != null)
                            {
                                Application.OpenForms["frmPrincipal"].Focus();
                            }

                            break;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para verificar se os campos foram digitados e habilitar o botão (Tick)

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            if (cmbPara.SelectedIndex > -1 && cmbPrioridade.SelectedIndex > -1 && 
                !String.IsNullOrEmpty(txtAssunto.Text) && !String.IsNullOrEmpty(txtMensagem.Text))
            {
                btnEnviar.Enabled = true;
            }
            else
            {
                btnEnviar.Enabled = false;
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para preencher ComboBox 'Requerente' (Método)

        private void nomeDestinatario()
        {
            Funcionario fun = new Funcionario();

            try
            {
                cmbPara.Items.Clear();

                foreach (DataRow drow in fun.ConsultaNomeLogin().Rows)
                {
                    cmbPara.Items.Add(drow["NOME"].ToString());
                }

                cmbPara.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para limpar campos do formulário

        private void LimparCampos()
        {
            try
            {
                txtAssunto.Text = null;

                txtMensagem.Text = null;

                if (cmbPara.SelectedIndex != -1)
                {
                    cmbPara.SelectedIndex = -1;
                }

                if (cmbPrioridade.SelectedIndex != -1)
                {
                    cmbPrioridade.SelectedIndex = -1;
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
