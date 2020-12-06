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


namespace SGSP___Desktop
{
    public partial class frmSplashScreen : Form
    {
        //variável que controla os Fades..
        private double i;

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        #region Evento que carrega os componentes e configurações (Load)

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            try 
            {
                //opacidade o form é zerada
                this.Opacity = 0;

                //habilita o timer de FadeIn
                tmrFadeIn.Enabled = true;

                //desabilita o timer de FadeOut
                tmrFadeOut.Enabled = false;

                //habilita o timer da ProgressBar
                tmrTimer.Enabled = true;
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento que faz o Fade In (Tick)

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            try
            {
                //incrementa o FadeIn a cada "toque" do relógio
                i += 0.05;

                //maior ou igual à 1...
                if (i >= 1)
                {
                    //o Form será visível
                    this.Opacity = 1;

                    //irá desabilitar o timer FadeIn
                    tmrFadeIn.Enabled = false;

                    return;
                }

                //opacidade do Form será igual à i
                this.Opacity = i;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento que faz o Fade Out (Tick)

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            try
            {
                //decrementa o valor de i de acordo com o toque do relógio
                i -= 0.05;

                //se for menor ou igual à 0.01...
                if (i <= 0.01)
                {
                    //o form ficará invisível
                    this.Opacity = 0.0;

                    //desabilita o Timer FadeOut
                    tmrFadeOut.Enabled = false;

                    //esconde o Form
                    this.Visible = false;

                    //Instancia o form de Login
                    frmLogin log = new frmLogin();

                    //mostra o form
                    log.Show();

                    return;
                }

                //a opacidade será igual ao i
                this.Opacity = i;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
        }

        #endregion

        #region Evento que faz enche a ProgressBar (Tick)

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //se o valor da progressBar for menor 100
                if (pgbProgresso.Value < 100)
                {
                    //irá incrementar seu valor por valor + 2
                    pgbProgresso.Value += 2;
                }
                else
                {
                    //se não o timer será desabilitado
                    tmrTimer.Enabled = false;

                    //e habilitará o timer de fadeOut
                    tmrFadeOut.Enabled = true;
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
