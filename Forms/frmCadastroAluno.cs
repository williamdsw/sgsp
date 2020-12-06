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
using System.Drawing.Imaging;       

namespace SGSP___Desktop
{
    public partial class frmCadastroAluno : MetroForm
    {
        #region Variáveis/Atributos

        private string _CaminhoImagem, _NomeImagem, _Pasta, _UF, _EstadoCivil,
               _Sexo, _Curso, _Turma, _Celular, _TelefoneFixo, _Cpf, _Cep,
                _Codigo = null, _Entrada, _TipoPerfil;

        private int _IdLogin;

        private int? _IdCurso, _IdTurma, _Idade;

        private DateTime? _DataNascimento;

        private bool _ImagemDaWebCam = false;

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

        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            NomeCurso();

            tmrRelogio.Start();
        }

        #endregion

        #region Evento para efetuar o cadastro do Aluno(a) (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //essa condição verifica se já criada, caso não, irá criar uma nova pasta.
                if (!String.IsNullOrEmpty(_CaminhoImagem))
                {
                    CriaPasta();
                }

                if (_ImagemDaWebCam == true)
                {
                    CriaPasta();
                }

                VerificaNull();

                #region Cadastrando ou atualizando os dados do Aluno(a)

                if (Codigo == null)
                {
                    //instanciando construtor da classe Aluno
                    Pessoa aluno = new Aluno(txtNome.Text, mskRG.Text, _Cpf, txtNaturalidade.Text,
                                             _UF, _EstadoCivil, _Sexo, txtNomeMae.Text, txtNomePai.Text,
                                             txtEndereco.Text, txtBairro.Text, _Cep, _TelefoneFixo,
                                             _Celular, txtEmail.Text, _Curso,
                                             _Turma, _CaminhoImagem, txtProntuario.Text,
                                             _Idade, _IdTurma,
                                             _DataNascimento, DateTime.Now, chkPAE.Checked,
                                             chkRepetente.Checked);

                    //instanciando o método Insere()
                    MetroMessageBox.Show(this, aluno.Insere(), "Sucesso", MessageBoxButtons.OK, 
                                         MessageBoxIcon.Question, 150);
                }
                else
                {
                    Pessoa aluno = new Aluno(txtNome.Text, mskRG.Text, _Cpf, txtNaturalidade.Text,
                                             _UF, _EstadoCivil, _Sexo, txtNomeMae.Text, txtNomePai.Text,
                                             txtEndereco.Text, txtBairro.Text, _Cep, _TelefoneFixo,
                                             _Celular, txtEmail.Text, _Curso,
                                             _Turma, _CaminhoImagem, txtProntuario.Text,
                                             _Idade, _IdTurma,
                                             _DataNascimento, DateTime.Now, chkPAE.Checked,
                                             chkRepetente.Checked);

                    MetroMessageBox.Show(this, aluno.Altera(), "Sucesso", MessageBoxButtons.OK,
                                         MessageBoxIcon.Question, 150);
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

        #region Evento pra fechar o Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Evento para carregar imagem no ptbImagem (Click)

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //filtro de arquivos
                ofdAbrir.Filter = "Arquivos de imagem(*.jpg;*.bmp;*.gif;*.png;)|*.jpg;*.bmp;*.gif;*.png;";

                //se o arquivo for escolhido
                if (ofdAbrir.ShowDialog() == DialogResult.OK)
                {
                    _CaminhoImagem = ofdAbrir.FileName;

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        _NomeImagem = Path.GetFileName(ofdAbrir.FileName);
                    }
                    else
                    {
                        _NomeImagem = txtNome.Text;
                    }

                    Bitmap imagem = new Bitmap(_CaminhoImagem);

                    ptbImagem.SizeMode = PictureBoxSizeMode.StretchImage;

                    ptbImagem.BackgroundImage = imagem;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para resetar imagem do ptbImagem (Click)

        private void tpsResetar_Click(object sender, EventArgs e)
        {
            if (Codigo == null)
            {
                ptbImagem.BackgroundImage = Properties.Resources.png_Aluno;
            }
        }

        #endregion

        #region Evento que faz a pesquisa do CEP no WebService dos Correios (Click)

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancia uma variável que recebe o método AtendeClienteClient()
                var webService = new WebServiceCorreios.AtendeClienteClient();

                /*Instancia uma variável de resposta que vai receber a resposta da consulta do
                número do CEP*/
                var resposta = webService.consultaCEP(mskCEP.Text);

                txtEndereco.Text = resposta.end + ", " + resposta.cidade + ", " + resposta.uf;
                txtBairro.Text = resposta.bairro;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para abrir tela de captura de tela da Webcam (Click)

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            try
            {
                //se não houver uma tela desse form já aberta, irá abrir uma
                if (Application.OpenForms["frmWebCam"] == null)
                {
                    frmWebCam frm = new frmWebCam();
                    frm.ShowDialog();

                    frm.Tipo = "aluno";

                    if (frm.ImagemSelecionada != null)
                    {
                        ptbImagem.BackgroundImage = frm.ImagemSelecionada;

                        if(!String.IsNullOrEmpty(txtNome.Text))
                        {
                            _NomeImagem = txtNome.Text + "_Foto" + ".png";
                        }
                        else
                        {
                            _NomeImagem = Path.GetRandomFileName() + ".png";
                        }

                        _ImagemDaWebCam = true;
                    }
                }
                else
                {
                    //senão, irá focar na qual já está aberta.
                    Application.OpenForms["frmWebCam"].Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para pegar a data (Click)

        private void btnData_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciei um objeto do tipo MonthCalendar
                MonthCalendar calendario = new MonthCalendar();

                //defino quem é o "pai" do objeto, nesse caso o gpbAgendar
                calendario.Parent = gpbDados;

                //defino qual será a localização do objeto
                calendario.Location = new Point(btnData.Location.X - 60, btnData.Location.Y);

                /* Se o texto do maskedBox Data for diferente do formato abaixo, o calendário irá mostrar na data já escolhida
                 * Senão, irá mostrar apartir da data atual
                */
                if (mskDataNascimento.Text != "  /  /" && mskDataNascimento.Text.Length == 10)
                {
                    calendario.SelectionStart = Convert.ToDateTime(mskDataNascimento.Text);
                }

                //Mostro o objeto na tela
                calendario.BringToFront();


                //Aqui criei um evento delegate para retornar a data escolhida no MaskedText
                calendario.DateSelected += delegate
                {
                    mskDataNascimento.Text = calendario.SelectionRange.Start.ToString();
                    calendario.Dispose();

                    txtIdade.Text = (DateTime.Today.Year - calendario.SelectionRange.Start.Year).ToString();                
                };

                calendario.MouseLeave += delegate
                {
                    calendario.Dispose();
                };
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para limpar campos (MouseUp)

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

                        ctmMenu.Show(650, 620);

                        break;
                }
            }
            catch (Exception ex)
            {      
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }    
        }

