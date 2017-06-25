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
            if (codigov != 0)
            {
                buscarUno(codigov);
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
            new BO.Vehiculo_BO().insertarVhcBO(vhc);
         
        }

        #region Funciones y Metodos
        private void buscarUno(int codigo)
        {
            vehiculo_Entity eVehiculo = new Vehiculo_BO().verUno(codigo);
            //txtCodVehiculo = Convert.ToString(eVehiculo._cod_vehiculo);
            txtMotor.Text = eVehiculo._motor;
            txtModelo.Text = eVehiculo._modelo;
            txtMarca.Text = eVehiculo._marca;
            txtLinea.Text = eVehiculo._linea;
            txtColor.Text = eVehiculo._color;
            txtChasis.Text = eVehiculo._chasis;
            txtPlaca.Text = eVehiculo._placa;
            
            //txtID.Text = Convert.ToString(pCliente.Id);
            
        }
           
        #endregion
    }
}
