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
    public partial class EstadoFactura : Form
    {
        public EstadoFactura()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado_factura_BO proveedor = new estado_factura_BO();
            estado_factura_Entity prov = new estado_factura_Entity();
            try
            {
                prov.id_estado = int.Parse(txtCodigo.Text);
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
            estado_orden_BO proveedor = new estado_orden_BO();
            estado_orden_Entity prov = new estado_orden_Entity();
            prov.id_estado = int.Parse(txtCodigo.Text);
            try
            {

                proveedor.deleteEstados(prov);
                MessageBox.Show("Tipo ha sido Borrado.");

                mantenimientoEstadoFacturas prdu = new mantenimientoEstadoFacturas();
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
            estado_orden_BO proveedor = new estado_orden_BO();
            estado_orden_Entity prov = new estado_orden_Entity();
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
