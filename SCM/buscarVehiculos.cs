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
    public partial class buscarVehiculos : Form
    {
        public buscarVehiculos()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }
             

        private void buscarVehiculos_Load(object sender, EventArgs e)
        {
            ActualizarForm();   
        }

        private void grdVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!(e.RowIndex > -1))
            {
                return;
            }

            DataGridViewRow row = grdVehiculos.Rows[e.RowIndex];
            decimal valor = (decimal)row.Cells[0].Value;
            int codigo = Convert.ToInt32(valor);
            ingresoVehiculo vehiculo = new ingresoVehiculo(codigo);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();
        }

        #region Funciones y Metodos
        private void ActualizarForm()
        {
            try
            {
                grdVehiculos.DataSource = new Vehiculo_BO().verTodosVehiculos(); //N_Cliente().GetAll();
                grdVehiculos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BuscarUno()
        {

        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
