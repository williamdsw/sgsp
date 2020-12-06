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
    public partial class frmCadastroFuncionario : MetroForm
    {
        #region Variáveis

        private string _CaminhoImagem, _NomeImagem, _Pasta, _EstadoCivil, _Sexo, _UF, _Cargo,
               _Turno, _Celular, _TelefoneFixo, _Cpf, _Cep, _Codigo, _Entrada, _TipoPerfil;

        private Image _Imagem;

        private int _IdLogin;

        private int? _Idade;

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

        public Image Imagem
        {
            get { return _Imagem; }
            set
            {
                _Imagem = value;
                ptbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbImagem.BackgroundImage = _Imagem;
            }
        }

        #endregion

        //-----------------------------------------Eventos--------------------------------------//

        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        #region Evento para carregar itens (Load)

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            tmrRelogio.Start();
        }

        #endregion

        #region Evento para efetuar o cadastro do Funcionário(a) (Click)

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //se o caminho da imgem não for nulo, irá criar a pasta
                if (!String.IsNullOrEmpty(_CaminhoImagem))
                {
                    CriaPasta();
                }

                //se a imagem for da webcam, irá criar a pasta
                if (_ImagemDaWebCam == true)
                {
                    CriaPasta();
                }

                //verifica os campos nulos
                VerificaNull();

                #region Cadastrando ou atualizando os dados do Funcionário(a)

                if (Codigo == null)
                {
                    //instanciando construtor da classe Funcionário
                    Pessoa funcionario = new Funcionario(txtNome.Text, mskRG.Text, _Cpf, txtNaturalidade.Text, _UF,
                                                              _EstadoCivil, _Sexo, _Cargo, _Turno, txtEndereco.Text, txtBairro.Text,
                                                              _Cep, _TelefoneFixo, _Celular,
                                                              txtEmail.Text, _CaminhoImagem, txtProntuario.Text, _Idade,
                                                              _DataNascimento, DateTime.Now);

                    //instanciando o método Insere()
                    MetroMessageBox.Show(this, funcionario.Insere(), "Sucesso", MessageBoxButtons.OK, 
                                         MessageBoxIcon.Question, 150);

                    var opcao = MetroMessageBox.Show(this, "Deseja criar um usuário para o(a) servidor(a)?", "Criar usuário", 
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, 150);


                    if (opcao == DialogResult.Yes)
                    {
                        frmCadastroUsuario user = new frmCadastroUsuario();

                        //passando valores...
                        user.IdUser = this.IdLogin;

                        user.txtProntuario.Text = this.txtProntuario.Text;

                        user.txtProntuario.Enabled = false;

                        user.TipoPerfil = "funcionario";

                        user.ShowDialog();

                        this.Close();
                    }
                    else
                    {
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
                }
                else
                {
                    Pessoa funcionario = new Funcionario(txtNome.Text, mskRG.Text, _Cpf, txtNaturalidade.Text, _UF,
                                                         _EstadoCivil, _Sexo, _Cargo, _Turno, txtEndereco.Text, txtBairro.Text,
                                                         _Cep, _TelefoneFixo, _Celular,
                                                         txtEmail.Text, _CaminhoImagem, txtProntuario.Text, _Idade,
                                                         _DataNascimento, DateTime.Now);
                    //método de alteração
                    MetroMessageBox.Show(this, funcionario.Altera(), "Sucesso", MessageBoxButtons.OK,
                                         MessageBoxIcon.Question, 150);

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

                #endregion
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento pra fechar o Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();      
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

                //atribuindo valores...
                txtEndereco.Text = resposta.end + ", " + resposta.cidade;
                txtBairro.Text = resposta.bairro;
                cmbUF.SelectedItem = resposta.uf;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
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

                    //showDialog() espera a tela que abrir fechar.
                    frm.ShowDialog();

                    frm.Tipo = "funcionário";

                    if (frm.ImagemSelecionada != null)
                    {
                        ptbImagem.BackgroundImage = frm.ImagemSelecionada;

                        if (txtNome.Text != null)
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
                MessageBox.Show(ex.Message);
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
                calendario.Parent = gpbFuncionario;

                //defino qual será a localização do objeto
                calendario.Location = new Point(btnData.Location.X, btnData.Location.Y - 100);

                /* Se o texto do maskedBox Data for diferente do formato abaixo, o calendário irá mostrar na data já escolhida
                 * Senão, irá mostrar apartir da data atual
                */
                if (mskDataNascimento.Text != "  /  /")
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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, ex.Message.Length + 50);
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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para carregar imagem no ptbImagem (Click)

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //filtro de arquivos
                ofdAbrir.Filter = "Arquivos de imagem(*.jpg;*.bmp;*.gif;*.png;)|*.jpg;*.bmp;*.gif;*.png;";

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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error,  150);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //delimitando para usar digitos e tecla "Back"
                e.Handled = !((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.X || e.KeyChar == (char)Keys.Back);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //delimitando para usar digitos e teclas "Back"
                e.Handled = !((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento pra abrir tela de consulta quando fechar o Form (FormClosing)

        private void frmCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (Entrada == "consulta")
                    {
                        frmConsulta con = new frmConsulta();

                        //atribuindo valores
                        con.IdLogin = this.IdLogin;

                        con.Consulta = "funcionario";

                        con.TipoPerfil = this.TipoPerfil;

                        con.tspEmitir.Visible = false;

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
                //habilitando o botão de cadastrar
                if (!String.IsNullOrEmpty(txtNome.Text) &&
                    !String.IsNullOrEmpty(txtProntuario.Text) &&
                    txtProntuario.Text.Length == 6 &&
                    ValidaEmail(txtEmail.Text) == true &&
                    cmbCargo.SelectedIndex != -1)
                {
                    btnCadastrar.Enabled = true;
                }
                else
                {
                    btnCadastrar.Enabled = false;
                }

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
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para verificar se o funcionário existe no banco ou não (TextChanged)

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Banco bd = new Banco();

                if (Codigo == null)
                {
                    if (txtProntuario.Text.Length == 6)
                    {
                        if (bd.Verifica("PRONTUARIO", "funcionarios", txtProntuario.Text) == true)
                        {
                            MetroMessageBox.Show(this, "Esse funcionário já existe!", "Atenção", MessageBoxButtons.OK, 
                                                 MessageBoxIcon.Warning, 150);
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

        #region Evento para validar o email (Validated)

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (ValidaEmail(txtEmail.Text) != true)
            {
                MetroMessageBox.Show(this, "O email informádo é inválido!\nInforme seu email corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
            }
        }

        #endregion

        //-----------------------------------------Métodos--------------------------------------//

        #region Método para criar pasta de imagens

        private void CriaPasta()
        {
            try
            {
                //caminho que vai ser criada a pasta de Imagens
                _Pasta = @"C:\Users\william\Pictures\SGSP Imagens\Funcionario";

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
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para setar null campos que não forem preenchidos

        private void VerificaNull()
        {
            try
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

                if (String.IsNullOrEmpty(cmbCargo.Text))
                {
                    _Cargo = null;
                }
                else
                {
                    _Cargo = cmbCargo.SelectedItem.ToString();
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

                if (String.IsNullOrEmpty(cmbTurno.Text))
                {
                    _Turno = null;
                }
                else
                {
                    _Turno = cmbTurno.SelectedItem.ToString();
                }

                #endregion
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Método para validar email do(a) servidor(a)

        private static bool ValidaEmail(string email)
        {
            try
            {
                //declaro uma váriavel 'bool' já com valor 'false'
                bool emailValido = false;

                //verifico se na váriavel 'email' contém o 'char' "@", caso sim, irei continuar a verificação.
                if (email.Contains("@"))
                {
                    //defino um 'int' que irá receber o índice em qual o "@" se encontra no email
                    int indiceArroba = email.IndexOf("@");

                    //se for maior que 0..
                    if (indiceArroba > 0)
                    {
                        //se o início do indice for o valor do 'int' + 1 e maior que 0
                        if (email.IndexOf("@", indiceArroba + 1) > 0)
                        {
                            //retornará falso
                            return emailValido;
                        }
                    }

                    //defino outro 'int' que irá pegar o indice em qual o "." se encontra no email, começando da posição do indiceArroba
                    int indicePonto = email.IndexOf(".", indiceArroba);

                    //se o valor do 'indicePonto' - 1 for maior que o valor do 'indiceArroba'
                    if (indicePonto - 1 > indiceArroba)
                    {
                        //se o valor do 'indicePonto' + 1 for menor que o tamanho do 'email'
                        if (indicePonto + 1 < email.Length)
                        {
                            //defino um 'string' que irá receber um 'substring' com início em uma posição, com valor de '1'
                            string indicePonto2 = email.Substring(indicePonto + 1, 1);

                            //se a 'string' for diferente de '.'
                            if (indicePonto2 != ".")
                            {
                                emailValido = true;
                            }
                        }
                    }
                }
                else
                {
                    return emailValido;
                }

                return emailValido;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }

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

                if (txtProntuario.Enabled == true)
                {
                    txtProntuario.Text = null;
                }

                #endregion

                #region Masked TextBox

                mskCelular.Text = null; mskCEP.Text = null; mskCPF.Text = null;
                mskDataNascimento.Text = null; mskRG.Text = null; mskTelefoneFixo.Text = null;

                #endregion

                #region ComboBox

                cmbCargo.SelectedIndex = -1;

                cmbEstadoCivil.SelectedIndex = -1;

                cmbSexo.SelectedIndex = -1;

                cmbTurno.SelectedIndex = -1;

                cmbUF.SelectedIndex = -1;

                #endregion

                #region PictureBox

                ptbImagem.BackgroundImage = Properties.Resources.png_Funcionario;

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
