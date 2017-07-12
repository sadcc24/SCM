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
    public partial class mantenimientoTrayecto : Form
    {
        public mantenimientoTrayecto()
        {
            InitializeComponent();
        }

        private void mantenimientoTrayecto_Load(object sender, EventArgs e)
        {
            tipo_trayecto_BO prov = new tipo_trayecto_BO();
            DataTable dt = new DataTable();
            dt = prov.verTipo();
            grdInventario.DataSource = dt;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            TipoVehiculo prdu = new TipoVehiculo();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtCodigo.ReadOnly = true;
            this.Hide();
            //prdu.btnEditar.Enabled = false;
            //prdu.btnEliminar.Enabled = false;
            prdu.Show();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            tipo_trayecto_BO prov = new tipo_trayecto_BO();
            DataTable dt = new DataTable();
            dt = prov.verTipo();
            grdInventario.DataSource = dt;
        }

        private void grdInventario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = grdInventario.Rows[e.RowIndex].Index.ToString();
            string cellValue = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();

            string idProveedor = grdInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nombre = grdInventario.Rows[e.RowIndex].Cells[1].Value.ToString();

            Trayecto frm = new Trayecto();
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
    }
}
