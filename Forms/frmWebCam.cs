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
    public partial class frmWebCam : MetroForm
    {
        #region Variáveis

        private AForge.Video.DirectShow.VideoCaptureDevice _VideoSource;

        private AForge.Video.DirectShow.FilterInfoCollection _VideoSources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);

        #endregion

        #region Encapsuladores

        public Image ImagemSelecionada { get; set; }

        public string Tipo { get; set; }

        #endregion

        public frmWebCam()
        {
            InitializeComponent();
        }

        //------------------------------------------Eventos------------------------------------//

        #region Evento Load do Form (Load)

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            try
            {
                //para cada informação de filtro do direct show na váriavel _VideoSources 
                //do tipo FilterInfoCollection, irá adicionar o nome do dispositivo no comboBox
                foreach (AForge.Video.DirectShow.FilterInfo v in _VideoSources)
                {
                    cmbDispositivos.Items.Add(v.Name);
                }

                //Inicializa o relógio
                tmrRelogio.Start();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento para ligar a Webcam de acordo com a escolha do ComboBox  (SelectedIndexChanged)

        private void cmbDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Se o index for maior do que 1, ou seja, se estiver algum item selecionado
                if (cmbDispositivos.SelectedIndex > -1)
                {
                    //será instanciado o videoSource de novo, com o valor selecionado do comboBox como parãmetro
                    _VideoSource = new AForge.Video.DirectShow.VideoCaptureDevice(_VideoSources[cmbDispositivos.SelectedIndex].MonikerString);

                    //o atributo NewFrame será igual a soma dele mesmo com o resultado do método VideoSourceNewFrame
                    _VideoSource.NewFrame += VideoSourceNewFrame;

                    //Será iniciado um novo frame
                    _VideoSource.Start();

                    this.Text = "Dispositivo : " + cmbDispositivos.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento que "salva", fecha o form e dá foco no Cadastro (Click)

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //fecha o form
                Close();

                switch (Tipo)
                {
                    case "funcionario":

                        if (Application.OpenForms["frmCadastroFuncionario"] != null)
                        {
                            //dá foco no form
                            Application.OpenForms["frmCadastroFuncionario"].Focus();
                        }

                        break;

                    case "aluno":

                        if (Application.OpenForms["frmCadastroAluno"] != null)
                        {
                            Application.OpenForms["frmCadastroAluno"].Focus();
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento que "tira" a foto (Click)

        private void btnTirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTirar.Text == "Tirar!")
                {
                    _VideoSource.Stop();

                    btnTirar.Text = "Tentar de novo";

                    ImagemSelecionada = ptbCamera.BackgroundImage;
                }
                else
                {
                    _VideoSource.Start();

                    btnTirar.Text = "Tirar!";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        #region Evento que verifica condições para habilitar botão btnTirar (Tick)

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            try
            {
                if (cmbDispositivos.SelectedIndex == -1)
                {
                    btnTirar.Enabled = false;

                    btnTirar.Highlight = false;
                }
                else
                {
                    btnTirar.Enabled = true;

                    btnTirar.Highlight = true;
                }

                if (btnTirar.Text == "Tirar!")
                {
                    btnSalvar.Enabled = false;

                    btnSalvar.Highlight = false;
                }
                else
                {
                    btnSalvar.Enabled = true;

                    btnSalvar.Highlight = true;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion

        //------------------------------------------Métodos------------------------------------//

        #region Método que mostra a imagem da Webcam no PictureBox 

        private void VideoSourceNewFrame(object sender, AForge.Video.NewFrameEventArgs e)
        {
            try
            {
                //Cria-se um novo objeto do tipo Bitmap, onde ele irá receber o "Frame" da câmera
                Bitmap _imagem = new Bitmap(e.Frame);

                //Vai setar essa imagem no PictureBox
                ptbCamera.BackgroundImage = _imagem;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
            }
        }

        #endregion
    }
}
