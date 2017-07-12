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

namespace SCM
{
    public partial class EstadoContrasena : Form
    {
        public EstadoContrasena()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado_contrasena_BO proveedor = new estado_contrasena_BO();
            estado_contrasena_Entity prov = new estado_contrasena_Entity();
            try
            {
                prov.id_estado_contrasena = int.Parse(txtCodigo.Text);
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.descripcion = txtNombre.Text;
                }
                proveedor.updateEstados(prov);
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Actualizacion de Datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado_contrasena_BO proveedor = new estado_contrasena_BO();
            estado_contrasena_Entity prov = new estado_contrasena_Entity();
            prov.id_estado_contrasena = int.Parse(txtCodigo.Text);
            try
            {

                proveedor.deleteEstados(prov);
                MessageBox.Show("Tipo ha sido Borrado.");

                mantenimientoEstadoContrasena prdu = new mantenimientoEstadoContrasena();
                prdu.MdiParent = this.MdiParent;
                //prdu.vConsultarProductosActivos();
                this.Hide();
                prdu.Show();

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Eliminacion de Datos");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estado_contrasena_BO proveedor = new estado_contrasena_BO();
            estado_contrasena_Entity prov = new estado_contrasena_Entity();
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.descripcion = txtNombre.Text;
                }
                proveedor.insertEstado(prov);
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Registro de Datos");
            }
        }
    }
}
