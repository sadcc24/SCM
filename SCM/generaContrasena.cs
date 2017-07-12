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
    public partial class generaContrasena : Form
    {
        public generaContrasena()
        {
            InitializeComponent();
        }

        private void generaContrasena_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            //string[] empresa = Globales.Empresa.CapturarEmpresa();
            //this.lblempresa.Text = "(" + empresa[0] + ")" + empresa[1];
            lblempresa.Visible = false;
            clsProductos_BO bodega = new clsProductos_BO();
            cmbBodega.DataSource = bodega.vdtComboBodega();
            cmbBodega.ValueMember = "ID";
            cmbBodega.DisplayMember = "Descripcion";

            cmbProveedor.DataSource = bodega.vdtComboProveedor();
            cmbProveedor.ValueMember = "ID";
            cmbProveedor.DisplayMember = "Descripcion";
        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            clsInventarios_BO facturas = new clsInventarios_BO();
            clsInventarios_Entity fac = new clsInventarios_Entity();
            string idproveedor;
            idproveedor = cmbProveedor.SelectedValue.ToString();
            fac.strIdProveedor = idproveedor;
            fac.strBodega = cmbBodega.SelectedValue.ToString();
            grdFactura.DataSource = facturas.vConsultarFacturas(fac);
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Buscar Filtros.");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string idfactura,/*corrfactura,idserie,total,*/saldo/*,fecha,idproveedor,idbodega,idmovimiento*/;
            try
            {
                if (grdFactura.Rows.Count > 0)
                {
                    clsInventarios_Entity bod = new clsInventarios_Entity();
                    clsInventarios_BO bodega = new clsInventarios_BO();
                    bod.strBodega = cmbBodega.SelectedValue.ToString();
                    bod.strIdProveedor = cmbProveedor.SelectedValue.ToString();
                    bodega.vInsertarEncabezadoContrasena(bod);
                    
                    int id;
                    id = Convert.ToInt32(bodega.vConsultaUltimoID().Rows[0][0].ToString());
                    //    MessageBox.Show(id.ToString());
                   
                    foreach (DataGridViewRow fila in grdFactura.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            idfactura = fila.Cells[1].Value.ToString();
                            saldo = fila.Cells[5].Value.ToString();

                            clsInventarios_Entity bo = new clsInventarios_Entity();
                            clsInventarios_BO bodeg = new clsInventarios_BO();
                            bo.strIdContrasena = id.ToString();
                            bo.strIdFactura = idfactura;
                            bo.strmonto = Convert.ToInt32(Convert.ToDecimal(saldo)).ToString();
                           bodeg.vInsertarDetalleContrasena(bo);

                            //  idproveedor = fila.Cells[7].Value.ToString();
                            //  idbodega = fila.Cells[8].Value.ToString();
                               //MessageBox.Show(idfactura + "__" + id.ToString() + "__" + saldo);
                        }
                    }
                    MessageBox.Show("CONTRASEÑA HA SIDO GUARDADA.");
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Generar Contraseña.");
                }
                     
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
