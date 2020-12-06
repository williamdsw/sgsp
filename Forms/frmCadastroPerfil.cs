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
    public partial class frmCadastroPerfil : MetroForm
    {
        #region Variáveis

        private string _Codigo = null, _Entrada, _TipoPerfil;

        private int _IdModulo, _IdPerfil, _IdLogin;

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

        public frmCadastroPerfil()
        {
            InitializeComponent();
        }

        #region Evento que carrega itens no DataGridView (Load)

        private void frmCadastroPerfil_Load(object sender, EventArgs e)
        {
            dgvDados.AutoGenerateColumns = false;

            dgvDados.Columns[1].DataPropertyName = "NOME";

            dgvDados.DataSource = bd.ConsultaNome("modulo");
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

        #region Evento para cadastrar/atualizar permissões do perfil no banco (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //vou usar essas variáveis para facilitar a leitura do código abaixo.
                bool permissao = false;

                #region Cadastrar/Atualizar perfil

                if (Codigo == null)
                {
                    Perfil per = new Perfil(txtNomePerfil.Text, IdLogin, DateTime.Now);

                    MetroMessageBox.Show(this, per.Insere(txtNomePerfil.Text, IdLogin, DateTime.Now), 
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                    _IdPerfil = bd.GetID(txtNomePerfil.Text, "ID_PERFIL", "perfil");

                    //sempre que for necessário inserir dados de um Table para o banco,
                    //será necessário usar um for para inserir linha por linha
                    //aqui uso um Count - 1 para ignorar a última linha em branco do Table
                    for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                    {
                        permissao = Convert.ToBoolean(dgvDados.Rows[i].Cells[0].Value);     

                        _IdModulo = bd.GetID(dgvDados.Rows[i].Cells[1].Value.ToString(), "ID_MODULO", "modulo");

                        ModuloPerfil mdp = new ModuloPerfil(_IdModulo, _IdPerfil, permissao);

                        mdp.Insere(_IdModulo, _IdPerfil, permissao);
                    }
                }
                else
                {
                    _IdPerfil = bd.GetID(txtNomePerfil.Text, "ID_PERFIL", "perfil");

                    for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                    {
                        permissao = Convert.ToBoolean(dgvDados.Rows[i].Cells[0].Value);     

                        _IdModulo = bd.GetID(dgvDados.Rows[i].Cells[1].Value.ToString(), "ID_MODULO", "modulo");

                        ModuloPerfil mdp = new ModuloPerfil();

                        mdp.Altera(_IdModulo, permissao, _IdPerfil);
                    }

                    MetroMessageBox.Show(this, "Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
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
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento pra abrir aba ou tela de consulta quando fechar o Form (FormClosing)

        private void frmCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        con.IdLogin = this.IdLogin;

                        con.Consulta = "perfil";

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

        #region Método para limpar campos do formulário

        private void LimparCampos()
        {
            try
            {
                if (Codigo == null)
                {
                    txtNomePerfil.Text = null;
                }

                for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                {
                    dgvDados.Rows[i].Cells[0].Value = false;
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
