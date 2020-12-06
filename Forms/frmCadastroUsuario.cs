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
using System.Text.RegularExpressions;   //utilizada para Regex

namespace SGSP___Desktop
{
    public partial class frmCadastroUsuario : MetroForm
    {
        #region Variáveis

        private string _Codigo = null, _Entrada, _TipoPerfil;

        private int _IdLogin, _IdPerfil, _IdUser;

        private bool _OK = false;

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

        public int IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }

        #endregion

        //Instância de banco
        Banco bd = new Banco();

        //-----------------------------------------Eventos--------------------------------------//

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroLogin_Load(object sender, EventArgs e)
        {
            NomePerfil();

            tmrRelogio.Start();

            cmbPerfil.Items.Remove("Total");
        }

        #endregion

        #region Evento para limpar campos (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #endregion

        #region Evento para fechar o Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para cadastrar ou atualizar usuário (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                _IdPerfil = bd.GetID(cmbPerfil.SelectedItem.ToString(), "ID_PERFIL", "perfil");

                if (lblForca.Text == "Senha forte!")
                {
                    #region Cadastrar ou atualizar usuário

                    if (Codigo == null)
                    {
                        if (txtProntuario.Text.Length == 6)
                        {
                            if (bd.Verifica("PRONTUARIO", "login", txtProntuario.Text) == true)
                            {
                                MetroMessageBox.Show(this, "Esse usuário já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                            }
                            else
                            {
                                Login lg = new Login(txtProntuario.Text, txtSenha.Text, cmbPerfil.SelectedItem.ToString(),
                                                     cmbStatus.SelectedItem.ToString());

                                MetroMessageBox.Show(this, lg.Insere(txtProntuario.Text, txtSenha.Text, cmbPerfil.SelectedItem.ToString(),
                                                          cmbStatus.SelectedItem.ToString()), "Sucesso",
                                                          MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                                _IdLogin = lg.GetIDLogin(txtProntuario.Text);

                                Funcionario fun = new Funcionario();

                                fun.SetIDLogin(_IdLogin, txtProntuario.Text);
                            }
                        }
                    }
                    else
                    {
                        Login lg = new Login();

                        MetroMessageBox.Show(this, lg.Altera(Codigo, txtSenha.Text, cmbPerfil.SelectedItem.ToString(),
                                                  cmbStatus.SelectedItem.ToString()), "Sucesso",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                    }

                    #endregion                 
                }
                else
                {
                    MetroMessageBox.Show(this, "A senha é muito fraca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                }

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

        #region Evento pra abrir aba ou tela de consulta quando fechar o Form (FormClosing)

        private void frmCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        con.IdLogin = this.IdUser;

                        con.Consulta = "usuario";

                        con.TipoPerfil = this.TipoPerfil;

                        con.tspEmitir.Visible = false;
                        con.tspExportar.Visible = false;
                        con.tspHistorico.Visible = false;

                        con.Show();
                    }
                    else
                    {
                        if (Application.OpenForms["frmPrincipal"] != null)
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
                //Verifica se a senha e a senha confirmada são iguais

                if (!String.IsNullOrEmpty(txtSenha.Text) && !String.IsNullOrEmpty(txtConfirmeSenha.Text))
                {
                    if (txtConfirmeSenha.Text == txtSenha.Text)
                    {
                        //faz algumas mudanças no BackColor e ForeColor do TextBox
                        txtConfirmeSenha.UseCustomBackColor = true;
                        txtConfirmeSenha.UseCustomForeColor = true;
                        txtConfirmeSenha.BackColor = Color.Green;
                        txtConfirmeSenha.ForeColor = Color.White;

                        _OK = true;
                    }
                    else
                    {
                        txtConfirmeSenha.UseCustomBackColor = true;
                        txtConfirmeSenha.UseCustomForeColor = true;
                        txtConfirmeSenha.BackColor = Color.Red;
                        txtConfirmeSenha.ForeColor = Color.White;

                        _OK = false;
                    }
                }
                else
                {
                    txtConfirmeSenha.UseCustomBackColor = true;
                    txtConfirmeSenha.UseCustomForeColor = true;
                    txtConfirmeSenha.BackColor = Color.White;
                    txtConfirmeSenha.ForeColor = Color.Black;
                }
                
                //Verifica se todos os campos estão preenchidos para o cadastro
                if (!String.IsNullOrEmpty(txtProntuario.Text) && !String.IsNullOrEmpty(txtSenha.Text) &&
                    !String.IsNullOrEmpty(txtConfirmeSenha.Text) &&
                    cmbStatus.SelectedIndex != -1 && cmbPerfil.SelectedIndex != -1 &&
                    txtProntuario.Text.Length == 6 && _OK == true)
                {
                    btnCadastrar.Enabled = true;
                }
                else
                {
                    btnCadastrar.Enabled = false;
                }

                //Se existir um usuário que usa o Perfil de Administrador, então essa opção
                //será excluida do ComboBox
                if (bd.Verifica("NOME", "perfil", "Administrador") == true)
                {
                    cmbPerfil.Items.Remove("Administrador");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }
        
        #endregion

        #region Evento para verificar a senha é forte ou não (TextChanged)

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //se o tamanho o texto for diferente de 0, irá validar o método
                if (txtSenha.Text.Length != 0)
                {
                    lblForca.Visible = true;

                    if (VerificaSenhaForte(txtSenha.Text) == true)
                    {
                        lblForca.Text = "Senha forte!";
                    }
                    else
                    {
                        lblForca.Text = "Senha fraca!";
                    }
                }
                else
                {
                    lblForca.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para verificar se o usuário existe no banco ou não (TextChanged)

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProntuario.Enabled == true)
                {
                    if (txtProntuario.Text.Length == 6)
                    {
                        if (bd.Verifica("PRONTUARIO", "login", txtProntuario.Text) == true)
                        {
                            MetroMessageBox.Show(this, "Esse usuário já existe!", "Atenção", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Warning, 100);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para preencher ComboBox 'Perfil' 

        private void NomePerfil()
        {
            try
            {
                cmbPerfil.Items.Clear();

                foreach (DataRow drow in bd.ConsultaNome("perfil").Rows)
                {
                    cmbPerfil.Items.Add(drow["NOME"].ToString());
                }

                cmbPerfil.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para verificar a força da senha 

        private bool VerificaSenhaForte(string senha)
        {
            try
            {
                int tamanhoMinimo = 8, tamanhoMinusculo = 1, tamanhoMaiusculo = 1,
                    tamanhoNumeros = 1, tamanhoCaracteresEspeciais = 1;


                /* Expressões regulares são padrões de caracteres que associam-se
                 * à sequências de caracteres no texto. Podem ser usadas para extrair
                 * ou substituir pedaços de texto, modificar formato de texto ou remover
                 * caracteres inválidos.
                 * A classe usada para manipular essas expressões é a classe Regex
                */

                Regex regTamanhoMinusculo = new Regex("[a-z]"); // Definição de letras minusculas
                Regex regTamanhoMaiusculo = new Regex("[A-Z]"); //definição de letras maiusculas
                Regex regTamanhoNumeros = new Regex("[0-9]"); //definição de números
                Regex regCaracteresEspeciais = new Regex("[^a-zA-Z0-9]"); //definição de caracteres especiais

                // Verificando tamanho minimo
                if (senha.Length < tamanhoMinimo) 
                    return false;

                // Verificando caracteres minusculos
                if (regTamanhoMinusculo.Matches(senha).Count < tamanhoMinusculo) 
                    return false;

                // Verificando caracteres maiusculos
                if (regTamanhoMaiusculo.Matches(senha).Count < tamanhoMaiusculo) 
                    return false;

                // Verificando numeros
                if (regTamanhoNumeros.Matches(senha).Count < tamanhoNumeros) 
                    return false;

                // Verificando os diferentes
                if (regCaracteresEspeciais.Matches(senha).Count < tamanhoCaracteresEspeciais) 
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                return false;
            }
        }

        #endregion

        #region Método para limpar campos do formulário

        private void LimparCampos()
        {
            try
            {
                if (txtProntuario.Enabled)
                {
                    txtProntuario.Text = null;
                }

                txtSenha.Text = null; txtConfirmeSenha.Text = null;

                if (cmbStatus.SelectedIndex != -1)
                {
                    cmbStatus.SelectedIndex = -1;
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
