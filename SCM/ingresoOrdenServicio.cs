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
    public partial class ingresoOrdenServicio : Form
    {
        public ingresoOrdenServicio(int codigo)
        {
            InitializeComponent();
            txtIdVehiculo.Text = codigo.ToString();
            ActualizarGrid();
            CargaTipoServicio();
            
        }

        public void ActualizarGrid()
        {
            int codVehiculo = Convert.ToInt32(txtIdVehiculo.Text.Trim());
            try
            {
                dgvServicios.DataSource = new Servicio_Vehiculo_BO().verTodosServicios(codVehiculo);
                dgvServicios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            vehiculo_Entity vh = new Vehiculo_BO().verUno(codVehiculo);

            lblKmsVehiculo.Text = vh._kms.ToString();
        }

        public void CargaTipoServicio()
        {
            try 
            {
                cmbTipoServicio.DisplayMember = "nombre";
                cmbTipoServicio.ValueMember = "idtiposerviciovh";
                cmbTipoServicio.DataSource = new BO.Servicio_Vehiculo_BO().verTipoServicio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        public void txtLimpiar()
        {
           // txtIdVehiculo.Clear();
            txtFactura.Clear();
            txtIdKms.Clear();
            txtKmsProx.Clear();
            txtTotal.Clear();
            txtIdOrdenServicio.Clear();
        }

        private void ingresoOrdenServicio_Load(object sender, EventArgs e)
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            decimal kmsvehiculo = Convert.ToDecimal(lblKmsVehiculo.Text);

            if (txtFactura.Text == "" || txtKmsProx.Text == "" || txtIdKms.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
            else
            {
                Servicio_Vehiculo_Entity st = new Servicio_Vehiculo_Entity();
                st.idtransporte = Convert.ToInt32(txtIdVehiculo.Text.Trim());
                st.factura = txtFactura.Text;
                st.fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                //st.fecha = dtpFecha.Value.Day + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Year;
                st.kmsactual = Convert.ToDecimal(txtIdKms.Text.Trim());
                st.kmsprox = Convert.ToDecimal(txtKmsProx.Text.Trim());
                st.monto = Convert.ToDecimal(txtTotal.Text.Trim());
                st.idTipoServicio = 1;// Convert.ToInt32(cmbTipoServicio.SelectedValue);

                if (st.kmsactual  < kmsvehiculo)
                {
                    MessageBox.Show("El kilometraje que está intentando ingresar es menor al kilometraje actual del vehiculo ");
                }
                else
                {

                    if (st.kmsactual > st.kmsprox)
                    {
                        MessageBox.Show("El kilometraje del próximo servicio debe de ser mayor al kilometraje actual");
                    }
                    else
                    {

                        if (txtIdOrdenServicio.Text == "0" || txtIdOrdenServicio.Text == "")
                        {
                            try
                            {
                                new BO.Servicio_Vehiculo_BO().guardarServicio(st);
                                MessageBox.Show("Registro guardado exitosamente");
                                txtLimpiar();
                                ActualizarGrid();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else
                        {
                            try
                            {
                                st.idorden = Convert.ToInt32(txtIdOrdenServicio.Text.Trim());
                                new BO.Servicio_Vehiculo_BO().actualizarServicio(st);
                                MessageBox.Show("Registro guardado exitosamente");
                                txtLimpiar();
                                ActualizarGrid();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            txtLimpiar();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvServicios.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            string idproducto = valor.ToString();
            Servicio_Vehiculo_Entity st = new Servicio_Vehiculo_BO().verServicio(valor);
            
            txtIdOrdenServicio.Text = st.idorden.ToString();
            txtIdVehiculo.Text = st.idtransporte.ToString();
            txtFactura.Text = st.factura;
            txtIdKms.Text = st.kmsactual.ToString();
            txtKmsProx.Text = st.kmsprox.ToString();
            txtTotal.Text = st.monto.ToString();
            
            //cmbTipoServicio.SelectedValue
            //dtpFecha.Value

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdOrdenServicio.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún servicio");
            }
            else
            {

                if (MessageBox.Show("Esta seguro de eliminar el registro", "Vehiculos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    int idorden = Convert.ToInt32(txtIdOrdenServicio.Text.Trim());
                    new BO.Servicio_Vehiculo_BO().eliminarServicio(idorden);

                    ActualizarGrid();
                    txtLimpiar();
                }
            }
        }

        private void txtIdKms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtKmsProx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLimpiar();
        }
    }
}
