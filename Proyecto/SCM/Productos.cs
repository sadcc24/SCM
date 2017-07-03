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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            LlenaCombos();
            btnCancelar.Enabled = false;
        }

        private void LlenaCombos()
        {

            clsProductos_BO bodega = new clsProductos_BO();
            cmbBodega.DataSource = bodega.vdtComboBodega();
            cmbBodega.ValueMember = "ID";
            cmbBodega.DisplayMember = "Descripcion";

            cmbProveedor.DataSource = bodega.vdtComboProveedor();
            cmbProveedor.ValueMember = "ID";
            cmbProveedor.DisplayMember = "Descripcion";

            cmbTipProd.DataSource = bodega.vdtComboTipoProducto();
            cmbTipProd.ValueMember = "ID";
            cmbTipProd.DisplayMember = "Descripcion";

            cmbMarca.DataSource = bodega.vdtComboMarca();
            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Descripcion";


            cmbmetodo.DataSource = bodega.vdtComboMetodoCosteo();
            cmbmetodo.ValueMember = "ID";
            cmbmetodo.DisplayMember = "Descripcion";


            cmbLinea.DataSource = bodega.vdtComboLinea();
            cmbLinea.ValueMember = "ID";
            cmbLinea.DisplayMember = "Descripcion";

            cmbEstado.DataSource = bodega.vdtComboEstado();
            cmbEstado.ValueMember = "ID";
            cmbEstado.DisplayMember = "Descripcion";
        }
        string strproducto, strcantidad, strbodega, strproveedor, strtipoprod, strmarca, strmetodocosteo, strlinea, strestado, strtamano, strpeso;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe agregar el ID del PRODUCTO.");
                return;
            }
            else
            {
          
                try
                {
                    clsProductos_Entity pro = new clsProductos_Entity();
                    clsProductos_BO producto = new clsProductos_BO();
                    pro.strIdProd = txtID.Text;
                    producto.vEliminarProducto(pro);
                    MessageBox.Show("Producto ha sido Borrado.");

                    mantenimientoProductos prdu = new mantenimientoProductos();
                    prdu.MdiParent = this.MdiParent;
                    //prdu.vConsultarProductosActivos();
                    this.Hide();
                    prdu.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Debe agregar el nombre del PRODUCTO.");
                return;
            }
            else {
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe agregar el la cantidad del PRODUCTO.");
                    return;
                }
                else{
                    if (string.IsNullOrEmpty(txttamano.Text))
                    {
                        MessageBox.Show("Debe agregar el el tamaño del PRODUCTO.");
                        return;
                    }
                    else{
                        if (string.IsNullOrEmpty(txtPeso.Text))
                        {
                            MessageBox.Show("Debe agregar el el peso del PRODUCTO.");
                            return;
                        }
                        else{
                        //    string strproducto, strcantidad, strbodega, strproveedor, strtipoprod, strmarca, strmetodocosteo, strlinea, strestado, strtamano, strpeso;
                            strproducto = txtProducto.Text;
                            strcantidad = txtCantidad.Text;
                            strbodega = cmbBodega.SelectedValue.ToString();
                            strproveedor = cmbProveedor.SelectedValue.ToString();
                            strtipoprod = cmbTipProd.SelectedValue.ToString();
                            strmarca = cmbMarca.SelectedValue.ToString();
                            strmetodocosteo = cmbmetodo.SelectedValue.ToString();
                            strlinea = cmbLinea.SelectedValue.ToString();
                            strestado = cmbEstado.SelectedValue.ToString();
                            strtamano = txttamano.Text;
                            strpeso = txtPeso.Text;

                            // MessageBox.Show(" P) "+strproducto + " CAN) " + strcantidad + " BOD) " + strbodega + " PR) " + strproveedor + " TP) " + strtipoprod + " M) " + strmarca + " MC) " + strmetodocosteo + " L) " + strlinea + " ES) " + strestado + " TP) " + strtamano + " PP) " + strpeso);

                          


                            try
                            {
                                clsProductos_Entity pro = new clsProductos_Entity();
                                clsProductos_BO producto = new clsProductos_BO();
                                pro.strProducto = strproducto;
                                pro.strCantidad = strcantidad;
                                pro.strBodega = strbodega;
                                pro.strProveedor = strproveedor;
                                pro.strTipoProducto = strtipoprod;
                                pro.strMarca = strmarca;
                                pro.strMetodoCosteo = strmetodocosteo;
                                pro.strLinea = strlinea;
                                pro.strEstado = strestado;
                                pro.strTamano = strtamano;
                                pro.strPeso = strpeso;


                                producto.vInsertarProducto(pro);
                                MessageBox.Show("Producto ha sido Guardado.");

                                mantenimientoProductos prdu = new mantenimientoProductos();
                                prdu.MdiParent = this.MdiParent;
                                //prdu.vConsultarProductosActivos();
                                this.Hide();
                                prdu.Show();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }

                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe agregar el ID del PRODUCTO.");
                return;
            }
            else {

                strproducto = txtProducto.Text;
                strcantidad = txtCantidad.Text;
                strbodega = cmbBodega.SelectedValue.ToString();
                strproveedor = cmbProveedor.SelectedValue.ToString();
                strtipoprod = cmbTipProd.SelectedValue.ToString();
                strmarca = cmbMarca.SelectedValue.ToString();
                strmetodocosteo = cmbmetodo.SelectedValue.ToString();
                strlinea = cmbLinea.SelectedValue.ToString();
                strestado = cmbEstado.SelectedValue.ToString();
                strtamano = Convert.ToInt32(Convert.ToDecimal(txttamano.Text.ToString())).ToString();
                strpeso = Convert.ToInt32(Convert.ToDecimal(txtPeso.Text.ToString())).ToString();
                try
                {
                    clsProductos_Entity pro = new clsProductos_Entity();
                    clsProductos_BO producto = new clsProductos_BO();
                    pro.strProducto = strproducto;
                    pro.strCantidad = strcantidad;
                    pro.strBodega = strbodega;
                    pro.strProveedor = strproveedor;
                    pro.strTipoProducto = strtipoprod;
                    pro.strMarca = strmarca;
                    pro.strMetodoCosteo = strmetodocosteo;
                    pro.strLinea = strlinea;
                    pro.strEstado = strestado;
                    pro.strTamano = strtamano;
                    pro.strPeso = strpeso;
                    pro.strIdProd = txtID.Text;
                  //   MessageBox.Show("ID)"+txtID.Text.ToString()+" P) "+strproducto + " CAN) " + strcantidad + " BOD) " + strbodega + " PR) " + strproveedor + " TP) " + strtipoprod + " M) " + strmarca + " MC) " + strmetodocosteo + " L) " + strlinea + " ES) " + strestado + " TP) " + strtamano + " PP) " + strpeso);


                    producto.vModificarProducto(pro);
                    MessageBox.Show("Producto ha sido Modificado.");

                    mantenimientoProductos prdu = new mantenimientoProductos();
                    prdu.MdiParent = this.MdiParent;
                    //prdu.vConsultarProductosActivos();
                    this.Hide();
                    prdu.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
