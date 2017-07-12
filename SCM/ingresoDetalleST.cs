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
        public ingresoDetalleST(string codigo, string idbodega)
        {
            InitializeComponent();
            txtIdSolicitud.Text = codigo;
            txtEncabezado.Text = codigo;
            txtBodega.Text = idbodega;
            CargaGridProductos(0);
            CargaGridDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtCodProducto.Text == "")
            {
                MessageBox.Show("Los valores de codigo de producto y cantidad no pueden estar vacios");
            }
            else
            {//inicia guardado de la info  
                Detalle_ST_Entity pDetalle = new Detalle_ST_Entity();
                pDetalle.idProducto = Convert.ToInt32(txtCodProducto.Text);
                pDetalle.idMovimiento = Convert.ToInt32(txtEncabezado.Text);
                pDetalle.idBodega = Convert.ToInt32(txtBodega.Text.Trim());
                if (txtPrecio.Text == "" || txtCosto.Text == "")
                {
                    pDetalle.precio = 0;
                    pDetalle.costo = 0;
                }else
                {
                    pDetalle.precio = Convert.ToDecimal(txtPrecio.Text);
                    pDetalle.costo = Convert.ToDecimal(txtCosto.Text.Trim());
                }

                int cantidad1, cantidad2;
                cantidad1 = Convert.ToInt32(txtCantidad.Text);
                cantidad2 = Convert.ToInt32(txtCantidadBD.Text);
                int pivote = 0;
                if (txtCantidadReal.Text != "") { pivote = Convert.ToInt32(txtCantidadReal.Text); }
                int dif = cantidad2 - cantidad1;
                int bd = cantidad1 + cantidad2;
                int cantidad = cantidad1 + cantidad2;
                int suma = pivote + cantidad2;

                if (cantidad1 > suma)
                {
                    MessageBox.Show("La cantidad ingresada es mayor a la existencia en bodega");
                }
                else
                {
                    //Valida:
                    //si se escogio el producto desde la busqueda entonces insertara
                    if (txtValida.Text == "1")
                    {

                        try
                        {
                            pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            new BO.SolicitudTransporte_BOL().insertaDetalleST(pDetalle);
                            MessageBox.Show("Producto ingresado a la solicitud exitosamente");
                            limpiartxt();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }//Fin Inserta
                    else
                    {//Inicia Actualizacion

                        try
                        {
                            pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            pDetalle.CantidadReal = Convert.ToInt32(txtCantidadReal.Text);


                            new BO.SolicitudTransporte_BOL().actualizarDetalleST(pDetalle);
                            MessageBox.Show("Producto actualizado exitosamente");
                            limpiartxt();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }//Fin Actualizacion
                    CargaGridDetalle();
                    CargaGridProductos(0);
                }//Fin validacion de cantidad ingresada es mayor a la existencia
            }//Fin validacion cantidades vacias
         }//Fin Void

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaGridDetalle();
            CargaGridProductos(0);
        }

        public void limpiartxt()
        { 
            txtCantidadReal.Clear();
            //txtBodega.Clear();
            txtCantidad.Clear();
            //txtCantidadBD.Clear();
            //txtCantidadReal.Clear();
            txtCodProducto.Clear();
            txtPrecio.Clear();
            txtCosto.Clear();

        }
        #region Funciones y metodos
        private void CargaGridProductos(int tipobsq)
        {
            string codigoProducto = "";
            string nomProducto = "";
            int idempresa = 1;
            int bodega = Convert.ToInt32(txtBodega.Text.Trim());
            if (tipobsq==1) 
            {
                codigoProducto = txtCodProductoB.Text;
                nomProducto = txtProductoB.Text;
            }
            try
            {
                ingresoDetalleProductos.DataSource = new SolicitudTransporte_BOL().verProductos(tipobsq, idempresa, bodega, codigoProducto, nomProducto);
                ingresoDetalleProductos.Refresh();
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
                st.idMovimiento = Convert.ToInt32(txtIdSolicitud.Text);
                st.idBodega = Convert.ToInt32(txtBodega.Text);
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

            DataGridViewRow row = ingresoDetalleProductos.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            string idproducto = valor.ToString();
            txtCodProducto.Text = idproducto;
            txtValida.Text = "1";
            txtProducto.Text = (string)row.Cells[1].Value;
            if (row.Cells[3].Value == DBNull.Value)
            { txtPrecio.Text = "0";  } else  { txtPrecio.Text = (string)row.Cells[3].Value; }
            
            if(row.Cells[4].Value == DBNull.Value)
            { txtCosto.Text = "0"; }
            else { txtCosto.Text = (string)row.Cells[4].Value; }
            txtCantidad.Clear();
            txtCantidadReal.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtValida.Text = "1";
            txtCantidad.Clear();
            txtCodProducto.Clear();
           // dgvDetalle.Enabled = true;
           // dgvProductos.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodProducto.Text == "" || txtCodProducto.Text == "0")
            {
                MessageBox.Show("No ha seleccionado ningun producto");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de eliminar el registro", "Detalle de Solicitud",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes)
                {

                    Detalle_ST_Entity pDetalle = new Detalle_ST_Entity();
                    pDetalle.idProducto = Convert.ToInt32(txtCodProducto.Text);
                    pDetalle.idBodega = Convert.ToInt32(txtBodega.Text);
                    pDetalle.idMovimiento = Convert.ToInt32(txtIdSolicitud.Text);
                    pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                    new BO.SolicitudTransporte_BOL().eliminarDetalleST(pDetalle);
                    CargaGridDetalle();
                    limpiartxt();
                    CargaGridProductos(0);
                }
            }
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvDetalle.Rows[e.RowIndex];
            
            int idproducto = (int)row.Cells[0].Value;
            //int idproducto = (int)row.Cells[1].Value;
            int cantidad = (int)row.Cells[2].Value;
            //string sidsolicitud = idsolicitud.ToString();
            string sidproductto = idproducto.ToString();
            string scantidad = cantidad.ToString();
            
            txtCantidad.Text = scantidad;
            txtCantidadReal.Text = scantidad;
            txtCodProducto.Text = sidproductto;
            txtValida.Text = "2";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //txtCantidad.Enabled = false;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaGridProductos(1);
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

        private void ingresoDetalleST_Load(object sender, EventArgs e)
        {

        }

        private void txtIdSolicitud_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {
            int producto, bodega;
            if(txtCodProducto.Text == "" || txtCodProducto.Text == "0" )
            {
                producto = 0;
            }else
            {
                producto = Convert.ToInt32(txtCodProducto.Text.Trim());
            }
            if (txtBodega.Text == "" || txtBodega.Text == "0")
            {
                bodega = 0;
            }
            else
            {
                bodega = Convert.ToInt32(txtBodega.Text.Trim());
            }

            Detalle_ST_Entity st = new BO.Detalle_ST_BO().validaExistenciaBD(producto, bodega);
            txtCantidadBD.Text = st.Cantidad.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiartxt();
        }
    }
}
