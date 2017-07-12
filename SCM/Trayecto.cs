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
    public partial class Trayecto : Form
    {
        public Trayecto()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            tipo_trayecto_BO proveedor = new tipo_trayecto_BO();
            tipo_trayecto_Entity prov = new tipo_trayecto_Entity();
            try
            {
                prov.id_tipo_trayecto = int.Parse(txtCodigo.Text);
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.nombre_tipo_trayecto = txtNombre.Text;
                }
                proveedor.updateTipo(prov);
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Actualizacion de Datos");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            tipo_trayecto_BO proveedor = new tipo_trayecto_BO();
            tipo_trayecto_Entity prov = new tipo_trayecto_Entity();
            prov.id_tipo_trayecto = int.Parse(txtCodigo.Text);
            try
            {

                proveedor.deleteTipo(prov);
                MessageBox.Show("Tipo ha sido Borrado.");

                mantenimientoTrayecto prdu = new mantenimientoTrayecto();
                prdu.MdiParent = this.MdiParent;
                //prdu.vConsultarProductosActivos();
                this.Hide();
                prdu.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Eliminacion de Datos");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            tipo_trayecto_BO proveedor = new tipo_trayecto_BO();
            tipo_trayecto_Entity prov = new tipo_trayecto_Entity();
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.nombre_tipo_trayecto = txtNombre.Text;
                }
                proveedor.insertTipo(prov);
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Registro de Datos");
            }
        }
    }
}
