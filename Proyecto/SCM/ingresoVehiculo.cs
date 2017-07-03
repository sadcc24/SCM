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

namespace SCM
{
    public partial class ingresoVehiculo : Form
    {
        public ingresoVehiculo(int codigov)
        {
            InitializeComponent();
            txtCodVehiculo.Text = codigov.ToString();
            label3.Text = codigov.ToString();
            CargaCBTipo();
            if (codigov != 0)
            {
                buscarUno(codigov);
                txtDisabled();
            }
        }

        private void btnOrdenServicio_Click(object sender, EventArgs e)
        {
            ingresoOrdenServicio ios = new ingresoOrdenServicio();
            ios.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vehiculo_Entity vhc = new vehiculo_Entity();
            vhc._motor = txtMotor.Text.Trim();
            vhc._modelo = txtModelo.Text.Trim();
            vhc._marca = txtMarca.Text.Trim();
            vhc._linea = txtLinea.Text.Trim();
            vhc._color = txtColor.Text.Trim();
            vhc._chasis = txtChasis.Text.Trim();
            vhc._placa = txtPlaca.Text.Trim();
            vhc._tipovehiculo = Convert.ToInt32(cmbTipo.SelectedValue);

            if (txtCodVehiculo.Text != "0")
            {
                try
                {
                    vhc._cod_vehiculo = Convert.ToInt32(txtCodVehiculo.Text);
                    new BO.Vehiculo_BO().actualizaVehiculoBO(vhc);
                    MessageBox.Show("Vehiculo Actualizado Exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                try
                {
                    new BO.Vehiculo_BO().insertarVhcBO(vhc);
                    MessageBox.Show("Vehiculo Ingresado Exitosamente");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            txtDisabled();
        }

        #region Funciones y Metodos
        private void buscarUno(int codigo)
        {
            vehiculo_Entity eVehiculo = new Vehiculo_BO().verUno(codigo);
            txtMotor.Text = eVehiculo._motor;
            txtModelo.Text = eVehiculo._modelo;
            txtMarca.Text = eVehiculo._marca;
            txtLinea.Text = eVehiculo._linea;
            txtColor.Text = eVehiculo._color;
            txtChasis.Text = eVehiculo._chasis;
            txtPlaca.Text = eVehiculo._placa;       
        }

        private void limpiar()
        {
            txtChasis.Clear();
            txtCodVehiculo.Text = "0";
            txtColor.Clear();
            txtLinea.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtMotor.Clear();
            txtPlaca.Clear();
            
            
        }

        private void txtDisabled()
        {
            txtChasis.Enabled = false;
            txtColor.Enabled = false;
            txtLinea.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtMotor.Enabled = false;
            txtPlaca.Enabled = false;
            cmbTipo.Enabled = false;
        }

        private void txtEnabled()
        {
            txtChasis.Enabled = true;
            txtColor.Enabled = true;
            txtLinea.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtMotor.Enabled = true;
            txtPlaca.Enabled = true;
            cmbTipo.Enabled = true;

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
            limpiar();
            txtDisabled();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtEnabled();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
