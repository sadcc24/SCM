using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllSeguridadSAD;

namespace SCM
{
    public partial class mostrarLogin : Form
    {
        Login Inicio = new Login();
        public mostrarLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool autenticado = false;
            autenticado = Inicio.RegistrarSesión(txtUsuario.Text,txtPassword.Text);
            if (autenticado == true)
            {
                frmEmpresa Empresa = new frmEmpresa();
                Empresa.Show();
                mostrarMenu Menu = new mostrarMenu();
                Menu.Show();
            }
            else
            {
                this.Refresh();
            }
        }
    }
}
