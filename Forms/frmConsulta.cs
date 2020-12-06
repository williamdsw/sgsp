using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
//--
using System.Drawing;   
using System.Linq;      
using System.Text;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;   
using iTextSharp.text;  
using iTextSharp.text.pdf;  
using System.IO; 


namespace SGSP___Desktop
{
    public partial class frmConsulta : MetroForm
    {
        #region Variáveis

        private string _CaminhoFoto, _Consulta = null, _TipoPerfil;

        private int _IdLogin;

        private string[] permissao = new string[22];

        #endregion

        #region Encapsuladores

        public string Consulta
        {
            get { return _Consulta; }
            set { _Consulta = value; }
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

        #region Instância de classes

        Banco bd = new Banco();

        Notificacao nt = new Notificacao();

        EmissaoAtendimento ea = new EmissaoAtendimento();

        #endregion

        //-----------------------------------------Eventos-----------------------------------//

        public frmConsulta()
        {
            InitializeComponent();
        }

        #region Evento que carrega os dados e outros itens (Load)

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Preenche();

            MudarHeader();

            if (Consulta == "emissao")
            {
                btnEditar.Text = "Editar Status";
            }

            if(Consulta != "aluno")
            {
                tspHistorico.Visible = false;
            }

            if(Consulta != "encaminhamento")
            {
                tspEmitir.Visible = false;
            }

            Controle();

            dgvDados.RowEnter += delegate
            {
                VerificaStatus();
            };
        }

        #endregion

        #region Evento para abrir tela de cadastro (Click)

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreencheCampos("Novo");
        }

        #endregion

