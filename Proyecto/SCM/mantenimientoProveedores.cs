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
    public partial class mantenimientoProveedores : Form
    {
        public mantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Proveedores prdu = new Proveedores();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtCodigo.ReadOnly = true;
            this.Hide();
            //prdu.btnEditar.Enabled = false;
            //prdu.btnEliminar.Enabled = false;
            prdu.Show();
        }

        private void mantenimientoProveedores_Load(object sender, EventArgs e)
        {
            proveedores_BO prov = new proveedores_BO();
            DataTable dt = new DataTable();
            dt = prov.verProveedores();
            grdInventario.DataSource = dt;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            proveedores_BO prov = new proveedores_BO();
            DataTable dt = new DataTable();
            dt = prov.verProveedores();
            grdInventario.DataSource = dt;
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = grdInventario.Rows[e.RowIndex].Index.ToString();
            string cellValue = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();

            string idProveedor = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nombre = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();
            string direccion = grdInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            string telefono = grdInventario.Rows[e.RowIndex].Cells[3].Value.ToString();
            string nit = grdInventario.Rows[e.RowIndex].Cells[4].Value.ToString();

            Proveedores frm = new Proveedores();
            frm.txtCodigo.Text = idProveedor;
            frm.txtNombre.Text = nombre;
            frm.txtDireccion.Text = direccion;
            frm.txtTelefono.Text = telefono;
            frm.txtNit.Text = nit;
            

            frm.btnEditar.Enabled = true;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtCodigo.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }
    }
}
