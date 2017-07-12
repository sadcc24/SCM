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

namespace SCM
{
    public partial class mantenimientoEstadoOrdenCompra : Form
    {
        public mantenimientoEstadoOrdenCompra()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstadoOrdenCompra prdu = new EstadoOrdenCompra();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtCodigo.ReadOnly = true;
            this.Hide();
            //prdu.btnEditar.Enabled = false;
            //prdu.btnEliminar.Enabled = false;
            prdu.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            estado_orden_BO prov = new estado_orden_BO();
            DataTable dt = new DataTable();
            dt = prov.verEstados();
            grdInventario.DataSource = dt;
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = grdInventario.Rows[e.RowIndex].Index.ToString();
            string cellValue = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();

            string idProveedor = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nombre = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();


            EstadoOrdenCompra frm = new EstadoOrdenCompra();
            frm.txtCodigo.Text = idProveedor;
            frm.txtNombre.Text = nombre;



            frm.btnEditar.Enabled = true;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtCodigo.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }

        private void mantenimientoEstadoOrdenCompra_Load(object sender, EventArgs e)
        {
            estado_orden_BO prov = new estado_orden_BO();
            DataTable dt = new DataTable();
            dt = prov.verEstados();
            grdInventario.DataSource = dt;
        }
    }
}
