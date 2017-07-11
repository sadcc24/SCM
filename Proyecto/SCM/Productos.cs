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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
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
            //cmbBodega.DataSource = bodega.vdtComboBodega();
            //cmbBodega.ValueMember = "ID";
            //cmbBodega.DisplayMember = "Descripcion";

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


            clsProductos_Entity prod = new clsProductos_Entity();
            prod.strtipou = "1";
            cmbUnidadTamano.DataSource = bodega.vdtComboUnidad(prod);
            cmbUnidadTamano.ValueMember = "ID";
            cmbUnidadTamano.DisplayMember = "Descripcion";

            prod.strtipou = "2";
            cmbUnidadPeso.DataSource = bodega.vdtComboUnidad(prod);
            cmbUnidadPeso.ValueMember = "ID";
            cmbUnidadPeso.DisplayMember = "Descripcion";


        }
        

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
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Eliminar Productos.");
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
        string strproducto, strproveedor, strtipoprod, strmarca, strmetodocosteo, strlinea, strstockmin, strstockmax, strtamano, strpeso, strutamano, strupeso;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("Debe agregar el nombre del PRODUCTO.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtsmin.Text))
                {
                    MessageBox.Show("Debe agregar el stock mínimo del PRODUCTO.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtsmax.Text))
                    {
                        MessageBox.Show("Debe agregar el stock máximo del PRODUCTO.");
                        return;
                    }
                    else{
                        if (string.IsNullOrEmpty(txttam.Text))
                        {
                            MessageBox.Show("Debe agregar el el tamaño del PRODUCTO.");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtpeso.Text))
                            {
                                MessageBox.Show("Debe agregar el el peso del PRODUCTO.");
                                return;
                            }
                            else
                            {
                                
                                strproducto = txtProducto.Text;
                                strproveedor = cmbProveedor.SelectedValue.ToString();
                                strtipoprod = cmbTipProd.SelectedValue.ToString();
                                strmarca = cmbMarca.SelectedValue.ToString();
                                strmetodocosteo = cmbmetodo.SelectedValue.ToString();
                                strlinea = cmbLinea.SelectedValue.ToString();
                                strstockmin = txtsmin.Text;
                                strstockmax = txtsmax.Text;
                                strtamano = txttam.Text;
                                strpeso = txtpeso.Text;
                                strutamano = cmbUnidadTamano.SelectedValue.ToString();
                                strupeso = cmbUnidadPeso.SelectedValue.ToString();

                           try
                                {
                                    clsProductos_Entity pro = new clsProductos_Entity();
                                    clsProductos_BO producto = new clsProductos_BO();
                                    pro.strProducto = strproducto;                                                                  
                                    pro.strProveedor = strproveedor;
                                    pro.strTipoProducto = strtipoprod;
                                    pro.strMarca = strmarca;
                                    pro.strMetodoCosteo = strmetodocosteo;
                                    pro.strLinea = strlinea;
                                    pro.strsmin  = strstockmin;
                                    pro.strsmax = strstockmax;
                                    pro.strTamano = strtamano;
                                    pro.strPeso = strpeso;
                                    pro.struTamano = strutamano;
                                    pro.struPeso = strupeso;

                                    //string[] empresa = Globales.Empresa.CapturarEmpresa();
                                    //pro.strIdEmpresa = empresa[0];
                                    pro.strIdEmpresa = "1";


                                    producto.vInsertarProducto(pro);
                                    MessageBox.Show("Producto ha sido Guardado.");
                                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Guardar Productos.");
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe agregar el ID del PRODUCTO.");
                return;
            }
            else
            {

                strproducto = txtProducto.Text;
                strproveedor = cmbProveedor.SelectedValue.ToString();
                strtipoprod = cmbTipProd.SelectedValue.ToString();
                strmarca = cmbMarca.SelectedValue.ToString();
                strmetodocosteo = cmbmetodo.SelectedValue.ToString();
                strlinea = cmbLinea.SelectedValue.ToString();
                strstockmin = txtsmin.Text;
                strstockmax = txtsmax.Text;
                strtamano = txttam.Text;
                strpeso = txtpeso.Text;
                strutamano = cmbUnidadTamano.SelectedValue.ToString();
                strupeso = cmbUnidadPeso.SelectedValue.ToString();

                try
                {
                    clsProductos_Entity pro = new clsProductos_Entity();
                    clsProductos_BO producto = new clsProductos_BO();
                    pro.strProducto = strproducto;
                    pro.strProveedor = strproveedor;
                    pro.strTipoProducto = strtipoprod;
                    pro.strMarca = strmarca;
                    pro.strMetodoCosteo = strmetodocosteo;
                    pro.strLinea = strlinea;
                    pro.strsmin = strstockmin;
                    pro.strsmax = strstockmax;
                    pro.strTamano = strtamano;
                    pro.strPeso = strpeso;
                    pro.struTamano = strutamano;
                    pro.struPeso = strupeso;
                    pro.strIdProd = txtID.Text;


                    producto.vModificarProducto(pro);
                    MessageBox.Show("Producto ha sido Actualizado.");
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Editar Productos.");
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
