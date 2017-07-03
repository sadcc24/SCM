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
            ActualizarForm(1);
            CargaCBTipo();
        }

        private void grdVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!(e.RowIndex > -1))
            {
                return;
            }

            DataGridViewRow row = grdVehiculos.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            //int codigo = Convert.ToInt32(valor);
            ingresoVehiculo vehiculo = new ingresoVehiculo(valor);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();
        }

        #region Funciones y Metodos
        private void ActualizarForm(int tipo)
        {
            vehiculo_Entity vc = new vehiculo_Entity();
            vc._chasis = txtChasis.Text.Trim();
            vc._marca = txtMarca.Text.Trim();
            vc._modelo = txtModelo.Text.Trim();
            vc._motor = txtMotor.Text.Trim();
            vc._placa = txtPlaca.Text.Trim();
            if(tipo == 2)
            {
                vc._tipovehiculo = Convert.ToInt32(cmbTipo.SelectedValue);
            }
            
            try
            {
                grdVehiculos.DataSource = new Vehiculo_BO().verTodosVehiculos(vc);
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

        private void CargaCBTipo()
        {
            try
            {
                cmbTipo.DisplayMember = "nombretipotrans";
                cmbTipo.ValueMember = "idtipotrans";
                cmbTipo.DataSource = new Vehiculo_BO().verTipoVH();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ingresoVehiculo vehiculo = new ingresoVehiculo(0);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarForm(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarForm(2);
        }
    }
}
