/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Empleados
    Fecha de asignación: 27/Junio
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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;

            string query = "SELECT idempresa, nombre_empresa FROM [dbo].[Empresa]";
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Empresa");
            int i;
            gvEmpresa.DataSource = ds.Tables[0];
            for (i = 0; i < gvEmpresa.RowCount - 1; i++)
            {
                cmbEmpresa.Items.Add(gvEmpresa[0, i].Value.ToString() + " " + gvEmpresa[1, i].Value.ToString());
            }

            string query2 = "SELECT codusuario, usuario FROM [dbo].[Usuario_1]";
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Usuario_1");
            int i2;
            gvUsuario.DataSource = ds2.Tables[0];
            for (i2 = 0; i2 < gvUsuario.RowCount - 1; i2++)
            {
                cmbUsuario.Items.Add(gvUsuario[0, i2].Value.ToString() + " " + gvUsuario[1, i2].Value.ToString());
            }

            string query3 = "SELECT idrol, rol FROM [dbo].[Rol]";
            DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query3, "Rol");
            int i3;
            gvRol.DataSource = ds3.Tables[0];
            for (i3 = 0; i3 < gvRol.RowCount - 1; i3++)
            {
                cmbRol.Items.Add(gvRol[0, i3].Value.ToString() + " " + gvRol[1, i3].Value.ToString());
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(cmbEmpresa.Text))
            {
                MessageBox.Show("Debe seleccionar la Empresa.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(cmbUsuario.Text))
                {
                    MessageBox.Show("Debe seleccionar el Usuario.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(cmbRol.Text))
                    {
                        MessageBox.Show("Debe seleccionar el Rol relacionado.");
                        return;
                    }
                    else
                    {                        
                        try
                        {
                            Empleados_Entity Employer = new Empleados_Entity();
                            Empleados_BO Empleados = new Empleados_BO();
                            int sempresa, susuario, srol;
                            
                            sempresa = cmbEmpresa.SelectedIndex;
                            Employer.idempresa= gvEmpresa[0, sempresa].Value.ToString();

                            susuario = cmbUsuario.SelectedIndex;
                            Employer.codusuario = gvUsuario[0, susuario].Value.ToString();

                            srol = cmbRol.SelectedIndex;
                            Employer.idrol= gvRol[0, srol].Value.ToString();

                            Employer.idestado= txtEstado.Text;
                            Empleados.vInsertarEmpleado(Employer);
                            MessageBox.Show("Asignación ha sido creada.");
                            
                            this.Hide();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Error!.");
                        }
                        
                    }
                }
            } //termina if

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {                      
            fnConsultarUltimoId();
            cmbEmpresa.Enabled = true;
            cmbUsuario.Enabled = true;
            cmbRol.Enabled = true;
        }

        private void fnConsultarUltimoId()
        {
            Empleados_BO Empleados = new Empleados_BO();
            // Empleados.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEmpresa.Text))
            {
                MessageBox.Show("Debe seleccionar la Empresa.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(cmbUsuario.Text))
                {
                    MessageBox.Show("Debe seleccionar el Usuario.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(cmbRol.Text))
                    {
                        MessageBox.Show("Debe seleccionar el Rol relacionado.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            Empleados_Entity Employer = new Empleados_Entity();
                            Empleados_BO Empleados = new Empleados_BO();
                            int sempresa, susuario, srol;

                            sempresa = cmbEmpresa.SelectedIndex;
                            Employer.idempresa = gvEmpresa[0, sempresa].Value.ToString();

                            susuario = cmbUsuario.SelectedIndex;
                            Employer.codusuario = gvUsuario[0, susuario].Value.ToString();

                            srol = cmbRol.SelectedIndex;
                            Employer.idrol = gvRol[0, srol].Value.ToString();

                            Employer.idestado = txtEstado.Text;
                            Empleados.vInsertarEmpleado(Employer);
                            MessageBox.Show("Asignación ha sido creada.");

                            this.Hide();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                } //termina if
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Debe escribir el id de la Empleados a eliminar.");
                return;
            }
            else
            {
                DialogResult cambio;
                this.Hide();
                cambio = MessageBox.Show("¿Está seguro de eliminar asignación de usuario?", "Seguridad SAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cambio == DialogResult.Yes)
                {
                    Empleados_Entity Employer = new Empleados_Entity();
                    Empleados_BO Empleados = new Empleados_BO();
                    Employer.idempleado = txtCod.Text;

                    Empleados.vEliminarEmpleado(Employer);
                    MessageBox.Show("Empleado ha sido Eliminado.");

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
