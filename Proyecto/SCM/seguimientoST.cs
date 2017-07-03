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
    public partial class seguimientoST : Form
    {
        public seguimientoST(string codigo)
        {
            InitializeComponent();
            txtIdSolicitud.Text = codigo;
            ActualizaGrid();

        }
        #region Funciones y Metodos
        private void ActualizaGrid()
        {
            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                dgvBitacoraST.DataSource = new SolicitudTransporte_BOL().BitacoraST(st); //.verDetalleST(st);
                dgvBitacoraST.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void seguimientoST_Load(object sender, EventArgs e)
        {

        }
    }
}
