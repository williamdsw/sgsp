using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//--
using MetroFramework;
using MetroFramework.Forms;

namespace SGSP___Desktop
{
    public partial class frmLogin : MetroForm
    {
        #region Variáveis

        private string _TipoPerfil, _Status;

        #endregion

        #region Encapsuladores

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string TipoPerfil
        {
            get { return _TipoPerfil; }
            set { _TipoPerfil = value; }
        }

        #endregion

        #region Instância de classes

        Login lg = new Login();

        Banco bd = new Banco();

        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        #region Evento para efetuar o login (Click)

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {     
                //Pego o status do usuário no banco - ativo ou inativo
                Status = lg.GetOutros("STATUS", txtProntuario.Text);

                //Pego o tipo do perfil do usuário no banco - Administrador, Total ou Parcial
                TipoPerfil = lg.GetOutros("PERFIL", txtProntuario.Text);

                //verifico o prontuário e senha
                if (lg.VerificaLogin(txtProntuario.Text, txtSenha.Text))
                {
                    if (Status == "Ativo")
                    {
                        if (Application.OpenForms["frmPrincipal"] == null)
                        {
                            MetroMessageBox.Show(this, "Bem vindo, " + bd.GetNome("PRONTUARIO", txtProntuario.Text, "funcionarios"),
                                                 "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);

                            frmPrincipal frm = new frmPrincipal();

                            frm.Usuario = bd.GetNome("PRONTUARIO", txtProntuario.Text, "funcionarios");

                            switch (frm.Usuario)
                            {
                                case "Administrador":
                                case "Total":
                                case "Parcial":

                                    break;

                                default:

                                    //essa linha faz com que a variável Usuário tenha o valor da primeira palavra da string completa, utilizando o método Substring, que recebe 0 e IndexOf()
                                    frm.Usuario = frm.Usuario.Substring(0, frm.Usuario.IndexOf(" "));

                                    break;
                            }

                            //Passo valores desses encapsuladores para encapsuladores da tela principal
                            frm.IdLogin = lg.GetIDLogin(txtProntuario.Text);
                            
                            frm.TipoPerfil = this.TipoPerfil;

                            frm.Show();

                            this.Hide();
                        }
                        else
                        {
                            Application.OpenForms["frmPrincipal"].Focus();
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Usuário inativo!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Stop, 150);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Prontuário ou senha errada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }
        
        #endregion

        #region Evento para abrir tela de cadastro de funcionário/usuário (Click)

        private void lnkUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmOpcao frm = new frmOpcao();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para verificar se os campos foram digitados e habilitar o botão (Tick)

        private void trmRelogio_Tick(object sender, EventArgs e)
        {
            try
            {
                //Aqui verifico se os campos de prontuario e senha foram preenchidos, para habilitar o botão de entrar no sistema.
                if (!String.IsNullOrEmpty(txtProntuario.Text) && txtProntuario.Text.Length == 6
                    && !String.IsNullOrEmpty(txtSenha.Text))
                {
                    btnEntrar.Enabled = true;
                    btnEntrar.Highlight = true;
                }
                else
                {
                    btnEntrar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para fechar o programa (FormClosed)

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion
    }
}
