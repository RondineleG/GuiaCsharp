using System;
using System.Windows.Forms;

namespace CSharpComSqlServer
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            this.InitializeComponent();
        }

        private void btnSalvar_Click(Object sender, EventArgs e)
        {               
        }

        private void btnFeichar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMininizar_Click(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

