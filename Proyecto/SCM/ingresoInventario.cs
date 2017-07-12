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
    public partial class ingresoInventario : Form
    {


        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David


        public ingresoInventario()
        {
            InitializeComponent();
        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            if (cmbTipoMovimiento.SelectedValue.ToString() == "1")
            {
                buscarOC frm = new buscarOC();
                frm.lblProveedor.Text = cmbProveedor.SelectedValue.ToString();
                frm.lblBodega.Text = cmbBodega.SelectedValue.ToString();
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                frm.lblEmpresa.Text = empresa[0];
                this.Close();
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(mostrarMenu.ActiveForm);
               
            }
            if (cmbTipoMovimiento.SelectedValue.ToString() == "2")
            {
                buscarEgresos frm = new buscarEgresos();
                frm.lblProveedor.Text = cmbProveedor.SelectedValue.ToString();
                frm.lblBodega.Text = cmbBodega.SelectedValue.ToString();
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                frm.lblEmpresa.Text = empresa[0];
                this.Close();
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(mostrarMenu.ActiveForm);

            }

            if (cmbTipoMovimiento.SelectedValue.ToString() == "4")
            {
                buscarFacturasIngresadas frm = new buscarFacturasIngresadas();
                frm.lblProveedor.Text = cmbProveedor.SelectedValue.ToString();
                frm.lblBodega.Text = cmbBodega.SelectedValue.ToString();
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                frm.lblEmpresa.Text = empresa[0];
                frm.lbltipomov.Text = cmbTipoMovimiento.SelectedValue.ToString();
                this.Close();
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(mostrarMenu.ActiveForm);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtSolTras_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idproducto, cantidad, costo, precio;
            try
            {
                if (grdInventario.Rows.Count > 0)
                {
                    clsMovimientosInventario_Entity bod = new clsMovimientosInventario_Entity();
                    clsMovimientosInventario_BO bodega = new clsMovimientosInventario_BO();
                    bod.strIdBodega = cmbBodega.SelectedValue.ToString();
                    //bod.strIdProducto = cmbProveedor.SelectedValue.ToString();
                    bod.strIdTipoMovimiento = cmbTipoMovimiento.SelectedValue.ToString();
                    string[] moneda = Globales.Usuario.CapturarMoneda(Globales.Conexion);                    
                    bod.strIdMoneda = moneda[0]; ;
                    bod.strFecha = dtfecha.Value.ToString("yyyy-MM-dd");
                    bod.strDocRef = txtDocRef.Text;
                    bodega.vInsertarMovimientoInventario(bod);
                    //   MessageBox.Show(dtfecha.Value.ToString());
                    //bodega.vInsertarEncabezadoContrasena(bod);

                    clsMovimientosInventario_Entity mov = new clsMovimientosInventario_Entity();
                    clsMovimientosInventario_BO movimiento = new clsMovimientosInventario_BO();
                    mov.strIdTipoMovimiento = cmbTipoMovimiento.SelectedValue.ToString();
                 //   MessageBox.Show(cmbTipoMovimiento.SelectedValue.ToString());
                    DataTable valor = movimiento.vConsultarOperacion(mov);
                    if (valor.Rows[0].ItemArray[0].ToString() == "False")
                    {
                        lblOperacion.Text = "-1" ;
                    }else
                    {
                        if (valor.Rows[0].ItemArray[0].ToString() == "True")
                        {
                            lblOperacion.Text = "1";
                        }
                    }

                    int id;
                    decimal exis;
                    id = Convert.ToInt32(bodega.dtConsultarUltimoMovimiento().Rows[0][0].ToString());
                    //    MessageBox.Show(id.ToString());
                    int cant;
                    Decimal costop;
                    decimal total = 0 ;
                    foreach (DataGridViewRow fila in grdInventario.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {                        
                            idproducto = fila.Cells[1].Value.ToString();
                            bod.strIdProducto = idproducto;
                            exis = Convert.ToDecimal(bodega.vConsultarExistencia(bod).Rows[0][0].ToString());
                            cantidad = fila.Cells[2].Value.ToString();
                            costo = fila.Cells[3].Value.ToString();
                            precio = fila.Cells[4].Value.ToString();
                            cant = Convert.ToInt32(cantidad) * Convert.ToInt32(lblOperacion.Text);
                            //MessageBox.Show(idproducto + "__" + cant.ToString() + "__" + costo + "__" + precio);
                            total = total + (Convert.ToDecimal(costo) * Convert.ToDecimal(cantidad));
                            if (lblOperacion.Text.ToString() == "-1")
                            {
                                if (exis >= Convert.ToDecimal(cantidad))
                                {
                                    clsMovimientosInventario_Entity bo = new clsMovimientosInventario_Entity();
                                    clsMovimientosInventario_BO bodeg = new clsMovimientosInventario_BO();
                                    bo.strIdMovimiento = id.ToString();
                                    bo.strIdBodega = cmbBodega.SelectedValue.ToString();
                                    bo.strIdProducto = idproducto;
                                    bo.strCosto = costo;
                                    bo.strCantidad = cant.ToString();
                                    bodeg.vInsertarDetalleMovimientoInventario(bo);
                                    bodeg.vModificarExistencia(bo);
                                    MessageBox.Show("Movimiento de Inventario Guardado.");
                                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Movimiento de Inventario.");
                                }
                            }
                            if (lblOperacion.Text.ToString() == "1")
                            {
                                clsMovimientosInventario_Entity bo = new clsMovimientosInventario_Entity();
                                clsMovimientosInventario_BO bodeg = new clsMovimientosInventario_BO();
                                bo.strIdMovimiento = id.ToString();
                                bo.strIdBodega = cmbBodega.SelectedValue.ToString();
                                bo.strIdProducto = idproducto;
                                bo.strCosto = costo;
                                bo.strCantidad = cant.ToString();
                                bodeg.vInsertarDetalleMovimientoInventario(bo);
                                bodeg.vModificarExistencia(bo);
                              
                                decimal costopromedio;
                                // PARA INGRESO POR COMPRAS (TIPO 1)
                                if(cmbTipoMovimiento.SelectedValue.ToString()=="1")
                                { // PROMEDIO DE COSTO DE ACUERDO AL COSTO ANTERIOR PROMEDIADO CON EL COSTO NUEVO
                                    clsMovimientosInventario_Entity exist = new clsMovimientosInventario_Entity();
                                    clsMovimientosInventario_BO existencia = new clsMovimientosInventario_BO();
                                    exist.strIdProducto = idproducto;
                                    costop = Convert.ToDecimal(existencia.vConsultarCostoProducto(exist).Rows[0][0].ToString());
                                    costopromedio = (costop + Convert.ToDecimal(costo)) / 2;
                                    exist.strCosto = costopromedio.ToString();
                                    existencia.vModificarCostoProducto(exist);


                                 


                                    
                                }

                            }




                            ////  idproveedor = fila.Cells[7].Value.ToString();
                            ////  idbodega = fila.Cells[8].Value.ToString();
                            ////MessageBox.Show(idfactura + "__" + id.ToString() + "__" + saldo);
                        }
                    }
                   if (cmbTipoMovimiento.SelectedValue.ToString() == "1")
                    {
                        factura_proveedores_Entity fac = new factura_proveedores_Entity();
                        factura_proveedores_BO factura = new factura_proveedores_BO();
                        fac.id_bodega = Convert.ToInt32(cmbBodega.SelectedValue.ToString());
                        fac.total = total;
                        fac.saldo = total;
                        fac.corrfactura = txtcorr.Text;
                        fac.id_serie = txtserie.Text;
                        fac.fecha = dtfecha.Value.ToString("yyyy-MM-dd");
                        fac.id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue.ToString());
                        fac.id_estado_factura = 1;
                        fac.id_movimiento = id;
                        factura.insertfactura(fac);
                    }


                    //MessageBox.Show("Movimiento de Inventario Guardado.");
                    //Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Devolución por Compra.");

                    MessageBox.Show("Movimiento de Inventario Guardado.");
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Movimiento de Inventario.");
                    this.Close();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingresoInventario_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            clsProductos_BO bodega = new clsProductos_BO();
            cmbBodega.DataSource = bodega.vdtComboBodega();
            cmbBodega.ValueMember = "ID";
            cmbBodega.DisplayMember = "Descripcion";

            cmbProveedor.DataSource = bodega.vdtComboProveedor();
            cmbProveedor.ValueMember = "ID";
            cmbProveedor.DisplayMember = "Descripcion";

            clsTipoMovimiento_BO tipom = new clsTipoMovimiento_BO();
            cmbTipoMovimiento.DataSource = tipom.vConsultarTipoMovimiento2();
            cmbTipoMovimiento.ValueMember = "ID";
            cmbTipoMovimiento.DisplayMember = "descripcion";


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoMovimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
