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
    public partial class buscarOC : Form
    {
        public buscarOC()
        {
            InitializeComponent();
        }

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grdInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string oc;
            factura_proveedores_BO fact = new factura_proveedores_BO();
            factura_proveedores_Entity fac = new factura_proveedores_Entity();
            fac.id_bodega = Convert.ToInt32(lblBodega.Text.ToString());
            fac.id_proveedor = Convert.ToInt32(lblProveedor.Text.ToString());
            fac.id_estado_factura = 3;
            oc = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            ingresoInventario frm = new ingresoInventario();
            fac.strOC = oc;
            frm.grdInventario.DataSource = fact.detalleOC(fac);
            frm.cmbBodega.SelectedValue = lblBodega.Text.ToString();
            frm.cmbProveedor.SelectedValue = lblProveedor.Text.ToString();
            frm.txtDocRef.Text = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm.txtbodega.Text = lblBodega.Text;
            frm.txtTotal.Text = grdInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buscarOC_Load(object sender, EventArgs e)
        {
            factura_proveedores_BO marcas = new factura_proveedores_BO();
            factura_proveedores_Entity fac = new factura_proveedores_Entity();
            fac.id_bodega = Convert.ToInt32(lblBodega.Text.ToString());
            fac.id_proveedor = Convert.ToInt32(lblProveedor.Text.ToString());
            fac.id_estado_factura = 2;
            grdInventario.DataSource = marcas.verOC(fac);
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consultar Ordenes de Compra Autorizadas.");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