        #endregion

        #region Evento para delimitar caracteres no TextBox (KeyPress)

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //delimitando para usar Letras, tecla "Back" e "Space"
                e.Handled = !((char.IsLetter(e.KeyChar)) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //delimitando para usar digitos e tecla "Back"
                e.Handled = !((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void txtNomeMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !((char.IsLetter(e.KeyChar)) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void txtNomePai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !((char.IsLetter(e.KeyChar)) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        private void txtProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //delimitando para usar digitos e teclas "Back" e "X"
                e.Handled = !((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.X || e.KeyChar == (char)Keys.Back);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para pegar o ID do Curso e carregar os nomes das turmas (SelectedIndexChanged)

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdCurso = bd.GetID(cmbCurso.SelectedItem.ToString(), "ID_CURSO", "curso");

            NomeTurma();
        }

        #endregion

        #region Evento pra abrir aba ou tela de consulta quando fechar o Form (FormClosing)

        private void frmCadastroAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        con.IdLogin = this.IdLogin;

                        con.Consulta = "aluno";

                        con.TipoPerfil = this.TipoPerfil;

                        con.tspEmitir.Visible = false;

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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para verificar se os campos foram digitados e habilitar o botão (Tick)

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            try
            {
                //Aqui verifico se todos os campos obrigatórios estão preenchidos para habilitar o botão
                if (!String.IsNullOrEmpty(txtNome.Text) &&
                    !String.IsNullOrEmpty(txtProntuario.Text) &&
                    txtProntuario.Text.Length == 7)
                {
                    btnCadastrar.Enabled = true;
                }
                else
                {
                    btnCadastrar.Enabled = false;
                }

                //Verifico se o CEP foi preenchido corretamente para habilitar o botão Pesquisar
                if (mskCEP.Text.Length == 9)
                {
                    foreach (char letra in mskCEP.Text)
                    {
                        if (letra != '_')
                        {
                            btnPesquisar.Enabled = true;
                        }
                    }
                }
                else
                {
                    btnPesquisar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento para verificar se o aluno existe no banco ou não (TextChanged)

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Codigo == null)
                {
                    if (txtProntuario.Text.Length == 7)
                    {
                        if (bd.Verifica("PRONTUARIO", "aluno", txtProntuario.Text) == true)
                        {
                            MetroMessageBox.Show(this, "Esse aluno já existe!", "Atenção", 
                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning, 150);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para preencher ComboBox 'Curso' 

        private void NomeCurso()
        {
            try
            {
                cmbCurso.Items.Clear();

                foreach (DataRow drow in bd.ConsultaNome("curso").Rows)
                {
                    cmbCurso.Items.Add(drow["NOME"].ToString());
                }

                cmbCurso.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Método para preencher ComboBox 'Turma' 

        private void NomeTurma()
        {
            try
            {
                Turma tmr = new Turma();

                cmbTurma.Items.Clear();

                foreach (DataRow drow in tmr.NomeTurma(_IdCurso).Rows)
                {
                    cmbTurma.Items.Add(drow["NOME"].ToString());
                }

                cmbTurma.Refresh();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para criar pasta de imagens 

        private void CriaPasta()
        {
            try
            {
                //caminho que vai ser criada a pasta de Imagens
                _Pasta = @"C:\Users\william\Pictures\SGSP Imagens\Aluno";

                //nome do caminho da imagem à ser cadastrada
                string caminho = _Pasta + "\\" + _NomeImagem;

                //Se a pasta não existir, será criada uma nova.
                if (!Directory.Exists(_Pasta))
                {
                    Directory.CreateDirectory(_Pasta);
                }

                //Se a imagem for da web, será salvo a imagem do PictureBox,e o _caminhoImagem receberá o endereço dessa imagem
                if (_ImagemDaWebCam == true)
                {
                    //cria uma imagem usando a imagem do PictureBox
                    Image imagem = ptbImagem.BackgroundImage;

                    //Salva essa imagem no caminho e no formato .png
                    imagem.Save(caminho, ImageFormat.Png);

                    _CaminhoImagem = caminho;
                }
                else
                {
                    //Se o arquivo existir, ele será deletado e vai ser "criado" um novo.
                    if (File.Exists(caminho))
                    {
                        File.Delete(caminho);

                        File.Copy(ofdAbrir.FileName, caminho);
                    }
                    else
                    {
                        File.Copy(ofdAbrir.FileName, caminho);
                    }
                }
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
            #region TextBox

            if (String.IsNullOrEmpty(txtIdade.Text))
            {
                _Idade = null;
            }
            else
            {
                _Idade = Convert.ToInt16(txtIdade.Text);
            }

            #endregion

            #region MaskedTextBox

            if (mskDataNascimento.Text.Equals("  /  /"))
            {
                _DataNascimento = null;
            }
            else
            {
                _DataNascimento = Convert.ToDateTime(mskDataNascimento.Text);
            }

            if (mskCPF.Text.Equals("   ,   ,   -"))
            {
                _Cpf = null;
            }
            else
            {
                _Cpf = mskCPF.Text;
            }

            if (mskCelular.Text.Equals("(  )      -"))
            {
                _Celular = null;
            }
            else
            {
                _Celular = mskCelular.Text;
            }

            if (mskTelefoneFixo.Text.Equals("(  )     -"))
            {
                _TelefoneFixo = null;
            }
            else
            {
                _TelefoneFixo = mskTelefoneFixo.Text;
            }

            if (mskCEP.Text.Equals("     -"))
            {
                _Cep = null;
            }
            else
            {
                _Cep = mskCEP.Text;
            }

            #endregion

            #region ComboBox

            if (String.IsNullOrEmpty(cmbCurso.Text))
            {
                _Curso = null;
            }
            else
            {
                _Curso = cmbCurso.SelectedItem.ToString();
            }

            if (String.IsNullOrEmpty(cmbEstadoCivil.Text))
            {
                _EstadoCivil = null;
            }
            else
            {
                _EstadoCivil = cmbEstadoCivil.SelectedItem.ToString();
            }

            if (String.IsNullOrEmpty(cmbSexo.Text))
            {
                _Sexo = null;
            }
            else
            {
                _Sexo = cmbSexo.SelectedItem.ToString();
            }

            if (String.IsNullOrEmpty(cmbUF.Text))
            {
                _UF = null;
            }
            else
            {
                _UF = cmbUF.SelectedItem.ToString();
            }

            if (String.IsNullOrEmpty(cmbTurma.Text))
            {
                _Turma = null;

                _IdTurma = null;
            }
            else
            {
                _Turma = cmbTurma.SelectedItem.ToString();

                _IdTurma = bd.GetID(cmbTurma.SelectedItem.ToString(), "ID_TURMA", "turma");
            }

            #endregion
        }

        #endregion         

        #region Método para limpar campos do formulário

        private void LimparCampos()
        {
            try
            {
                #region TextBox

                txtBairro.Text = null; txtEmail.Text = null; txtEndereco.Text = null;
                txtIdade.Text = null; txtNaturalidade.Text = null; txtNome.Text = null;
                txtNomeMae.Text = null; txtNomePai.Text = null;

                if (txtProntuario.Enabled == true)
                {
                    txtProntuario.Text = null;
                }

                #endregion

                #region MaskedTextBox

                mskCelular.Text = null; mskCEP.Text = null; mskCPF.Text = null;
                mskDataNascimento.Text = null; mskRG.Text = null; mskTelefoneFixo.Text = null;

                #endregion

                #region ComboBox

                if (cmbEstadoCivil.SelectedIndex != -1)
                {
                    cmbEstadoCivil.SelectedIndex = -1;
                }

                if (cmbTurma.SelectedIndex != -1)
                {
                    cmbTurma.SelectedIndex = -1;
                }

                if (cmbSexo.SelectedIndex != -1)
                {
                    cmbSexo.SelectedIndex = -1;
                }

                if (cmbUF.SelectedIndex != -1)
                {
                    cmbUF.SelectedIndex = -1;
                }

                #endregion

                #region PictureBox

                ptbImagem.BackgroundImage = Properties.Resources.png_Aluno;

                #endregion

                #region CheckBox

                chkPAE.Checked = false; chkRepetente.Checked = false;

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
