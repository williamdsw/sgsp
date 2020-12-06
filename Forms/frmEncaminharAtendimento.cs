using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Net.Mail;

namespace SGSP___Desktop
{
    public partial class frmEncaminharAtendimento : MetroForm
    {
        #region Variáveis

        private string _ProntuarioFuncionario, _Codigo = null, _Entrada, _TipoPerfil, _Email, _Dia, _Turno;

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

        public string Email
        {
            get { return _Email;}
            set { _Email = value;}
        }

        public string Dia
        {
            get { return _Dia; }
            set { _Dia = value; }
        }

        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
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

        public frmEncaminharAtendimento()
        {
            InitializeComponent();
        }

        #region Evento para carregar dados e itens (Load)

        private void frmAgendarAtendimento_Load(object sender, EventArgs e)
        {
            NomeAluno();

            //inicia o timer
            tmrRelogio.Start();
        }

        #endregion

        #region Evento para concluir o encaminhamento do atendimento (Click)

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario fun = new Funcionario();

                VerificaNull();

                _ProntuarioFuncionario = bd.GetProntuario("NOME", cmbProfissional.SelectedItem.ToString(), "funcionarios");

                Email = fun.GetEmail(_ProntuarioFuncionario);

                #region Cadastrando dados do encaminhamento

                //instância da classe
                Encaminhamento encaminhar = new Encaminhamento(txtDemanda.Text, _ProntuarioFuncionario,
                                                              txtProntuarioAluno.Text, cmbEncaminharCom.SelectedItem.ToString(),
                                                      cmbProfissional.SelectedItem.ToString(), Dia, Turno, DateTime.Now,
                                                      IdLogin);

