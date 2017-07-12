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
    public partial class ingresoOrdenCompra : Form
    {
        public ingresoOrdenCompra()
        {
            InitializeComponent();
        }

        int idoc;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                string[] usuario = Globales.Usuario.CapturarUsuario();
                orden_compra_BO oc = new orden_compra_BO();
                DataTable dtBodega = oc.verBodega(int.Parse(empresa[0]));
                DataTable dtCentro = oc.verCentroCosto();
                DataTable dtCuenta = oc.verCuentaContable();
                DataTable dtProveedor = oc.verProveedor(1);
                DataTable dtMoneda = oc.verMoneda();
                cboBodega.DataSource = dtBodega;
                cboBodega.DisplayMember = "nombre_bodega";
                cboBodega.ValueMember = "idbodega";
                comboBox2.DataSource = dtCentro;
                comboBox2.DisplayMember = "nombre_centro";
                comboBox2.ValueMember = "idcentro";
                cboCuentaContable.DataSource = dtCuenta;
                cboCuentaContable.DisplayMember = "nombre";
                cboCuentaContable.ValueMember = "idCuenta";
                cboProveedor.DataSource = dtProveedor;
                cboProveedor.DisplayMember = "nombre_proveedor";
                cboProveedor.ValueMember = "idproveedor";
                comboBox3.DataSource = dtMoneda;
                comboBox3.DisplayMember = "nombre_moneda";
                comboBox3.ValueMember = "idmoneda";
            }
            catch(Exception Ex) { String error = Ex.ToString(); }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            string[] usuario = Globales.Usuario.CapturarUsuario();
            DataTable id = new DataTable();
            orden_compra_BO orden = new orden_compra_BO();
            orden_compra_Entity oc = new orden_compra_Entity();
            try
            {
                oc.id_sede = 1;
                oc.id_empresa = int.Parse(empresa[0]);
                oc.observaacion = txtObservacion.Text;
                oc.total = decimal.Parse(txtTotal.Text);
                oc.usuario = usuario[1];
                oc.fecha_creacion = DateTime.Now;
                oc.id_centro = int.Parse(comboBox2.SelectedValue.ToString());
                oc.id_bodega = int.Parse(cboBodega.SelectedValue.ToString());
                oc.id_proveedor = int.Parse(cboProveedor.SelectedValue.ToString());
                oc.id_moneda = int.Parse(comboBox3.SelectedValue.ToString());
                oc.id_estado = 1;
                oc.id_tipo_oc = 1;
                oc.id_documento = 1;
                oc.fecha_vencimiento = DateTime.Now;
                oc.id_cuenta = int.Parse(cboCuentaContable.SelectedValue.ToString());
                orden.insertOC(oc);
                id = orden.verId();
                idoc = int.Parse(id.Rows[0][0].ToString());
                txtObservacion.Text = "";
                txtTotal.Text = "";
                


            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Registro de Datos");
            }
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
