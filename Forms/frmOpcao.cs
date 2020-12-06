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
    public partial class frmOpcao : MetroForm
    {
        public frmOpcao()
        {
            InitializeComponent();
        }

        #region Evento para abrir tela de cadastro do funcionário (Click)

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadastroFuncionario"] == null)
            {
                frmCadastroFuncionario fcf = new frmCadastroFuncionario();

                fcf.ShowDialog();

                this.Close();
            }
            else
            {
                Application.OpenForms["frmCadastroFuncionario"].Focus();
            }
        }

        #endregion

        #region Evento para abrir tela de cadastro do usuário (Click)

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadastroUsuario"] == null)
            {
                frmCadastroUsuario fcf = new frmCadastroUsuario();

                fcf.ShowDialog();

                this.Close();
            }
            else
            {
                Application.OpenForms["frmCadastroUsuario"].Focus();
            }
        }

        #endregion
    }
}
