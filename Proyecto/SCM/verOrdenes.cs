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
    public partial class verOrdenes : Form
    {
        public verOrdenes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ingresoOrdenCompra prdu = new ingresoOrdenCompra();
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
            orden_compra_BO prov = new orden_compra_BO();
            DataTable dt = new DataTable();
            dt = prov.verOC();
            grdInventario.DataSource = dt;
        }

        private void verOrdenes_Load(object sender, EventArgs e)
        {
            orden_compra_BO prov = new orden_compra_BO();
            DataTable dt = new DataTable();
            dt = prov.verOC();
            grdInventario.DataSource = dt;
        }
    }
}
