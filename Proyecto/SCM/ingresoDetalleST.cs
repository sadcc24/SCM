using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;

namespace SCM
{
    public partial class ingresoDetalleST : Form
    {
        public ingresoDetalleST(string codigo)
        {
            InitializeComponent();
            txtIdSolicitud.Text = codigo;
            CargaGridProductos(0);
            CargaGridDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "" || txtCodProducto.Text == "")
            {
                MessageBox.Show("Los valores de codigo de producto y cantidad no pueden estar vacios");
            }else
            {
                Detalle_ST_Entity pDetalle = new Detalle_ST_Entity();
                pDetalle.idProducto = Convert.ToInt32(txtCodProducto.Text);
                pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                pDetalle.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text);

                if (txtValida.Text == "1")
                {
                    try
                    {
                        new BO.SolicitudTransporte_BOL().insertaDetalleST(pDetalle);
                        MessageBox.Show("Prodoucto ingresado a la solicitud exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        new BO.SolicitudTransporte_BOL().actualizarDetalleST(pDetalle);
                        MessageBox.Show("Producto actualizado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                CargaGridDetalle();
            }
           
         }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaGridDetalle();
            CargaGridProductos(0);
        }

        #region Funciones y metodos
        private void CargaGridProductos(int tipobsq)
        {
            try
            {
                dgvProductos.DataSource = new SolicitudTransporte_BOL().verProductos(tipobsq);
                dgvProductos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private  void CargaGridDetalle()
        {
            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text);
                dgvDetalle.DataSource = new SolicitudTransporte_BOL().verDetalleST(st);
                dgvDetalle.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        #endregion

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            string idproducto = valor.ToString();
            txtCodProducto.Text = idproducto;
            txtValida.Text = "1";
            txtCantidad.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtValida.Text = "1";
            txtCantidad.Clear();
            txtCodProducto.Clear();
            dgvDetalle.Enabled = true;
            dgvProductos.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro", "Detalle de Solicitud",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
            {
             
                Detalle_ST_Entity pDetalle = new Detalle_ST_Entity();
                pDetalle.idProducto = Convert.ToInt32(txtCodProducto.Text);
                pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                pDetalle.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text);
                new BO.SolicitudTransporte_BOL().eliminarDetalleST(pDetalle);
                CargaGridDetalle();
            }
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvDetalle.Rows[e.RowIndex];
            int idsolicitud = (int)row.Cells[0].Value;
            int idproducto = (int)row.Cells[1].Value;
            int cantidad = (int)row.Cells[3].Value;
            string sidsolicitud = idsolicitud.ToString();
            string sidproductto = idproducto.ToString();
            string scantidad = cantidad.ToString();
            
            txtCantidad.Text = scantidad;
            txtCodProducto.Text = sidproductto;
            txtValida.Text = "2";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            dgvDetalle.Enabled = false;
            dgvProductos.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
