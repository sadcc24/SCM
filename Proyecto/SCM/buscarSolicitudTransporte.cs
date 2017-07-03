using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;

namespace SCM
{
    public partial class buscarSolicitudTransporte : Form
    {
        public buscarSolicitudTransporte()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ingresoSolicitudTransporte vehiculo = new ingresoSolicitudTransporte(0);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();

        }

        #region Funciones y metodos
        private void ActualizarForm()
        {
            try
            {
                dgvSolicitud.DataSource = new SolicitudTransporte_BOL().verTodoST(); //N_Cliente().GetAll();
                dgvSolicitud.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        #endregion

        private void buscarSolicitudTransporte_Load(object sender, EventArgs e)
        {
            ActualizarForm();
        }

        private void dgvSolicitud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvSolicitud.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            //int codigo = Convert.ToInt32(valor);
            ingresoSolicitudTransporte ST = new ingresoSolicitudTransporte(valor);
            ST.MdiParent = this.MdiParent;
            ST.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.idSolicitud = Convert.ToInt32(txtSolicit.Text.Trim());
                dgvSolicitud.DataSource = new SolicitudTransporte_BOL().verST_Single(st);
                dgvSolicitud.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarForm();
        }

        private void txtSolicit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }   
        }
    }
}
