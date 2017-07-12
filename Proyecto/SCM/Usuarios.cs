/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Usuarios
    Fecha de asignación: 20/Junio
    Fecha de entrega: 03/Julio
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
using BO;
using Entity;
using DAL;

namespace SCM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;            
            
            string query = "SELECT idrol, Rol FROM [dbo].[Rol]";
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Rol");
            int i;
            gvUsuariosA.DataSource = ds.Tables[0];
            for (i = 0; i < gvUsuariosA.RowCount - 1; i++)
            {
                cmbRol.Items.Add(gvUsuariosA[0, i].Value.ToString() + " " + gvUsuariosA[1, i].Value.ToString());
            }

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe agregar el nombre del Usuario.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Debe agregar la contraseña del Usuario.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPregunta.Text))
                    {
                        MessageBox.Show("Debe agregar la pregunta secreta del Usuario.");
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cmbRol.Text))
                        {
                            MessageBox.Show("Debe de seleccionar un Rol.");
                            return;
                        }
                        else
                        {
                            try
                            {
                                Usuarios_Entity User = new Usuarios_Entity();
                                Usuarios_BO Usuario = new Usuarios_BO();
                                int seleccionado;
                                seleccionado = cmbRol.SelectedIndex;
                                User.iRol = gvUsuariosA[0, seleccionado].Value.ToString();
                                User.strUsuario = txtUsuario.Text;
                                User.strPassword = txtPassword.Text;
                                User.iStatus = txtStatus.Text;
                                User.strPregunta = txtPregunta.Text;
                                Usuario.vInsertarUsuario(User);
                                MessageBox.Show("Usuario ha sido creado.");
                                string[] user = Globales.Usuario.CapturarUsuario();
                                if (user[0] != "No Autenticado")
                                {
                                    mantenimientoUsuarios prdu = new mantenimientoUsuarios();
                                    prdu.MdiParent = this.MdiParent;
                                    this.Hide();
                                    prdu.Show();
                                }
                                else
                                    this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message,"Error!.");
                            }
                        }
                    }
                }
            } //termina if

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtPregunta.Text = "Pregunta";
            fnConsultarUltimoId();
        }

        private void fnConsultarUltimoId()
        {
            Usuarios_BO Usuario = new Usuarios_BO();
            // Usuario.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            Usuarios_Entity User = new Usuarios_Entity();
            Usuarios_BO Usuario = new Usuarios_BO();
            User.strUsuario = txtUsuario.Text;
            Usuario.vConsultaFiltro(User);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Debe escribir el id del Usuario a editar.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Debe agregar el Usuario.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Debe agregar la contraseña del Usuario.");
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtPregunta.Text))
                        {
                            MessageBox.Show("Debe agregar la pregunta secreta del Usuario.");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cmbRol.Text))
                            {
                                MessageBox.Show("Debe de seleccionar un Rol.");
                                return;
                            }
                            else
                            {
                                try
                                {
                                        Usuarios_Entity User = new Usuarios_Entity();
                                        Usuarios_BO Usuario = new Usuarios_BO();
                                        User.iCodUsuario = txtCod.Text;
                                        User.iRol = cmbRol.SelectedText;
                                        User.strUsuario = txtUsuario.Text;
                                        User.strPassword = txtPassword.Text;
                                        User.iStatus = txtStatus.Text;
                                        User.strPregunta = txtPregunta.Text;                                        
                                        Usuario.vModificarUsuario(User);
                                        MessageBox.Show("Usuario ha sido Modificado.");
                                        mantenimientoUsuarios prdu = new mantenimientoUsuarios();
                                        prdu.MdiParent = this.MdiParent;
                                        this.Close();
                                        prdu.Show();
                               }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                            }
                        }
                    }

                } //termina if
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Debe escribir el id de la Usuario a eliminar.");
                return;
            }
            else
            {
                Usuarios_Entity User = new Usuarios_Entity();
                Usuarios_BO Usuario = new Usuarios_BO();
                User.iCodUsuario = txtCod.Text;

                Usuario.vEliminarUsuario(User);
                MessageBox.Show("Usuario ha sido Eliminado.");
                mantenimientoUsuarios prdu = new mantenimientoUsuarios();
                prdu.MdiParent = this.MdiParent;
                this.Hide();
                prdu.Show();
            }
        }
    }
}
