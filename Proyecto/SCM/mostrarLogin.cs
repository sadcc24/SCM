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
        public mostrarLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool autenticado = false;            
            try
            {
                if ((txtUsuario.Text != "") || (txtPassword.Text != ""))
                    autenticado = Globales.Usuario.RegistrarSesión(Globales.Conexion,txtUsuario.Text, txtPassword.Text);
                else
                {
                    MessageBox.Show("Ingrese su usuario y/o contraseña", "Seguridad SAD",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                }
                if (autenticado == true)
                {
                    //MessageBox.Show("¡Bienvenido "+ txtUsuario.Text + "!", "Seguridad SAD",
                    //            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mostrarEmpresa temp = new mostrarEmpresa();
                    this.Hide();
                    temp.Show();
                }
                else
                    this.Show();
            }
            catch
            {
                //en caso que la contraseña sea erronea mostrara un mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Error! Su contraseña y/o usuario son invalidos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }            
        }
    }
}