                //inserção no banco
                MetroMessageBox.Show(this, encaminhar.Insere(txtDemanda.Text, _ProntuarioFuncionario, txtProntuarioAluno.Text,

                                               cmbEncaminharCom.SelectedItem.ToString(),
                                               cmbProfissional.SelectedItem.ToString(), Dia, Turno, DateTime.Now,
                                               IdLogin), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                #endregion

                #region Enviando email

                //verifica e manda o email
                if (!String.IsNullOrEmpty(Email))
                {
                    var opcao = MetroMessageBox.Show(this, "Deseja enviar um e-mail para o servidor(a) avisando-o(a) sobre o encaminhamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                    if (opcao == System.Windows.Forms.DialogResult.Yes)
                    {
                        EnviarEmail(Email, "encaminhar");

                        MetroMessageBox.Show(this, "E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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
            LimparCampos();
        }

        #endregion

        #region Evento para pegar o nome do aluno e carregar o prontuário do mesmo (SelectedIndexChanged)

        private void cmbNomeAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = cmbNomeAluno.SelectedItem.ToString();

                txtProntuarioAluno.Text = bd.GetProntuario("NOME", nome, "aluno");
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para pegar o nome do profissional (SelectedIndexChanged)

        private void cmbAgendarCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            NomeProfissional();
        }

        #endregion

        #region Evento pra abrir tela de consulta quando fechar o Form (FormClosing)

        private void frmAgendarAtendimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        con.IdLogin = this.IdLogin;

                        con.Consulta = "encaminhamento";

                        con.TipoPerfil = this.TipoPerfil;

                        con.tspHistorico.Visible = false;
                        con.tspExportar.Visible = false;

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
                if(cmbNomeAluno.SelectedIndex != -1 && cmbEncaminharCom.SelectedIndex != -1 && cmbProfissional.SelectedIndex != -1 
                   && !String.IsNullOrEmpty(txtProntuarioAluno.Text) && txtProntuarioAluno.Text.Length == 7 &&
                   !String.IsNullOrEmpty(txtDemanda.Text))
                {
                    btnConcluir.Enabled = true;
                }
                else
                {
                    btnConcluir.Enabled = false;
                }               
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
                cmbNomeAluno.Items.Clear();

                foreach (DataRow drow in bd.ConsultaNome("aluno").Rows)
                {
                    cmbNomeAluno.Items.Add(drow["NOME"].ToString());
                }

                cmbNomeAluno.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para preencher ComboBox 'Profissional'

        private void NomeProfissional()
        {
            try
            {
                Funcionario fun = new Funcionario();

                cmbProfissional.Items.Clear();

                if (fun.NomeFuncionarios(cmbEncaminharCom.SelectedItem.ToString()) != null)
                {
                    foreach (DataRow drow in fun.NomeFuncionarios(cmbEncaminharCom.SelectedItem.ToString()).Rows)
                    {
                        cmbProfissional.Items.Add(drow["NOME"].ToString());
                    }

                    cmbProfissional.Enabled = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "Não há nenhum servidor cadastrado com esse cargo", "Atenção", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                   
                    cmbProfissional.Enabled = false;
                }

                cmbNomeAluno.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para setar null campos que não forem preenchidos 

        private void VerificaNull()
        {

            if (String.IsNullOrEmpty(cmbDiaSemana.Text))
            {
                Dia = null;
            }
            else
            {
                Dia = cmbDiaSemana.SelectedItem.ToString();
            }

            if (String.IsNullOrEmpty(cmbTurno.Text))
            {
                Turno = null;
            }
            else
            {
                Turno = cmbTurno.SelectedItem.ToString();
            }
        }

        #endregion

        #region Método para enviar email de forma assíncrona 

        public async void EnviarEmail(string email, string form)
        {
            try
            {
                //Instância do Cliente Smtp
                SmtpClient smtp = new SmtpClient();

                //Utilize aqui um switch-case para os diversos tipos de emails (gmail, yahoo, outlook, etc)
                //Host = endereço do servidor smtp
                smtp.Host = "smtp.gmail.com";

                //Utilize aqui um switch-case para as portas de cada tipo de email
                //Port = porta que o servidor utiliza (padrão : 25) Gmail = 587;
                smtp.Port = 587;

                //EnableSsl, UseDefaultCredentials, Credentials servem para fazer a autenticação.
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("sasprojif@gmail.com", "ifprojsas123");

                //Instância do MailMessage
                MailMessage mail = new MailMessage();

                //From = indica endereço de email remetente
                mail.From = new MailAddress("sasprojif@gmail.com");

                //To = indica endereço de email destinatário
                mail.To.Add(new MailAddress(Email));

                if (form == "encaminhar")
                {
                    //Subject = indica o assunto do email
                    mail.Subject = "Novo atendimento encaminhado";

                    //Body = indica o corpo do email
                    mail.Body = "Olá, " + cmbProfissional.SelectedItem.ToString() + "\n\n" +
                                "Foi encaminhado um novo atendimento à você " +
                                "com o aluno " + cmbNomeAluno.SelectedItem.ToString() + " cujo prontuario é " +
                                txtProntuarioAluno.Text + ".\n" +
                                "Verifique a consulta de encaminhamentos quando logar no sistema SGSP Desktop." +
                                "\n\n" + "Att," + "\n" + "Grupo Desktop";
                                
                }
                else
                {
                    //Subject = indica o assunto do email
                    mail.Subject = "Sua emissão está pendente";

                    //Body = indica o corpo do email
                    mail.Body = "Olá,\n\nO status da sua última emissão está pendente.\n" +
                                "Defina a data da continuidade do atendimento e avise o aluno";
                }
                
                //SendMailAsync()  = Manda o email de forma assíncrona
                await smtp.SendMailAsync(mail);

                //Fechando o serviço 'MailMessage'
                mail.Dispose();

                //Fechando o serviço 'SmtpClient'
                smtp.Dispose();
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
                //TextBox
            txtProntuarioAluno.Text = null;
            txtDemanda.Text = null;

            if (cmbDiaSemana.SelectedIndex != -1)
            {
                cmbDiaSemana.SelectedIndex = -1;
            }

            if (cmbTurno.SelectedIndex != -1)
            {
                cmbTurno.SelectedIndex = -1;
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