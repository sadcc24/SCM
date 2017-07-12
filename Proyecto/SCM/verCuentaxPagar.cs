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
    public partial class verCuentaxPagar : Form
    {
        public verCuentaxPagar()
        {
            InitializeComponent();
        }

        private void verCuentaxPagar_Load(object sender, EventArgs e)
        {
            try
            {
                orden_compra_BO oc = new orden_compra_BO();
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                DataTable dtProveedor = oc.verProveedor(1);
                //DataTable dtProveedor = oc.verProveedor(1);
                cboProveedor.DataSource = dtProveedor;
                cboProveedor.DisplayMember = "nombre_proveedor";
                cboProveedor.ValueMember = "idproveedor";
            } catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                orden_compra_BO oc = new orden_compra_BO();
                int prove = int.Parse(cboProveedor.SelectedValue.ToString());
                dt = oc.verCuentaxPagar(prove);
                grdInventario.DataSource = dt;
            }
            catch (Exception ex) { }
        }
    }
}
