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
    public partial class frmCadastrarOutros : MetroForm
    {
        #region Variáveis

        private string _Codigo = null, _Entrada, _Tipo, _TipoPerfil;

        private int _IdCurso, _IdLogin;

        private int? _AnoInicio, _Semestre, _NumeroAlunos;

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

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
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

        public frmCadastrarOutros()
        {
            InitializeComponent();
        }

        #region Evento que carrega configurações e dados (Load)

        private void frmCadastrarOutros_Load(object sender, EventArgs e)
        {
            gpbTurma.Enabled = false;

            NomeCurso();

            tmrRelogio.Start();

            ctmMenu.Font = new Font("Open Sans Light", 11);

            if (TipoPerfil == "Parcial")
            {
                gpbModulo.Enabled = false;
            }    
        }

        #endregion

        #region Evento para realizar cadastro do módulo (Click)

        private void btnCadastrarModulo_Click(object sender, EventArgs e)
        {
            try
            {
                #region Cadastrando ou atualizando o Módulo

                if (Codigo == null)
                {
                    Modulo mod = new Modulo(txtNomeModulo.Text, cmbPlataforma.SelectedItem.ToString(),
                                            DateTime.Now);

                    MetroMessageBox.Show(this, mod.Insere(txtNomeModulo.Text, cmbPlataforma.SelectedItem.ToString(),
                                            DateTime.Now), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                }
                else
                {
                    Modulo mod = new Modulo();

                    MetroMessageBox.Show(this, mod.Altera(Codigo, txtNomeModulo.Text, cmbPlataforma.SelectedItem.ToString()),
                                         "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
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

        #region Evento para realizar cadastro do curso (Click)

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaNull();

                #region Cadastrar ou atualizar curso

                if (Codigo == null)
                {
                    Curso cso = new Curso(txtNomeCurso.Text, cmbPeriodo.SelectedItem.ToString(),
                                          txtNivel.Text, DateTime.Now);

                    MetroMessageBox.Show(this, cso.Insere(txtNomeCurso.Text, cmbPeriodo.SelectedItem.ToString(), 
                                        txtNivel.Text, DateTime.Now), "Sucesso", MessageBoxButtons.OK, 
                                        MessageBoxIcon.Question, 150);

                    NomeCurso();
                }
                else
                {
                    Curso cso = new Curso();

                    MetroMessageBox.Show(this, cso.Altera(Codigo, txtNomeCurso.Text, txtNivel.Text,
                                        cmbPeriodo.SelectedItem.ToString()), "Sucesso", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning, 150);

                    NomeCurso();
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

        #region Evento para realizar cadastro da turma (Click)

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaNull();

                #region Cadastrando ou atualizando turma

                _IdCurso = bd.GetID(cmbCurso.SelectedItem.ToString(), "ID_CURSO", "curso");

                if (Codigo == null)
                {
                    Turma tma = new Turma(txtNomeTurma.Text, cmbCurso.SelectedItem.ToString(), txtTempoDuracao.Text,
                                          _AnoInicio, _Semestre, _NumeroAlunos, _IdCurso, DateTime.Now);

                    MetroMessageBox.Show(this, tma.Insere(txtNomeTurma.Text, cmbCurso.SelectedItem.ToString(),
                                         txtTempoDuracao.Text, _AnoInicio, _Semestre, _NumeroAlunos, _IdCurso, DateTime.Now),
                                         "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);
                }
                else
                {
                    Turma tma = new Turma();

                    MetroMessageBox.Show(this, tma.Altera(Codigo, txtNomeTurma.Text, cmbCurso.SelectedItem.ToString(), 
                                         txtTempoDuracao.Text, _AnoInicio, _Semestre, _NumeroAlunos, _IdCurso),
                                         "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
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

        #region Evento para fechar Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para apagar campos por "blocos" (Click)

        private void tspModulo_Click(object sender, EventArgs e)
        {
            //TextBox
            txtNomeModulo.Text = null;

            //ComboBox
            if (cmbPlataforma.SelectedIndex != -1)
            {
                cmbPlataforma.SelectedIndex = -1;
            }
        }

        private void tspCurso_Click(object sender, EventArgs e)
        {
            txtNomeCurso.Text = null;
            txtNivel.Text = null;

            if (cmbPeriodo.SelectedIndex != -1)
            {
                cmbPeriodo.SelectedIndex = -1;
            }
        }

        private void tspTurma_Click(object sender, EventArgs e)
        {
            txtNomeTurma.Text = null; txtAnoInicio.Text = null; txtNumeroAlunos.Text = null;
            txtSemestre.Text = null; txtTempoDuracao.Text = null;

            if (cmbCurso.SelectedIndex != -1)
            {
                cmbCurso.SelectedIndex = -1;
            }
        }

        #endregion

        #region Evento para apagar todos os campos (MouseUp)

        private void btnLimpar_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:

                        LimparCampos();

                        break;

                    case MouseButtons.Right:

                        ctmMenu.Show(Cursor.Position);

                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }          
        }

        #endregion

        #region Evento pra abrir aba ou tela de consulta quando fechar o Form (FormClosing)

        private void frmCadastrarOutros_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        switch (Tipo)
                        {
                            #region Modulo 

                            case "modulo":

                                frmConsulta con = new frmConsulta();

                                con.IdLogin = this.IdLogin;

                                con.Consulta = "modulo";

                                con.tspEmitir.Visible = false;
                                con.tspExportar.Visible = false;
                                con.tspHistorico.Visible = false;

                                con.Show();

                                con.TipoPerfil = this.TipoPerfil;

                                break;

                            #endregion

                            #region Curso 

                            case "curso":

                                frmConsulta css = new frmConsulta();

                                css.IdLogin = this.IdLogin;

                                css.Consulta = "curso";

                                css.TipoPerfil = this.TipoPerfil;

                                css.tspEmitir.Visible = false;
                                css.tspExportar.Visible = false;
                                css.tspHistorico.Visible = false;

                                css.Show();

                                break;

                            #endregion

                            #region Turma 

                            case "turma":

                                frmConsulta cst = new frmConsulta();

                                cst.IdLogin = this.IdLogin;

                                cst.Consulta = "turma";

                                cst.TipoPerfil = this.TipoPerfil;

                                cst.tspEmitir.Visible = false;
                                cst.tspExportar.Visible = false;
                                cst.tspHistorico.Visible = false;

                                cst.Show();

                                break;

                            #endregion
                        }
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
                //Módulo
                if (!String.IsNullOrEmpty(txtNomeModulo.Text) &&
                    cmbPlataforma.SelectedIndex != -1)
                {
                    btnCadastrarModulo.Enabled = true;
                }
                else
                {
                    btnCadastrarModulo.Enabled = false;
                }

                //Curso
                if (!String.IsNullOrEmpty(txtNomeCurso.Text) &&
                    cmbPeriodo.SelectedIndex != -1)
                {
                    btnCadastrarCurso.Enabled = true;
                }
                else
                {
                    btnCadastrarCurso.Enabled = false;
                }

                //Turma
                if (!String.IsNullOrEmpty(txtNomeTurma.Text) &&
                    cmbCurso.SelectedIndex != -1)
                {
                    btnCadastrarTurma.Enabled = true;
                }
                else
                {
                    btnCadastrarTurma.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        //-----------------------------------------Método--------------------------------------//

        #region Método para preencher ComboBox 'Curso'

        private void NomeCurso()
        {
            try
            {
                cmbCurso.Items.Clear();

                foreach (DataRow drow in bd.ConsultaNome("curso").Rows)
                {
                    cmbCurso.Items.Add(drow["NOME"].ToString());

                    gpbTurma.Enabled = true;
                }

                cmbCurso.Refresh();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para setar null campos que não forem preenchidos 

        private void VerificaNull()
        {
            if (String.IsNullOrEmpty(txtNumeroAlunos.Text))
            {
                _NumeroAlunos = null;
            }
            else
            {
                _NumeroAlunos = Convert.ToInt16(txtNumeroAlunos.Text);
            }

            if (String.IsNullOrEmpty(txtSemestre.Text))
            {
                _Semestre = null;
            }
            else
            {
                _Semestre = Convert.ToInt16(txtSemestre.Text);
            }

            if (String.IsNullOrEmpty(txtAnoInicio.Text))
            {
                _AnoInicio = null;
            }
            else
            {
                _AnoInicio = Convert.ToInt16(txtAnoInicio.Text);
            }
        }

        #endregion

        #region Método para limpar campos do formulário

        private void LimparCampos()
        {
            try
            {
                #region TextBox

                txtNomeModulo.Text = null; txtNomeCurso.Text = null; txtNomeTurma.Text = null;
                txtAnoInicio.Text = null; txtNumeroAlunos.Text = null; txtNivel.Text = null;
                txtSemestre.Text = null; txtTempoDuracao.Text = null;

                #endregion

                #region ComboBox

                if (cmbPeriodo.SelectedIndex != -1)
                {
                    cmbPeriodo.SelectedIndex = -1;
                }

                if (cmbPlataforma.SelectedIndex != -1)
                {
                    cmbPlataforma.SelectedIndex = -1;
                }

                if (cmbCurso.SelectedIndex != -1)
                {
                    cmbCurso.SelectedIndex = -1;
                }

                #endregion
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion
    }
}
