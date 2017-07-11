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
    public partial class TipoOrdenCompra : Form
    {
        public TipoOrdenCompra()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tipo_orden_BO proveedor = new tipo_orden_BO();
            tipo_orden_Entity prov = new tipo_orden_Entity();
            try
            {
                prov.id_tipo = int.Parse(txtCodigo.Text);
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.descripcion = txtNombre.Text;
                }
                proveedor.updateTipo(prov);
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
            tipo_orden_BO proveedor = new tipo_orden_BO();
            tipo_orden_Entity prov = new tipo_orden_Entity();
            prov.id_tipo = int.Parse(txtCodigo.Text);
            try
            {

                proveedor.deleteTipo(prov);
                MessageBox.Show("Tipo ha sido Borrado.");

                mantenimientoTipoOrdenCompra prdu = new mantenimientoTipoOrdenCompra();
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
            tipo_orden_BO proveedor = new tipo_orden_BO();
            tipo_orden_Entity prov = new tipo_orden_Entity();
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
                proveedor.insertTipo(prov);
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
