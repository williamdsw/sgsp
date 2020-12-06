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
    public partial class frmEmissaoAtendimento : MetroForm
    {
        #region Variáveis

        private string _Requerente, _Entrada, _TipoPerfil, _Codigo = null;

        private int _IdLogin;

        #endregion

        #region Encapsuladores

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

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

        public int IdLogin
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }

        #endregion

        //Instância do banco
        Banco bd = new Banco();

        //-----------------------------------------Eventos--------------------------------------//

        public frmEmissaoAtendimento()
        {
            InitializeComponent();
        }

        #region Evento para carregar dados e itens (Load)

        private void frmEmissaoAtendimento_Load(object sender, EventArgs e)
        {
            NomeAluno();

            tmrRelogio.Start();
        }

        #endregion

        #region Evento para cadastrar/atualizar os dados da emissão (Click)

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Instância da classe Funcionário
                Funcionario fun = new Funcionario();

                //Pego o prontuário do funcionário a partir do valor do id do login
                string prontuarioFuncionario = bd.GetProntuario("ID_LOGIN", _IdLogin.ToString(), "funcionarios");

                //Pego o email a partir do valor do prontuário
                string email = fun.GetEmail(prontuarioFuncionario);

                if (Codigo == null)
                {
                    #region Cadastrando dados da Emissão

                    EmissaoAtendimento eat = new EmissaoAtendimento(cmbAluno.SelectedItem.ToString(), _Requerente, txtRelato.Text,
                                                                    txtProvidencias.Text, cmbStatus.SelectedItem.ToString(), txtProntuarioAluno.Text);


                    MetroMessageBox.Show(this, eat.Insere(cmbAluno.SelectedItem.ToString(), _Requerente, txtRelato.Text,
                                               txtProvidencias.Text, cmbStatus.SelectedItem.ToString(), txtProntuarioAluno.Text)
                                               , "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                    #endregion
                }
                else
                {
                    #region Alterando valor do status

                    EmissaoAtendimento eat = new EmissaoAtendimento();

                    MetroMessageBox.Show(this, eat.Altera(Codigo, cmbStatus.SelectedItem.ToString()),
                                         "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                    #endregion
                }

                #region Enviando Email

                if (!String.IsNullOrEmpty(email))
                {
                    //Se o status da emissão for pendente, será enviado um email avisando para marcar nova data para finalizar o atendimento.
                    if (cmbStatus.SelectedItem.ToString() == "Pendente")
                    {
                        var opcao = MetroMessageBox.Show(this, "Deseja enviar um e-mail para o servidor(a) avisando-o(a) sobre a emissão pendente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                        if (opcao == System.Windows.Forms.DialogResult.Yes)
                        {
                            frmEncaminharAtendimento frm = new frmEncaminharAtendimento();

                            frm.Email = email;
                            frm.EnviarEmail(frm.Email, "emissao");

                            MetroMessageBox.Show(this, "E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                        }
                    }
                }

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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para fechar o form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
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

        #region Evento para pegar o nome do aluno e carregar o prontuário do mesmo (SelectedIndexChanged)

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = cmbAluno.SelectedItem.ToString();

            txtProntuarioAluno.Text = bd.GetProntuario("NOME", nome, "aluno");
        }

        #endregion

        #region Evento para desabilitar groupbox "Requerente" (CheckedChanged)

        private void rbtVontadePropria_CheckedChanged(object sender, EventArgs e)
        {
            gpbRequerente.Enabled = false;
        }

        #endregion

        #region Evento para habilitar groupbox "Requerente" (CheckedChanged)

        private void rbtOutros_CheckedChanged(object sender, EventArgs e)
        {
            gpbRequerente.Enabled = true;
        }

        #endregion

        #region Evento pra abrir tela de consulta quando fechar o Form (FormClosing)

        private void frmEmissaoAtendimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        con.IdLogin = this.IdLogin;

                        con.Consulta = "emissao";

                        con.TipoPerfil = this.TipoPerfil;

                        con.Show();
                    }
                    else
                    {
                        if(Application.OpenForms["frmPrincipal"] != null)
                        {
                            Application.OpenForms["frmPrincipal"].Focus();
                        }
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
            try
            {
                //se for escolhido o radioButton rbtVontadeProria, o requerente e prontuário serão o usuário logado
                if (rbtVontadePropria.Checked)
                {
                    if (!String.IsNullOrEmpty(txtProntuarioAluno.Text))
                    {
                        _Requerente = bd.GetNome("PRONTUARIO", txtProntuarioAluno.Text, "aluno");
                    }
                }
                else
                    if (rbtOutros.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtRequerente.Text))
                        {
                            //caso contrário, será necessário escolher um dos funcionários cadastrados
                            _Requerente = txtRequerente.Text;
                        }
                    }

                if (Codigo == null)
                {
                    //Verifica se todos os campos estão preenchidos para o cadastro
                    if (!String.IsNullOrEmpty(txtProntuarioAluno.Text) && !String.IsNullOrEmpty(_Requerente) && 
                        cmbAluno.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1 &&
                        txtProntuarioAluno.Text.Length == 7 &&
                        !String.IsNullOrEmpty(txtProvidencias.Text) && !String.IsNullOrEmpty(txtRelato.Text))
                    {
                        btnConcluir.Enabled = true;
                    }
                    else
                    {
                        btnConcluir.Enabled = false;
                    }
                }
                else
                {
                    if (cmbStatus.SelectedIndex != -1)
                    {
                        btnConcluir.Enabled = true;
                    }
                }

                EmissaoAtendimento eat = new EmissaoAtendimento();

                //Vai pegar a quantidade de linhas de atendimentos emitidos que há no banco e somar mais  1
                int rows = Convert.ToInt16(eat.GetIDCount().Rows.Count.ToString()) + 1;

                txtCodAtendimento.Text = rows.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para preencher ComboBox 'Aluno'

        private void NomeAluno()
        {
            try
            {
                cmbAluno.Items.Clear();

                foreach (DataRow drow in bd.ConsultaNome("aluno").Rows)
                {
                    cmbAluno.Items.Add(drow["NOME"].ToString());
                }

                cmbAluno.Refresh();
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
                txtProntuarioAluno.Text = null;
                txtRelato.Text = null;
                txtProvidencias.Text = null;
                txtRequerente.Text = null;

                if (cmbStatus.SelectedIndex != -1)
                {
                    cmbStatus.SelectedIndex = -1;
                }

                rbtOutros.Checked = false;

                rbtVontadePropria.Checked = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion
    }
}