        #region Evento para abrir tela de atualização (Click)

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PreencheCampos("Editar");
        }

        #endregion

        #region Evento para excluir registros (Click)

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();

            DefineDataSource();
        }

        #endregion

        #region Evento para aparecer tela de dados (Click)

        private void tspDados_Click(object sender, EventArgs e)
        {
            PreencheCampos("Dados");
        }

        #endregion

        #region Evento para exportar dados para o Excel (Click)

        private void tspExcel_Click(object sender, EventArgs e)
        {
            switch (Consulta)
            {
                case "aluno":

                    GerarExcel(Consulta);

                    break;

                case "emissao":

                    GerarExcel(Consulta);

                    break;

                case "funcionario":

                    GerarExcel(Consulta);

                    break;
            }
        }

        #endregion

        #region Evento para exportar dados para PDF (Click)

        private void tspPDF_Click(object sender, EventArgs e)
        {
            string nomeArquivo = dgvDados.SelectedRows[0].Cells[0].Value.ToString() + " - " + dgvDados.SelectedRows[0].Cells[1].Value.ToString() + ".pdf";

            GerarPDF(nomeArquivo);
        }

        #endregion

        #region Evento para aparecer o histórico do aluno (Click)

        private void tpsHistorico_Click(object sender, EventArgs e)
        {
            try
            {
                if (ea.HistoricoAluno(dgvDados.SelectedRows[0].Cells[0].Value.ToString()).Rows.Count > 0)
                {
                    frmConsulta frm = new frmConsulta();

                    frm.Consulta = "historico";

                    frm.IdLogin = this.IdLogin;

                    frm.TipoPerfil = this.TipoPerfil;

                    frm.btnDeletar.Visible = false;
                    frm.btnEditar.Visible = false;
                    frm.btnNovo.Visible = false;

                    frm.dgvDados.DataSource = ea.HistoricoAluno(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                    frm.dgvDados.Refresh();

                    frm.tspHistorico.Visible = false;

                    frm.ShowDialog();
                }
                else
                {
                    MetroMessageBox.Show(this, "O aluno não tem histórico de atendimentos.\nPara emitir um atendimento, vá em \"Gerenciar Atendimentos\" > \"Emitir Atendimento\".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error, 130);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para emitir o atendimento agendado (Click)

        private void tpsEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmissaoAtendimento frm = new frmEmissaoAtendimento();

                frm.Entrada = "consulta";

                frm.TipoPerfil = this.TipoPerfil;

                frm.IdLogin = this.IdLogin;

                //idencaminhamento = Cells[0]
                //prontuarioFuncionario = cells[1]

                //text
                frm.txtProntuarioAluno.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                frm.txtRelato.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();

                //agendarCom = cells[4]
                //nomeProfissional = cells[5]
                //dataCadastro = Cells[6]

                frm.IdLogin = this.IdLogin; //cells[7]

                //dia = cells[8]
                //turno = cells[9]

                //promptText
                string nomeAluno = bd.GetNome("PRONTUARIO", frm.txtProntuarioAluno.Text, "aluno").ToString();

                frm.Show();

                if(frm.cmbAluno.Items.Contains(nomeAluno))
                {
                    frm.cmbAluno.SelectedItem = nomeAluno;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para habilitar o txtPesquisar (SelectedIndexChanged)

        private void cmbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbParametro.SelectedItem.ToString()))
            {
                txtPesquisar.Enabled = true;
            }
        }

        #endregion

        #region Evento para limpar o TxtPesquisar (Enter)

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        #endregion

        #region Evento para preencher o txtPesquisar (Leave)

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Text = "Pesquisar";

                DefineDataSource();
            }
        }

        #endregion

        #region Evento para filtrar o DataGridView (TextChanged)

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string parametro = cmbParametro.SelectedItem.ToString();

                switch (Consulta)
                {
                    case "aluno":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("aluno", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "funcionario":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("funcionarios", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "perfil":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("perfil", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "usuario":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("login", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "modulo":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("modulo", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "curso":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("curso", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "turma":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("turma", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "encaminhamento":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("agendamento", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "emissao":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("emissao_atendimento", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "notificacoes":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("notificacoes", parametro, txtPesquisar.Text);
                        }

                        break;

                    case "notificacoes novas":

                        if (!String.IsNullOrEmpty(txtPesquisar.Text))
                        {
                            dgvDados.DataSource = bd.Filtra("notificacoes", parametro, txtPesquisar.Text);
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para abrir o menu do botão direito do mouse (MouseUp)

        private void dgvDados_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ctmMenu.Show(Cursor.Position);
            }
        }

        #endregion


        //---------------------------------Métodos-----------------------------------------//

        #region Método para preencher DataGrid, ComboBox, e redimensionar as colunas

        private void Preenche()
        {
            try
            {
                switch (Consulta)
                {
                    #region Aluno 

                    case "aluno":

                        DefineDataSource();

                        Text = "Consulta de Alunos";

                        //aqui estou preenchendo o comoBox com o Enumerador (não é mais necessário)
                        //cmbParametro.DataSource = Enum.GetNames(typeof(Aluno.Tabelas));

                        cmbParametro.DataSource = bd.NomeColunas("aluno");

                        dgvDados.Columns[4].Width = 150;
                        dgvDados.Columns[5].Width = 150;
                        dgvDados.Columns[14].Width = 150;
                        dgvDados.Columns[15].Width = 150;
                        dgvDados.Columns[21].Width = 150;
                        dgvDados.Columns[22].Width = 150;

                        break;

                    #endregion

                    #region Funcionário 

                    case "funcionario":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("funcionarios");

                        Text = "Consulta de Servidores";

                        dgvDados.Columns[2].Width = 150;
                        dgvDados.Columns[3].Width = 150;
                        dgvDados.Columns[13].Width = 150;
                        dgvDados.Columns[14].Width = 150;
                        dgvDados.Columns[15].Width = 150;
                        dgvDados.Columns[18].Width = 150;
                        dgvDados.Columns[19].Width = 150;

                        break;

                    #endregion

                    #region Perfil 

                    case "perfil":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("perfil");

                        Text = "Consulta de Perfis";

                        foreach (DataGridViewColumn col in dgvDados.Columns)
                        {
                            col.Width = 190;
                        }

                        break;

                    #endregion

                    #region Usuário 

                    case "usuario":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("login");

                        Text = "Consulta de Usuários";

                        foreach (DataGridViewColumn col in dgvDados.Columns)
                        {
                            col.Width = 125;
                        }

                        break;

                    #endregion

                    #region Módulo 

                    case "modulo":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("modulo");

                        Text = "Consulta de Módulos";

                        foreach (DataGridViewColumn col in dgvDados.Columns)
                        {
                            col.Width = 190;
                        }

                        break;

                    #endregion

                    #region Curso 

                    case "curso":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("curso");

                        Text = "Consulta de Cursos";

                        foreach (DataGridViewColumn col in dgvDados.Columns)
                        {
                            col.Width = 150;
                        }

                        break;

                    #endregion

                    #region Turma 

                    case "turma":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("turma");

                        Text = "Consulta de Turmas";

                        dgvDados.Columns[4].Width = 150;
                        dgvDados.Columns[6].Width = 150;
                        dgvDados.Columns[7].Width = 150;

                        break;

                    #endregion

                    #region encaminhamento 

                    case "encaminhamento":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("agendamento");

                        Text = "Consulta de Encaminhamentos";

                        dgvDados.Columns[1].Width = 150;
                        dgvDados.Columns[2].Width = 150;
                        dgvDados.Columns[5].Width = 150;
                        dgvDados.Columns[6].Width = 150;

                        break;

                    #endregion

                    #region Emissão

                    case "emissao": case "historico":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("emissao_atendimento");

                        if (Consulta == "emissao")
                        {
                            Text = "Consulta de Emissões";
                        }
                        else
                        {
                            Text = "Histórico do aluno";
                        }

                        dgvDados.Columns[6].Width = 150;
                        dgvDados.Columns[7].Width = 150;

                        break;

                    #endregion

                    #region Notificações

                    case "notificacoes":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("notificacoes");

                        Text = "Consulta de Notificações recebidas";

                        break;

                    #endregion

                    #region Notificações novas
                        
                    case "notificacoes novas":

                        DefineDataSource();

                        cmbParametro.DataSource = bd.NomeColunas("notificacoes");

                        Text = "Consulta de Notificações novas";

                        break;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para preencher e abrir telas

        private void PreencheCampos(string nomeBotao)
        {
            try
            {
                switch (Consulta)
                {
                    #region Parâmeros do Aluno

                    case "aluno":
                        {
                            frmCadastroAluno frm = new frmCadastroAluno();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização dos dados do(a) Aluno(a)";

                                        frm.btnCadastrar.Text = "Atualizar";

                                        frm.txtProntuario.Enabled = false;

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados do Aluno";

                                        frm.btnCadastrar.Visible = false;
                                        frm.btnCarregar.Visible = false;
                                        frm.btnLimpar.Visible = false;
                                        frm.btnPesquisar.Visible = false;
                                        frm.btnWebcam.Visible = false;

                                        break;
                                }

                                //propriedades Text recebem ToString();
                                frm.txtProntuario.Text = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                                frm.txtNome.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();

                                //propriedades Checked recebem Value convertido para booleano
                                frm.chkPAE.Checked = Convert.ToBoolean(dgvDados.SelectedRows[0].Cells[2].Value);

                                //text
                                frm.txtNaturalidade.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                                frm.mskRG.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                                frm.mskCPF.Text = dgvDados.SelectedRows[0].Cells[5].Value.ToString();

                                //propriedades SelectedItem recebem Value
                                frm.cmbUF.SelectedItem = dgvDados.SelectedRows[0].Cells[6].Value;
                                frm.cmbEstadoCivil.SelectedItem = dgvDados.SelectedRows[0].Cells[7].Value;
                                frm.cmbSexo.SelectedItem = dgvDados.SelectedRows[0].Cells[8].Value;

                                //text
                                frm.txtNomePai.Text = dgvDados.SelectedRows[0].Cells[9].Value.ToString();
                                frm.txtNomeMae.Text = dgvDados.SelectedRows[0].Cells[10].Value.ToString();
                                frm.txtEndereco.Text = dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                                frm.txtBairro.Text = dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                                frm.mskCEP.Text = dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                                frm.mskTelefoneFixo.Text = dgvDados.SelectedRows[0].Cells[14].Value.ToString();
                                frm.mskCelular.Text = dgvDados.SelectedRows[0].Cells[15].Value.ToString();
                                frm.txtEmail.Text = dgvDados.SelectedRows[0].Cells[16].Value.ToString();

                                _CaminhoFoto = dgvDados.SelectedRows[0].Cells[19].Value.ToString();

                                //text
                                frm.txtIdade.Text = dgvDados.SelectedRows[0].Cells[20].Value.ToString();
                                frm.mskDataNascimento.Text = dgvDados.SelectedRows[0].Cells[21].Value.ToString();

                                //checked
                                frm.chkRepetente.Checked = Convert.ToBoolean(dgvDados.SelectedRows[0].Cells[23].Value.ToString());

                                //dataCadastro = Cells[22], idTurma = Cells[24], IdLogin = Cells[25]

                                if (!String.IsNullOrEmpty(_CaminhoFoto))
                                {
                                    frm.ptbImagem.BackgroundImage = Bitmap.FromFile(_CaminhoFoto);
                                }
                                else
                                {
                                    frm.ptbImagem.BackgroundImage = Properties.Resources.png_Aluno;
                                }

                                frm.Show();

                                frm.cmbCurso.SelectedItem = dgvDados.SelectedRows[0].Cells[17].Value;
                                frm.cmbTurma.SelectedItem = dgvDados.SelectedRows[0].Cells[18].Value;

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros do Funcionário

                    case "funcionario":
                        {
                            frmCadastroFuncionario frm = new frmCadastroFuncionario();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização dos dados do(a) Servidor(a)";

                                        frm.btnCadastrar.Text = "Atualizar";

                                        frm.txtProntuario.Enabled = false;

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados do(a) Servidor(a)";

                                        frm.btnCadastrar.Visible = false;
                                        frm.btnCarregar.Visible = false;
                                        frm.btnLimpar.Visible = false;
                                        frm.btnPesquisar.Visible = false;
                                        frm.btnWebcam.Visible = false;

                                        break;
                                }

                                //text
                                frm.txtProntuario.Text = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
                                frm.txtNome.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                                frm.mskRG.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                                frm.mskCPF.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                                frm.txtNaturalidade.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();

                                //selected item
                                frm.cmbUF.SelectedItem = dgvDados.SelectedRows[0].Cells[5].Value;
                                frm.cmbEstadoCivil.SelectedItem = dgvDados.SelectedRows[0].Cells[6].Value;
                                frm.cmbSexo.SelectedItem = dgvDados.SelectedRows[0].Cells[7].Value;
                                frm.cmbCargo.SelectedItem = dgvDados.SelectedRows[0].Cells[8].Value;

                                //text
                                frm.txtEmail.Text = dgvDados.SelectedRows[0].Cells[9].Value.ToString();

                                //selected item
                                frm.cmbTurno.SelectedItem = dgvDados.SelectedRows[0].Cells[10].Value;

                                //text

                                frm.txtEndereco.Text = dgvDados.SelectedRows[0].Cells[11].Value.ToString();
                                frm.txtBairro.Text = dgvDados.SelectedRows[0].Cells[12].Value.ToString();
                                frm.mskCEP.Text = dgvDados.SelectedRows[0].Cells[13].Value.ToString();
                                frm.mskTelefoneFixo.Text = dgvDados.SelectedRows[0].Cells[14].Value.ToString();
                                frm.mskCelular.Text = dgvDados.SelectedRows[0].Cells[15].Value.ToString();
                                _CaminhoFoto = dgvDados.SelectedRows[0].Cells[16].Value.ToString();
                                frm.txtIdade.Text = dgvDados.SelectedRows[0].Cells[17].Value.ToString();
                                frm.mskDataNascimento.Text = dgvDados.SelectedRows[0].Cells[18].Value.ToString();

                                //dataCadastro = Cells[19], IdLogin = Cells[20]

                                if (!String.IsNullOrEmpty(_CaminhoFoto))
                                {
                                    frm.ptbImagem.BackgroundImage = Bitmap.FromFile(_CaminhoFoto);
                                }
                                else
                                {
                                    frm.ptbImagem.BackgroundImage = Properties.Resources.png_Funcionario;
                                }

                                frm.Show();

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros do Perfil

                    case "perfil":
                        {
                            ModuloPerfil mp = new ModuloPerfil();

                            frmCadastroPerfil frm = new frmCadastroPerfil();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização de Perfil";

                                        frm.btnCadastrar.Text = "Atualizar";

                                        frm.txtNomePerfil.Enabled = false;

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados de Perfil";

                                        frm.btnCadastrar.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                frm.txtNomePerfil.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();

                                int idPerfil = bd.GetID(dgvDados.SelectedRows[0].Cells[1].Value.ToString(),
                                                        "ID_PERFIL", "PERFIL");

                                List<string> permissao = mp.ListaPermissoes(idPerfil);

                                frm.Show();

                                //depois do Show, preencho os elementos da tabela com os valores da lista das permissões
                                //esse é um jeito de preencher um table de outra tela sem dar erros
                                //usando um vetor para preencher outro vetor/matriz
                                for (int i = 0; i < frm.dgvDados.Rows.Count - 1; i++)
                                {
                                    frm.dgvDados.Rows[i].Cells[0].Value = permissao[i];
                                }

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros do Usuário

                    case "usuario":
                        {
                            frmCadastroUsuario frm = new frmCadastroUsuario();

                            frm.Entrada = "consulta";

                            frm.IdUser = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização do Usuário";

                                        frm.txtProntuario.Enabled = false;
                                        frm.btnCadastrar.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados do Usuário";

                                        frm.btnCadastrar.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                //text
                                frm.txtProntuario.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                                frm.txtSenha.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                                frm.txtConfirmeSenha.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();

                                //selectedItem
                                frm.cmbStatus.SelectedItem = dgvDados.SelectedRows[0].Cells[3].Value;

                                //IdLogin = Cells[0], idPerfil = Cells[6]

                                frm.Show();

                                //
                                frm.cmbPerfil.SelectedItem = dgvDados.SelectedRows[0].Cells[4].Value;

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros do Módulo

                    case "modulo":
                        {
                            frmCadastrarOutros frm = new frmCadastrarOutros();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            frm.Tipo = "modulo";

                            if (nomeBotao == "Novo")
                            {
                                frm.Text = "Cadastro de Módulo";

                                frm.gpbCurso.Enabled = false;
                                frm.gpbTurma.Enabled = false;
                                frm.btnCadastrarTurma.Enabled = false;

                                frm.Show();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização de Módulo";

                                        frm.btnCadastrarModulo.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados de Módulo";

                                        frm.btnCadastrarModulo.Visible = false;
                                        frm.btnCadastrarCurso.Visible = false;
                                        frm.btnCadastrarTurma.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                frm.gpbCurso.Enabled = false;
                                frm.gpbTurma.Enabled = false;
                                frm.btnCadastrarTurma.Enabled = false;

                                //text
                                frm.txtNomeModulo.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();

                                //selectedItem
                                frm.cmbPlataforma.SelectedItem = dgvDados.SelectedRows[0].Cells[4].Value;

                                //idModulo = Cells[0], sigla = cells[2], dataCadastro = Cells[3]

                                frm.Show();

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros do Curso

                    case "curso":
                        {
                            frmCadastrarOutros frm = new frmCadastrarOutros();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            frm.Tipo = "curso";

                            if (nomeBotao == "Novo")
                            {
                                frm.Text = "Cadastro de Curso";

                                frm.gpbModulo.Enabled = false;
                                frm.gpbTurma.Enabled = false;
                                frm.btnCadastrarTurma.Enabled = false;

                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização de Curso";

                                        frm.btnCadastrarCurso.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados de Curso";

                                        frm.btnCadastrarModulo.Visible = false;
                                        frm.btnCadastrarCurso.Visible = false;
                                        frm.btnCadastrarTurma.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                frm.gpbModulo.Enabled = false;
                                frm.gpbTurma.Enabled = false;
                                frm.btnCadastrarTurma.Enabled = false;

                                //text
                                frm.txtNomeCurso.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();

                                //selectedItem
                                frm.cmbPeriodo.SelectedItem = dgvDados.SelectedRows[0].Cells[2].Value;

                                //text
                                frm.txtNivel.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();

                                //idCurso = Cells[0], dataCadastro = Cells[4]

                                frm.Show();

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros da Turma

                    case "turma":
                        {
                            frmCadastrarOutros frm = new frmCadastrarOutros();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            frm.Tipo = "turma";

                            if (nomeBotao == "Novo")
                            {
                                frm.Text = "Cadastro de Turma";

                                frm.gpbModulo.Enabled = false;
                                frm.gpbCurso.Enabled = false;

                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização da Turma";

                                        frm.btnCadastrarTurma.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados de Turma";

                                        frm.btnCadastrarModulo.Visible = false;
                                        frm.btnCadastrarCurso.Visible = false;
                                        frm.btnCadastrarTurma.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                frm.gpbModulo.Enabled = false;
                                frm.gpbCurso.Enabled = false;

                                //text
                                frm.txtNomeTurma.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();

                                //text
                                frm.txtAnoInicio.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                                frm.txtSemestre.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                                frm.txtTempoDuracao.Text = dgvDados.SelectedRows[0].Cells[5].Value.ToString();
                                frm.txtNumeroAlunos.Text = dgvDados.SelectedRows[0].Cells[7].Value.ToString();

                                //idModulo = Cells[0], //dataCadastro = Cells[6], idCurso = Cells[8]

                                frm.Show();

                                //selectedItem
                                frm.cmbCurso.SelectedItem = dgvDados.SelectedRows[0].Cells[2].Value;

                                this.Close();
                            }
                        }

                        break;

                    #endregion

                    #region Parâmetros do Encaminhamento

                    case "encaminhamento":
                        {
                            frmEncaminharAtendimento frm = new frmEncaminharAtendimento();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização do Encaminhamento";

                                        frm.btnConcluir.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados de Encaminhamento";

                                        frm.btnConcluir.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                //idencaminhamento = Cells[0]
                                //prontuarioFuncionario = cells[1]
                                //dataCadastro = Cells[6]

                                //text
                                frm.txtProntuarioAluno.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                                frm.txtDemanda.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();

                                //selectedItem
                                frm.cmbEncaminharCom.SelectedItem = dgvDados.SelectedRows[0].Cells[4].Value;
                                frm.cmbProfissional.SelectedItem = dgvDados.SelectedRows[0].Cells[5].Value;
                                frm.cmbDiaSemana.SelectedItem = dgvDados.SelectedRows[0].Cells[8].Value;
                                frm.cmbTurno.SelectedItem = dgvDados.SelectedRows[0].Cells[9].Value;

                                //cells[5] = nome profissional

                                frm.IdLogin = this.IdLogin; //cells[7]

                                string nome = bd.GetNome("PRONTUARIO", frm.txtProntuarioAluno.Text, "ALUNO").ToString();

                                frm.Show();

                                //Coloquei depois do Show() porque o comboBox já estará preenchido
                                if (frm.cmbNomeAluno.Items.Contains(nome))
                                {
                                    frm.cmbNomeAluno.SelectedItem = nome;
                                }

                                this.Close();
                            }
                        }

                        break;

                    #endregion

                    #region Parâmetros da Emissão

                    case "emissao": case "historico":
                        {
                            frmEmissaoAtendimento frm = new frmEmissaoAtendimento();

                            frm.Entrada = "consulta";

                            frm.IdLogin = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();

                                break;
                            }
                            else
                            {
                                frm.Codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                                switch (nomeBotao)
                                {
                                    case "Editar":

                                        frm.Text = "Atualização do Status da Emissão";

                                        frm.tbcAbas.DisableTab(frm.tabDados);
                                        frm.tbcAbas.DisableTab(frm.tabRelato);
                                        frm.txtProvidencias.Enabled = false;

                                        //Seleciona a tab "Providências" quando iniciar a tela
                                        frm.tbcAbas.SelectTab(2);

                                        frm.btnConcluir.Text = "Atualizar";

                                        break;

                                    case "Dados":

                                        frm.Text = "Dados da Emissão";

                                        frm.btnConcluir.Visible = false;
                                        frm.btnLimpar.Visible = false;

                                        break;
                                }

                                //idEmissao = Cells[0] 

                                //text
                                frm.txtRequerente.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
                                frm.txtRelato.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                                frm.txtProvidencias.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
                                frm.txtProntuarioAluno.Text = dgvDados.SelectedRows[0].Cells[6].Value.ToString();

                                //selected item
                                frm.cmbStatus.SelectedItem = dgvDados.SelectedRows[0].Cells[5].Value;

                                //frm.txtProntuarioRequerente.Text = dgvDados.SelectedRows[0].Cells[7].Value.ToString();

                                frm.Show();

                                frm.cmbAluno.SelectedItem = dgvDados.SelectedRows[0].Cells[1].Value;

                                this.Close();
                            }
                        }
                        break;

                    #endregion

                    #region Parâmetros da Notificação

                    case "notificacoes":
                        {
                            int idNotificacao = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                            frmEnviarNotificacao frm = new frmEnviarNotificacao();

                            frm.Entrada = "consulta";

                            frm.IdRemetente = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Text = "Dados da Notificação";

                                frm.btnEnviar.Visible = false;
                                frm.btnLimpar.Visible = false;

                                //text
                                frm.txtAssunto.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                                frm.txtMensagem.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();

                                //selectedItem
                                frm.cmbPrioridade.SelectedItem = dgvDados.SelectedRows[0].Cells[3].Value;

                                string idDestinatario = dgvDados.SelectedRows[0].Cells[6].Value.ToString();

                                string destinatario = bd.GetNome("ID_LOGIN", idDestinatario, "funcionarios");

                                //idNotificacao = Cells[0], visualizaçao = cells[4], idRemetente = cells[5]

                                frm.Show();

                                //verifico se no comboBox já tem o item desejado, para depois selecioná-lo.
                                if (frm.cmbPara.Items.Contains(destinatario))
                                {
                                    frm.cmbPara.SelectedItem = destinatario;
                                }

                                nt.Altera(idNotificacao);

                                this.Close();
                            }
                        }

                        break;

                    #endregion

                    #region Parâmetros da Notificação Nova

                    case "notificacoes novas":
                        {
                            int idN = Convert.ToInt16(dgvDados.SelectedRows[0].Cells[0].Value.ToString());

                            frmEnviarNotificacao frm = new frmEnviarNotificacao();

                            frm.Entrada = "consulta nova";

                            frm.IdRemetente = this.IdLogin;

                            frm.TipoPerfil = this.TipoPerfil;

                            if (nomeBotao == "Novo")
                            {
                                frm.Show();

                                this.Close();
                            }
                            else
                            {
                                frm.Text = "Dados da Notificação";

                                frm.btnEnviar.Visible = false;
                                frm.btnLimpar.Visible = false;

                                //text
                                frm.txtAssunto.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
                                frm.txtMensagem.Text = dgvDados.SelectedRows[0].Cells[2].Value.ToString();

                                //selectedItem
                                frm.cmbPrioridade.SelectedItem = dgvDados.SelectedRows[0].Cells[3].Value;

                                string idDestinatario = dgvDados.SelectedRows[0].Cells[6].Value.ToString();

                                string destinatario = bd.GetNome("ID_LOGIN", idDestinatario, "funcionarios");

                                //idNotificacao = Cells[0], visualizaçao = cells[4], idRemetente = cells[5]

                                frm.Show();

                                //verifico se no comboBox já tem o item desejado, para depois selecioná-lo.
                                if (frm.cmbPara.Items.Contains(destinatario))
                                {
                                    frm.cmbPara.SelectedItem = destinatario;
                                }

                                nt.Altera(idN);

                                this.Close();
                            }
                        }

                        break;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para excluir registro

        private void ExcluirRegistro()
        {
            try
            {
                string codigo = dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                var opcao = MetroMessageBox.Show(this, "Tem certeza?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (opcao == DialogResult.Yes)
                {
                    switch (Consulta)
                    {
                        case "aluno":

                            MetroMessageBox.Show(this, bd.Apaga("aluno", "PRONTUARIO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "funcionario":

                            MetroMessageBox.Show(this, bd.Apaga("funcionarios", "PRONTUARIO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "perfil":

                            bd.Apaga("modulo_perfil", "ID_PERFIL", codigo);

                            MetroMessageBox.Show(this, bd.Apaga("perfil", "ID_PERFIL", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "usuario":

                            MetroMessageBox.Show(this, bd.Apaga("login", "ID_LOGIN", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "modulo":

                            MetroMessageBox.Show(this, bd.Apaga("modulo", "ID_MODULO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "curso":

                            MetroMessageBox.Show(this, bd.Apaga("curso", "ID_CURSO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "turma":

                            MetroMessageBox.Show(this, bd.Apaga("turma", "ID_TURMA", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "encaminhamento":

                            MetroMessageBox.Show(this, bd.Apaga("agendamento", "ID_AGENDAMENTO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "emissao":

                            MetroMessageBox.Show(this, bd.Apaga("emissao_atendimento", "ID_EMISSAO", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "notificacoes":

                            MetroMessageBox.Show(this, bd.Apaga("notificacoes", "ID", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;

                        case "notificacoes novas":

                            MetroMessageBox.Show(this, bd.Apaga("notificacoes", "ID", codigo), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question, 150);

                            break;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Operação cancelada pelo usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para definir data source do DataGrid

        private void DefineDataSource()
        {
            try
            {
                Notificacao not = new Notificacao();

                switch (Consulta)
                {
                    case "aluno":

                        dgvDados.DataSource = bd.Consulta("aluno");
                        dgvDados.Refresh();

                        break;

                    case "funcionario":

                        dgvDados.DataSource = bd.Consulta("funcionarios");
                        dgvDados.Refresh();

                        break;

                    case "perfil":

                        dgvDados.DataSource = bd.Consulta("perfil");
                        dgvDados.Refresh();

                        break;

                    case "usuario":

                        dgvDados.DataSource = bd.Consulta("login");
                        dgvDados.Refresh();

                        break;

                    case "modulo":

                        dgvDados.DataSource = bd.Consulta("modulo");
                        dgvDados.Refresh();

                        break;

                    case "curso":

                        dgvDados.DataSource = bd.Consulta("curso");
                        dgvDados.Refresh();

                        break;

                    case "turma":

                        dgvDados.DataSource = bd.Consulta("turma");
                        dgvDados.Refresh();

                        break;

                    case "encaminhamento":

                        dgvDados.DataSource = bd.Consulta("agendamento");
                        dgvDados.Refresh();

                        break;

                    case "emissao":

                        dgvDados.DataSource = bd.Consulta("emissao_atendimento");
                        dgvDados.Refresh();

                        break;

                    case "notificacoes":

                        dgvDados.DataSource = not.Notificacoes(IdLogin);
                        dgvDados.Refresh();

                        break;

                    case "notificacoes novas":

                        dgvDados.DataSource = not.NotificacoesNovas(IdLogin);
                        dgvDados.Refresh();

                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para mudar nome dos cabeçalhos da tabela

        private void MudarHeader()
        {
            try
            {
                switch (Consulta)
                {
                    #region Aluno 

                    case "aluno":

                        dgvDados.Columns[0].HeaderText = "Prontuário";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "Utiliza o PAE?";
                        dgvDados.Columns[3].HeaderText = "Naturalidade";
                        dgvDados.Columns[4].HeaderText = "RG";
                        dgvDados.Columns[5].HeaderText = "CPF";
                        dgvDados.Columns[6].HeaderText = "UF";
                        dgvDados.Columns[7].HeaderText = "Estado Cívil";
                        dgvDados.Columns[8].HeaderText = "Sexo";
                        dgvDados.Columns[9].HeaderText = "Nome do pai";
                        dgvDados.Columns[10].HeaderText = "Nome da mãe";
                        dgvDados.Columns[11].HeaderText = "Endereço";
                        dgvDados.Columns[12].HeaderText = "Bairro";
                        dgvDados.Columns[13].HeaderText = "CEP";
                        dgvDados.Columns[14].HeaderText = "Telefone Fixo";
                        dgvDados.Columns[15].HeaderText = "Celular";
                        dgvDados.Columns[16].HeaderText = "Email";
                        dgvDados.Columns[17].HeaderText = "Curso";
                        dgvDados.Columns[18].HeaderText = "Turma";
                        dgvDados.Columns[19].HeaderText = "Caminho da foto";
                        dgvDados.Columns[20].HeaderText = "Idade";
                        dgvDados.Columns[21].HeaderText = "Data de Nascimento";
                        dgvDados.Columns[22].HeaderText = "Data de Cadastro";
                        dgvDados.Columns[23].HeaderText = "É repetente?";
                        dgvDados.Columns[24].HeaderText = "ID Turma";
                        dgvDados.Columns[25].HeaderText = "ID Login";

                        break;

                    #endregion

                    #region Funcionário 

                    case "funcionario":

                        dgvDados.Columns[0].HeaderText = "Prontuário";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "RG";
                        dgvDados.Columns[3].HeaderText = "CPF";
                        dgvDados.Columns[4].HeaderText = "Naturalidade";
                        dgvDados.Columns[5].HeaderText = "UF";
                        dgvDados.Columns[6].HeaderText = "Estado Cívil";
                        dgvDados.Columns[7].HeaderText = "Sexo";
                        dgvDados.Columns[8].HeaderText = "Cargo";
                        dgvDados.Columns[9].HeaderText = "Email";
                        dgvDados.Columns[10].HeaderText = "Turno";
                        dgvDados.Columns[11].HeaderText = "Endereço";
                        dgvDados.Columns[12].HeaderText = "Bairro";
                        dgvDados.Columns[13].HeaderText = "CEP";
                        dgvDados.Columns[14].HeaderText = "Telefone Fixo";
                        dgvDados.Columns[15].HeaderText = "Celular";
                        dgvDados.Columns[16].HeaderText = "Caminho da foto";
                        dgvDados.Columns[17].HeaderText = "Idade";
                        dgvDados.Columns[18].HeaderText = "Data de Nascimento";
                        dgvDados.Columns[19].HeaderText = "Data de Cadastro";
                        dgvDados.Columns[20].HeaderText = "ID Login";

                        break;

                    #endregion

                    #region Perfil 

                    case "perfil":

                        dgvDados.Columns[0].HeaderText = "ID do Perfil";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "Data de Cadastro";
                        dgvDados.Columns[3].HeaderText = "ID do Login";

                        break;

                    #endregion

                    #region Usuário 

                    case "usuario":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Prontuário";
                        dgvDados.Columns[2].HeaderText = "Senha";
                        dgvDados.Columns[3].HeaderText = "Status";
                        dgvDados.Columns[4].HeaderText = "Perfil";

                        break;

                    #endregion

                    #region Módulo 

                    case "modulo":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].Visible = false; //SIGLA
                        dgvDados.Columns[3].HeaderText = "Data de cadastro";
                        dgvDados.Columns[4].HeaderText = "Plataforma";

                        break;

                    #endregion

                    #region Curso 

                    case "curso":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "Período";
                        dgvDados.Columns[3].HeaderText = "Nível";
                        dgvDados.Columns[4].HeaderText = "Data de Cadastro";

                        break;

                    #endregion

                    #region Turma 

                    case "turma":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Nome";
                        dgvDados.Columns[2].HeaderText = "Curso";
                        dgvDados.Columns[3].HeaderText = "Ano de ínicio";
                        dgvDados.Columns[4].HeaderText = "Semestre ingresso";
                        dgvDados.Columns[5].HeaderText = "Duração";
                        dgvDados.Columns[6].HeaderText = "Data de Cadastro";
                        dgvDados.Columns[7].HeaderText = "Número de Alunos";
                        dgvDados.Columns[8].HeaderText = "ID do Curso";

                        break;

                    #endregion

                    #region Encaminhamento 

                    case "encaminhamento":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Prontuário do Funcionário";
                        dgvDados.Columns[2].HeaderText = "Prontuário do Aluno";
                        dgvDados.Columns[3].HeaderText = "Demanda";
                        dgvDados.Columns[4].HeaderText = "Profissional requisitado";
                        dgvDados.Columns[5].HeaderText = "Nome do profissional";
                        dgvDados.Columns[6].HeaderText = "Data de Cadastro";
                        dgvDados.Columns[7].HeaderText = "Dia desejado";
                        dgvDados.Columns[8].HeaderText = "Turno desejado";

                        break;

                    #endregion

                    #region Emissão 

                    case "emissao": case "historico":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Encaminhado";
                        dgvDados.Columns[2].HeaderText = "Requerente";
                        dgvDados.Columns[3].HeaderText = "Relato";
                        dgvDados.Columns[4].HeaderText = "Providências";
                        dgvDados.Columns[5].HeaderText = "Status";
                        dgvDados.Columns[6].HeaderText = "Prontuário do Aluno";
                        dgvDados.Columns[7].Visible = false;

                        break;

                    #endregion

                    #region Notificacoes 

                    case "notificacoes":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Assunto";
                        dgvDados.Columns[2].HeaderText = "Mensagem";
                        dgvDados.Columns[3].HeaderText = "Prioridade";
                        dgvDados.Columns[4].HeaderText = "Foi visualizado?";
                        dgvDados.Columns[5].HeaderText = "ID do Remetente";
                        dgvDados.Columns[6].HeaderText = "Id do Destinatário";
                        dgvDados.Columns[7].HeaderText = "Data de Cadastro";

                        break;

                    #endregion

                    #region Notificacoes Novas 

                    case "notificacoes novas":

                        dgvDados.Columns[0].HeaderText = "ID";
                        dgvDados.Columns[1].HeaderText = "Assunto";
                        dgvDados.Columns[2].HeaderText = "Mensagem";
                        dgvDados.Columns[3].HeaderText = "Prioridade";
                        dgvDados.Columns[4].HeaderText = "Foi visualizado?";
                        dgvDados.Columns[5].HeaderText = "ID do Remetente";
                        dgvDados.Columns[6].HeaderText = "Id do Destinatário";
                        dgvDados.Columns[7].HeaderText = "Data de Cadastro";

                        break;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para definir controle dos objetos do form de acordo com o perfil do usuário

        private void Controle()
        {
            switch(TipoPerfil)
            {
                case "Total":            

                    if(Consulta == "encaminhamento")
                    {
                        btnEditar.Enabled = false;
                    }

                    btnDeletar.Enabled = false;

                    break;

                case "Parcial":

                    if (btnEditar.Text != "Editar Status")
                    {
                        btnEditar.Enabled = false;
                    }

                    btnDeletar.Enabled = false;

                    break;
            }
        }

        #endregion

        #region Método para gerar arquivo de Excel

        private void GerarExcel(string consulta)
        {
            try
            {
                //cria um objeto do tipo Application do Excel
                Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();

                //Adiciona o tipo de "página" do excel
                Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);

                Worksheet ws = (Worksheet)xla.ActiveSheet;

                //Mostra o arquivo no excel
                xla.Visible = true;

                //cria uma pasta e seta o endereço dela
                string pasta = null;
               
                CriaPasta(out pasta,  "\\Excel");

                switch (Consulta)
                {
                    case "aluno":
                        {
                            ws.Cells[1, 9] = "Dados do Aluno";      //título

                            #region Dados Pessoais

                            ws.Cells[3, 3] = "Pessoais";            //header

                            int c = 1;

                            ws.Cells[5, c] = "Nome";
                            ws.Cells[6, c] = "RG";
                            ws.Cells[7, c] = "CPF";
                            ws.Cells[8, c] = "Data de Nascimento";
                            ws.Cells[9, c] = "Idade";
                            ws.Cells[10, c] = "Naturalidade";
                            ws.Cells[11, c] = "UF";
                            ws.Cells[12, c] = "Estado Civil";
                            ws.Cells[13, c] = "Sexo";
                            ws.Cells[14, c] = "Nome da Mãe";
                            ws.Cells[15, c] = "Nome do Pai";

                            c = 4;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[1].Value.ToString();    //nome
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[4].Value.ToString();    //rg
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[5].Value.ToString();    //cpf
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[21].Value.ToString();   //nascimento
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[20].Value.ToString();   //idade
                            ws.Cells[10, c] = dgvDados.SelectedRows[0].Cells[3].Value.ToString();   //naturalidade
                            ws.Cells[11, c] = dgvDados.SelectedRows[0].Cells[6].Value.ToString(); //uf
                            ws.Cells[12, c] = dgvDados.SelectedRows[0].Cells[7].Value.ToString(); //estado civil
                            ws.Cells[13, c] = dgvDados.SelectedRows[0].Cells[8].Value.ToString(); //sexo
                            ws.Cells[14, c] = dgvDados.SelectedRows[0].Cells[10].Value.ToString(); //mãe
                            ws.Cells[15, c] = dgvDados.SelectedRows[0].Cells[9].Value.ToString(); //pai

                            #endregion

                            #region Dados de Contato

                            ws.Cells[3, 10] = "Contato";            //header

                            c = 8;

                            ws.Cells[5, c] = "Endereço ";
                            ws.Cells[6, c] = "Bairro ";
                            ws.Cells[7, c] = "CEP";
                            ws.Cells[8, c] = "Telefone Fixo ";
                            ws.Cells[9, c] = "Celular ";
                            ws.Cells[10, c] = "Email  ";

                            c = 11;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[11].Value.ToString(); //endereço
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[12].Value.ToString(); // bairro
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[13].Value.ToString(); //cep
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[14].Value.ToString(); //tel fixo
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[15].Value.ToString(); //celular
                            ws.Cells[10, c] = dgvDados.SelectedRows[0].Cells[16].Value.ToString(); //email

                            #endregion

                            #region Dados Escolares

                            ws.Cells[3, 17] = "Escolares";            //header

                            c = 15;

                            ws.Cells[5, c] = "Prontuário ";
                            ws.Cells[6, c] = "Utiliza o PAE? ";
                            ws.Cells[7, c] = "É Repetente? ";
                            ws.Cells[8, c] = "Curso ";
                            ws.Cells[9, c] = "Turma ";
                            ws.Cells[10, c] = "Data de Cadastro ";

                            c = 18;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[0].Value.ToString(); //prontuario

                            if (dgvDados.SelectedRows[0].Cells[2].Value.Equals(true)) //pae
                            {
                                ws.Cells[6, c] = "Sim";
                            }
                            else
                            {
                                ws.Cells[6, c] = "Não";
                            }

                            if (dgvDados.SelectedRows[0].Cells[23].Value.Equals(true)) //repetente
                            {
                                ws.Cells[7, c] = "Sim";
                            }
                            else
                            {
                                ws.Cells[7, c] = "Não";
                            }

                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[17].Value.ToString(); //curso
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[18].Value.ToString(); //turma
                            ws.Cells[10, c] = dgvDados.SelectedRows[0].Cells[22].Value.ToString(); //data cadastro

                            #endregion
                        }

                        break;

                    case "emissao":
                        {
                            ws.Cells[1, 9] = "Dados do Atendimento";      //título

                            #region Dados dos Participantes

                            ws.Cells[3, 3] = "Dados";            //header

                            int c = 1;

                            ws.Cells[5, c] = "Nome do Aluno";
                            ws.Cells[6, c] = "Prontuário do Aluno";
                            ws.Cells[7, c] = "Nome do Requerente";
                            ws.Cells[8, c] = "Prontuário do Requerente";
                            ws.Cells[9, c] = "Código do Atendimento";

                            c = 4;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[1].Value.ToString();    //nome aluno
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[6].Value.ToString();    //prontuario aluno
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[2].Value.ToString();    //nome funcionario
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[7].Value.ToString();   //prontuario funcionario
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[0].Value.ToString();   //id do atendimento

                            #endregion

                            #region Dados do Relato

                            ws.Cells[12, 3] = "Dados do relato";            //header

                            ws.Cells[15, c] = "Relato ";

                            ws.Cells[16, c] = dgvDados.SelectedRows[0].Cells[3].Value.ToString(); //relato

                            #endregion

                            #region Dados das Providências

                            ws.Cells[18, 3] = "Dados das Providências";            //header

                            ws.Cells[20, c] = "Providências ";
                            ws.Cells[21, c] = "Status ";

                            c = 4;

                            ws.Cells[20, c] = dgvDados.SelectedRows[0].Cells[4].Value.ToString(); //providências
                            ws.Cells[20, c] = dgvDados.SelectedRows[0].Cells[5].Value.ToString(); //status

                            #endregion
                        }

                        break;

                    case "funcionario":
                        {
                            ws.Cells[1, 9] = "Dados do(a) Servidor(a)";      //título

                            #region Dados Pessoais

                            ws.Cells[3, 3] = "Pessoais";            //header

                            int c = 1;

                            ws.Cells[5, c] = "Nome";
                            ws.Cells[6, c] = "RG";
                            ws.Cells[7, c] = "CPF";
                            ws.Cells[8, c] = "Data de Nascimento";
                            ws.Cells[9, c] = "Idade";
                            ws.Cells[10, c] = "Naturalidade";
                            ws.Cells[11, c] = "Estado Civil";
                            ws.Cells[12, c] = "Sexo";

                            c = 4;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[1].Value.ToString();    //nome
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[2].Value.ToString();    //rg
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[3].Value.ToString();    //cpf
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[18].Value.ToString();   //nascimento
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[17].Value.ToString();   //idade
                            ws.Cells[10, c] = dgvDados.SelectedRows[0].Cells[4].Value.ToString();   //naturalidade
                            ws.Cells[11, c] = dgvDados.SelectedRows[0].Cells[6].Value.ToString(); //estado civil
                            ws.Cells[12, c] = dgvDados.SelectedRows[0].Cells[7].Value.ToString(); //sexo

                            #endregion

                            #region Dados de Contato

                            ws.Cells[3, 10] = "Contato";            //header

                            c = 8;

                            ws.Cells[5, c] = "Endereço ";
                            ws.Cells[6, c] = "Bairro ";
                            ws.Cells[7, c] = "UF";
                            ws.Cells[8, c] = "CEP";
                            ws.Cells[9, c] = "Telefone Fixo ";
                            ws.Cells[10, c] = "Celular ";
                            ws.Cells[11, c] = "Email  ";

                            c = 11;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[11].Value.ToString(); //endereço
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[12].Value.ToString(); // bairro
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[5].Value.ToString(); // uf
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[13].Value.ToString(); //cep
                            ws.Cells[9, c] = dgvDados.SelectedRows[0].Cells[14].Value.ToString(); //tel fixo
                            ws.Cells[10, c] = dgvDados.SelectedRows[0].Cells[15].Value.ToString(); //celular
                            ws.Cells[11, c] = dgvDados.SelectedRows[0].Cells[9].Value.ToString(); //email

                            #endregion

                            #region Dados Empresa

                            ws.Cells[3, 17] = "IFSP";            //header

                            c = 15;

                            ws.Cells[5, c] = "Prontuário ";
                            ws.Cells[6, c] = "Cargo";
                            ws.Cells[7, c] = "Turno";
                            ws.Cells[8, c] = "Data de Cadastro";

                            c = 18;

                            ws.Cells[5, c] = dgvDados.SelectedRows[0].Cells[0].Value.ToString(); //prontuario
                            ws.Cells[6, c] = dgvDados.SelectedRows[0].Cells[8].Value.ToString(); //cargo
                            ws.Cells[7, c] = dgvDados.SelectedRows[0].Cells[10].Value.ToString(); //turno
                            ws.Cells[8, c] = dgvDados.SelectedRows[0].Cells[19].Value.ToString(); //data cadastro

                            #endregion
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para gerar arquivo PDF

        private void GerarPDF(string nomeArquivo)
        {
            try
            {
                //cria um objeto do tipo Document com tamanho da folha A4
                Document documento = new Document(PageSize.A4);

                //espaçamentos de margens do documento
                documento.SetMargins(40, 40, 40, 80);

                //adicionando as configurações
                documento.AddCreationDate();

                //adiciona o cabeçalho do arquivo
                documento.AddHeader("Nome", "Dados do aluno");

                //cria uma pasta e seta o endereço
                string pasta = null;

                CriaPasta(out pasta, "\\PDF");

                string caminho = pasta + "\\" + nomeArquivo;

                //cria o arquivo PDF
                PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));

                //abre o arquivo
                documento.Open();

                switch (_Consulta)
                {
                    case "aluno":
                        {
                            #region Dados Pessoais

                            string dadosPessoais = "\nNome : " + dgvDados.SelectedRows[0].Cells[1].Value.ToString() +
                                                   "\nRG: " + dgvDados.SelectedRows[0].Cells[4].Value.ToString() + 
                                                   "\nCPF: " + dgvDados.SelectedRows[0].Cells[5].Value.ToString() +
                                                   "\nData de nascimento: " + dgvDados.SelectedRows[0].Cells[21].Value.ToString() + 
                                                   "\nIdade: " + dgvDados.SelectedRows[0].Cells[20].Value.ToString() + 
                                                   "\nNaturalidade: " + dgvDados.SelectedRows[0].Cells[3].Value.ToString() + 
                                                   "\nEstado: " + dgvDados.SelectedRows[0].Cells[6].Value.ToString() + 
                                                   "\nEstado civil: " + dgvDados.SelectedRows[0].Cells[7].Value.ToString() + 
                                                   "\nSexo: " + dgvDados.SelectedRows[0].Cells[8].Value.ToString() + 
                                                   "\nNome do pai: " + dgvDados.SelectedRows[0].Cells[9].Value.ToString() + 
                                                   "\nNome da mãe: " + dgvDados.SelectedRows[0].Cells[10].Value.ToString();

                            Paragraph pessoais = new Paragraph(dadosPessoais);

                            #endregion

                            #region Dados de contato

                            string dadosContato = "\nEndereço: " + dgvDados.SelectedRows[0].Cells[11].Value.ToString() +
                                                  "\nBairro: " + dgvDados.SelectedRows[0].Cells[12].Value.ToString() +
                                                  "\nCEP: " + dgvDados.SelectedRows[0].Cells[13].Value.ToString() +
                                                  "\nTelefone Fixo" + dgvDados.SelectedRows[0].Cells[14].Value.ToString() +
                                                  "\nCelular: " + dgvDados.SelectedRows[0].Cells[15].Value.ToString() +
                                                  "\nEmail: " + dgvDados.SelectedRows[0].Cells[16].Value.ToString();

                            Paragraph contato = new Paragraph(dadosContato);

                            #endregion

                            #region Dados Escolares

                            string dadosEscolares = "\nProntuário: " + dgvDados.SelectedRows[0].Cells[0].Value.ToString() +
                                                    "\nCurso: " + dgvDados.SelectedRows[0].Cells[17].Value.ToString() +
                                                    "\nTurma: " + dgvDados.SelectedRows[0].Cells[18].Value.ToString() +
                                                    "\nData de Cadastro: " + dgvDados.SelectedRows[0].Cells[22].Value.ToString();

                            Paragraph pae = new Paragraph();
                            Paragraph repetente = new Paragraph();

                            if (dgvDados.SelectedRows[0].Cells[2].Value.Equals(true)) //pae
                            {
                                pae = new Paragraph("\nUtiliza o Pae? Sim");
                            }
                            else
                            {
                                pae = new Paragraph("\nUtiliza o Pae? Não");
                            }

                            if (dgvDados.SelectedRows[0].Cells[23].Value.Equals(true)) //repetente
                            {
                                repetente = new Paragraph("\nÉ repetente? Sim");
                            }
                            else
                            {
                                repetente = new Paragraph("\nÉ repetente? Não");
                            }

                            Paragraph escolares = new Paragraph(dadosEscolares);

                            #endregion

                            #region Método que adiciona os parágrafos

                            documento.Add(pessoais);
                            documento.Add(contato);
                            documento.Add(escolares);
                            documento.Add(pae);
                            documento.Add(repetente);

                            #endregion
                        }

                        break;

                    case "emissao":
                        {
                            #region Dados dos Participantes

                            string dadosParticipantes = "Nome do Aluno : " + dgvDados.SelectedRows[0].Cells[1].Value.ToString() +
                                                        "Prontuário do Aluno : " + dgvDados.SelectedRows[0].Cells[6].Value.ToString() +
                                                        "Nome do Requerente : " + dgvDados.SelectedRows[0].Cells[2].Value.ToString() +
                                                        "Prontuário do Requerente : " + dgvDados.SelectedRows[0].Cells[7].Value.ToString() +
                                                        "Código do Atendimento : " + dgvDados.SelectedRows[0].Cells[0].Value.ToString();

                            Paragraph participantes = new Paragraph(dadosParticipantes);

                            #endregion

                            #region Dados do relato

                            string dadosRelato = "Relato : " + dgvDados.SelectedRows[0].Cells[3].Value.ToString();
                                                      
                            Paragraph relato = new Paragraph(dadosRelato);

                            #endregion

                            #region Dados das providências

                            string dadosProvidencias = "Providências : " + dgvDados.SelectedRows[0].Cells[4].Value.ToString() +
                                             "Status : " + dgvDados.SelectedRows[0].Cells[5].Value.ToString();

                            Paragraph providencias = new Paragraph(dadosProvidencias);

                            #endregion

                            #region Método que adiciona os parágrafos

                            documento.Add(participantes);
                            documento.Add(relato);
                            documento.Add(providencias);

                            #endregion
                        }

                        break;


                    case "funcionario":
                        {
                            #region Dados Pessoais

                            string dadosPessoais = "Nome : " + dgvDados.SelectedRows[0].Cells[1].Value.ToString() +
                                                   "RG : " + dgvDados.SelectedRows[0].Cells[2].Value.ToString() +
                                                   "CPF : " + dgvDados.SelectedRows[0].Cells[3].Value.ToString() +
                                                   "Data de Nascimento : " + dgvDados.SelectedRows[0].Cells[18].Value.ToString() +
                                                   "Idade : " + dgvDados.SelectedRows[0].Cells[17].Value.ToString() +
                                                   "Naturalidade : " + dgvDados.SelectedRows[0].Cells[4].Value.ToString() +
                                                   "Estado Civil : " + dgvDados.SelectedRows[0].Cells[6].Value.ToString() +
                                                   "Sexo : " + dgvDados.SelectedRows[0].Cells[7].Value.ToString();

                            Paragraph pessoais = new Paragraph(dadosPessoais);

                            #endregion

                            #region Dados de contato

                            string dadosContato = "Endereço: " + dgvDados.SelectedRows[0].Cells[11].Value.ToString() +
                                                  "Bairro: " + dgvDados.SelectedRows[0].Cells[12].Value.ToString() +
                                                  "CEP: " + dgvDados.SelectedRows[0].Cells[13].Value.ToString() +
                                                  "Telefone Fixo" + dgvDados.SelectedRows[0].Cells[14].Value.ToString() +
                                                  "Celular: " + dgvDados.SelectedRows[0].Cells[15].Value.ToString() +
                                                  "Email: " + dgvDados.SelectedRows[0].Cells[16].Value.ToString();

                            Paragraph contato = new Paragraph(dadosContato);

                            #endregion

                            #region Dados Empresa

                            string dadosEmpresas = "Prontuário: " + dgvDados.SelectedRows[0].Cells[0].Value.ToString() +
                                             "Cargo: " + dgvDados.SelectedRows[0].Cells[8].Value.ToString() +
                                             "Turno: " + dgvDados.SelectedRows[0].Cells[10].Value.ToString() +
                                             "Data de Cadastro: " + dgvDados.SelectedRows[0].Cells[19].Value.ToString();

                            Paragraph empresas = new Paragraph(dadosEmpresas);



                            #endregion

                            #region Método que adiciona os parágrafos

                            documento.Add(pessoais);
                            documento.Add(contato);
                            documento.Add(empresas);

                            #endregion
                        }

                        break;
                }

                documento.Close();

                var opcao = MetroMessageBox.Show(this, "Abrir o arquivo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if(opcao == DialogResult.Yes)
                {
                    //Abre o arquivo PDF pelo método Start() da classe Process
                    System.Diagnostics.Process.Start(caminho);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Método para criar pasta de relatórios

        private void CriaPasta(out string pasta, string tipo)
        {
            try
            {
                string _Pasta = null;

                switch (Consulta)
                {
                    case "aluno":

                        //caminho que vai ser criada a pasta de Imagens
                        _Pasta = @"C:\Users\william\Documents\SGSP Documentos" + tipo + "\\Alunos";

                        break;

                    case "emissao":

                        _Pasta = @"C:\Users\william\Documents\SGSP Documentos" + tipo + "\\Relatorios";

                        break;

                    case "funcionario":

                        _Pasta = @"C:\Users\william\Documents\SGSP Documentos" + tipo + "\\Servidores";

                        break;
                }

                //Se a pasta não existir, será criada uma nova.
                if (!Directory.Exists(_Pasta))
                {
                    Directory.CreateDirectory(_Pasta);
                }

                pasta = _Pasta;
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);

                pasta = null;
            }
        }

        #endregion

        #region Método para verificar o "Editar Status" e habilitar/desabilitar caso estiver "Encerrado"

        private void VerificaStatus()
        {
            try
            {
                if (Consulta == "emissao")
                {
                    //Status
                    if (dgvDados.SelectedRows[0].Cells[5].Value.ToString() == "Encerrado")
                    {
                        btnEditar.Enabled = false;
                    }
                    else
                    {
                        btnEditar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);          
            }
        }

        #endregion
    }
}
