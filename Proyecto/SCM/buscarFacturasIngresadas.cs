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
{ // Programador : Pamela Jacqueline Selman David
  // Analista : Pamela Jacqueline Selman David
    public partial class buscarFacturasIngresadas : Form
    {
        public buscarFacturasIngresadas()
        {
            InitializeComponent();
        }

        private void txtOC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buscarFacturasIngresadas_Load(object sender, EventArgs e)
        {
            factura_proveedores_BO marcas = new factura_proveedores_BO();
            factura_proveedores_Entity fac = new factura_proveedores_Entity();
            fac.id_bodega = Convert.ToInt32(lblBodega.Text.ToString());
            fac.id_proveedor = Convert.ToInt32(lblProveedor.Text.ToString());
            fac.id_estado_factura = 3;
            grdInventario.DataSource = marcas.verFacturas(fac);
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consultar Facturas Pagadas.");
        }

        private void grdInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmovimiento,correlativo,total,serie;
            idmovimiento = grdInventario.Rows[e.RowIndex].Cells[6].Value.ToString();
            correlativo = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();
            total = grdInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            serie = grdInventario.Rows[e.RowIndex].Cells[7].Value.ToString();
            factura_proveedores_BO fact = new factura_proveedores_BO();
            factura_proveedores_Entity fac = new factura_proveedores_Entity();
            fac.id_bodega = Convert.ToInt32(lblBodega.Text.ToString());
            fac.id_proveedor = Convert.ToInt32(lblProveedor.Text.ToString());
            fac.id_estado_factura = 3;

            ingresoInventario frm = new ingresoInventario();
            fac.id_movimiento = Convert.ToInt32(idmovimiento);
            frm.grdInventario.DataSource = fact.detalleFactura(fac);
            frm.cmbBodega.SelectedValue = lblBodega.Text.ToString();
            frm.cmbProveedor.SelectedValue = lblProveedor.Text.ToString();
            frm.cmbTipoMovimiento.SelectedValue = lbltipomov.Text.ToString();
            frm.txtDocRef.Text = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm.txtcorr.Text = correlativo;
            frm.txtbodega.Text = lblBodega.Text;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string fullpath = System.IO.Path.Combine(Application.StartupPath, "ManualUsuarioSCM.pdf");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fullpath;
            proc.Start();
            proc.Close();
        }

        //private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
