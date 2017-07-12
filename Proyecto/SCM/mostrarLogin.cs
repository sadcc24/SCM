/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Seguridad
    Fecha de asignación: 13/Junio
    Fecha de entrega: 27/Junio
*/
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
using DAL;

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
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion,"Bitacora","Sesión Iniciada");
                    mostrarEmpresa temp = new mostrarEmpresa();
                    this.Close();
                    temp.Show();
                }
                else
                    this.Show();
            }
            catch (Exception error)
            {
                //en caso que la contraseña sea erronea mostrara un mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Error! Su contraseña y/o usuario son invalidos: " +
                        System.Environment.NewLine + System.Environment.NewLine +
                        error.GetType().ToString() + System.Environment.NewLine
                        + error.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Error al Iniciar Sesión");
            }            
        }

        private void mostrarLogin_Load(object sender, EventArgs e)
        {
            string[] user = Globales.Usuario.CapturarUsuario();
            if (user[0] == "No Autenticado")
            {
                MessageBox.Show("Debe crear un usuario administrador", "Seguridad SAD",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usuarios frm = new Usuarios();
                frm.txtCod.ReadOnly = true;
                string query = "SELECT idrol, Rol FROM [dbo].[Rol]";
                DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Rol");
                int i;
                frm.gvUsuariosA.DataSource = ds.Tables[0];
                for (i = 0; i < frm.gvUsuariosA.RowCount - 1; i++)
                {
                    frm.cmbRol.Items.Add(frm.gvUsuariosA[0, i].Value.ToString() + " " + frm.gvUsuariosA[1, i].Value.ToString());
                }
                frm.cmbRol.SelectedIndex = 0;
                frm.cmbRol.Enabled = false;
                frm.btnEditar.Enabled = false;
                frm.btnEliminar.Enabled = false;
                frm.txtCod.ReadOnly = true;
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(mostrarLogin.ActiveForm);                              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(mostrarLogin.ActiveForm);
        }
    }
}
