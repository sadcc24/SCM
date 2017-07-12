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
    public partial class asignacionFlota : Form
    {
        public asignacionFlota(string idst, string idmov)
        {
            InitializeComponent();
            txtIdSolicitud.Text = idst;
            txtIdMovimiento.Text = idmov;
            actualizarFrom(idst, idmov);

        }

        public void actualizarFrom(string idst, string idmov)
        {
            gdvVehiculos(1);
            gridEmpleados(1);
            CargaCBTipoVehiculo();
            cargaDatosST(Convert.ToInt32(idst), Convert.ToInt32(idmov));
        }

        #region Funciones

        private void CargaCBTipoVehiculo()
        {
            try
            {
                cmbTipoVehiculoB.DisplayMember = "nombretipotrans";
                cmbTipoVehiculoB.ValueMember = "idtipotrans";
                cmbTipoVehiculoB.DataSource = new Vehiculo_BO().verTipoVH();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void gdvVehiculos(int tipo)
        {
            vehiculo_Entity vc = new vehiculo_Entity();
            //vc._placa = txtPlaca.Text.Trim();
            if (tipo == 2)
            {
                vc._tipovehiculo = Convert.ToInt32(cmbTipoVehiculoB.SelectedValue);
                if(txtCodVehiculoB.Text != "")
                {
                    vc._cod_vehiculo = Convert.ToInt32(txtCodVehiculoB.Text.Trim());
                }
            }

            try
            {
                dgvVehiculos.DataSource = new Vehiculo_BO().verVehiculosDisponibles(vc);
                dgvVehiculos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gridEmpleados(int tipo)
        {
            int codigo = 0; 
            int puesto = 0;
            if(tipo == 2)
            {
                if(txtIdEmpleadoB.Text != "")
                {
                    codigo = Convert.ToInt32(txtIdEmpleadoB.Text.Trim());
                }
                puesto = Convert.ToInt32(cmbPuestoEmpB.SelectedValue);
            }
            try
            {
                dgvPersonal.DataSource = new SolicitudTransporte_BOL().historialViajesEmpleadosST(codigo, puesto);
                dgvPersonal.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        #endregion
        private void asignacionFlota_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gdvVehiculos(2);
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvVehiculos.Rows[e.RowIndex];
            int idvehiculo = (int)row.Cells[0].Value;
            // Carga los datos seleccionados del grid a las textbox
            if (lblAvisoVehiculo.Text == "0")
            {
                txtIdVehiculo.Text = idvehiculo.ToString();
                txtTipoVehiculo.Text = (string)row.Cells[1].Value;
                txtPlaca.Text = (string)row.Cells[4].Value;
                decimal kms = (decimal)row.Cells[5].Value;
                txtKMS.Text = kms.ToString();
            }
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            st.idVehiculo = idvehiculo;
            st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
            try
            {
                dgvHistorialVehiculos.DataSource = new SolicitudTransporte_BOL().historialVehiculosST(st);
                dgvHistorialVehiculos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        public void cargaDatosST(int codigo, int mov)
        {
            //Codigo para realizar la verificacion de Transporte
           try
                {

                    SolicitudTransporte_Entity st = new SolicitudTransporte_BOL().verUnoST(codigo, mov);
                    lblAvisoVehiculo.Text = st.idVehiculo.ToString();
                    if (lblAvisoVehiculo.Text == "" || lblAvisoVehiculo.Text == "0")
                    {
                        lblAvisoVehiculo.Text = "0";
                        lblMensajeVehiculo.Text = "No se ha asingado ningun vehiculo";
                        txtPlaca.Clear();
                        txtTipoVehiculo.Clear();
                        txtKMS.Clear();
                }
                    else
                    {
                        txtIdVehiculo.Text = st.idVehiculo.ToString();
                        lblMensajeVehiculo.Text = "La solicitud ya tiene asignado el vehiculo";
        
                        vehiculo_Entity eVehiculo = new Vehiculo_BO().verUno(st.idVehiculo);
                        txtPlaca.Text = eVehiculo._placa ;
                        txtTipoVehiculo.Text = eVehiculo._nombretipov;
                        txtKMS.Text = eVehiculo._kms.ToString();
                     }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            //Codigo para realizar la verificacion de asingacion de Tranpsortistas

            try
            {

                Transportistas_ST_Entity st = new ST_Asignaciones_BOL().verEmpleadoAsignado(codigo);

                lblAvisoPersonal.Text = st.codigoEmpleado.ToString();
                //lblAvisoVehiculo.Text = st.idVehiculo.ToString();
                if (lblAvisoPersonal.Text == "" || lblAvisoPersonal.Text == "0")
                {
                    //lblAvisoVehiculo.Text = "0";
                    lblMensajePersonal.Text = "No se ha asingado ningun empleado";
                    txtCodigoEmpleado.Clear();
                    txtNombreEmplead.Clear();
                    txtLicencia.Clear();
                }
                else
                {
                    txtCodigoEmpleado.Text = st.codigoEmpleado.ToString();
                    
                    lblMensajePersonal.Text = "La solicitud ya tiene asignado un empleado";

                    //vehiculo_Entity eVehiculo = new Vehiculo_BO().verUno(st.idVehiculo);
                    Transportistas_ST_Entity eEmpleado = new ST_Asignaciones_BOL().verEmpleadoAsignado(codigo);
                    txtCodigoEmpleado.Text = st.codigoEmpleado.ToString();
                    txtNombreEmplead.Text = st.nombreEmpleado.ToString();
                    txtLicencia.Text = st.licenciaEmpleado.ToString();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idst, idmov;
            idst = txtIdSolicitud.Text;
            idmov = txtIdMovimiento.Text;
            actualizarFrom(idst, idmov);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdVehiculo.Text == "" || txtIdVehiculo.Text == "0")
            {
                MessageBox.Show("No ha seleccionado ningun vehiculo");
            } else
            {
                if (lblAvisoVehiculo.Text == "0")
                {

                    try
                    {
                        SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                        st.idVehiculo = Convert.ToInt32(txtIdVehiculo.Text.Trim());
                        st.idUsuario = 1;
                        st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                        st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                        new BO.ST_Asignaciones_BOL().asignaVehiuloST(st);
                        MessageBox.Show("Vehiculo Asignado Exitosamente");
                        actualizarFrom(txtIdSolicitud.Text.Trim(), txtIdMovimiento.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }else
                {
                    MessageBox.Show("Ya se ha asignado un vehiculo");
                }
            }


        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvPersonal.Rows[e.RowIndex];
            int idempleado = (int)row.Cells[0].Value;
            if (lblAvisoPersonal.Text == "0" || lblAvisoPersonal.Text == "")
            {
                txtCodigoEmpleado.Text = idempleado.ToString();
                txtNombreEmplead.Text = (string)row.Cells[1].Value;
                txtLicencia.Text = (string)row.Cells[2].Value;
            }
            try
            {
                dgvHistoricoPersonal.DataSource = new SolicitudTransporte_BOL().histViajePorEmpleado(idempleado);
                dgvHistoricoPersonal.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridEmpleados(2);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdVehiculo.Text == "" || txtIdVehiculo.Text == "0")
            {
                MessageBox.Show("No ha seleccionado ningun vehiculo");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de eliminar el vehiculo de la solicitud", "Solicitud de Transporte",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    try
                    {
                        SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                        st.idVehiculo = Convert.ToInt32(txtIdVehiculo.Text.Trim());
                        st.idUsuario = 1;
                        st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                        st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                        new BO.ST_Asignaciones_BOL().eliminaVehiuloST(st);
                        MessageBox.Show("El vehiculo se ha eliminado exitosamente de la solicitud");
                        actualizarFrom(txtIdSolicitud.Text.Trim(), txtIdMovimiento.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            //Guardar Transportistas
            if (txtCodigoEmpleado.Text == "" || txtCodigoEmpleado.Text == "0")
            {
                MessageBox.Show("No ha seleccionado ningun transportistas");
            }
            else
            {
                if (lblAvisoPersonal.Text == "" || lblAvisoPersonal.Text == "0")
                {
                    try
                    {
                        Transportistas_ST_Entity tst = new Transportistas_ST_Entity();
                        tst.codigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text.Trim());
                        tst.idEmpresa = 1;
                        tst.idUsuario = 1;
                        tst.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                        tst.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                        new BO.ST_Asignaciones_BOL().guardarTranortista(tst);
                        MessageBox.Show("Conductor Asignado Correctamente");
                        actualizarFrom(txtIdSolicitud.Text.Trim(), txtIdMovimiento.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }else
                {
                    MessageBox.Show("Ya hay conductores asignados, debe de eliminar el anterior para asignar uno nuevo");
                }
            }

        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            //Eliminar Transportista
            if (txtCodigoEmpleado.Text == "" || txtCodigoEmpleado.Text == "0")
            {
                MessageBox.Show("No ha seleccionado ningun empleado");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de eliminar al conductor de la solicitud", "Solicitud de Transporte",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    try
                    {
                        Transportistas_ST_Entity st = new Transportistas_ST_Entity();
                        st.codigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text.Trim());
                        st.idUsuario = 1;
                        st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                        st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                        new BO.ST_Asignaciones_BOL().eliminaPersonalST(st);
                        MessageBox.Show("Se ha eliminado al concutor exitosamente de la solicitud");
                        actualizarFrom(txtIdSolicitud.Text.Trim(), txtIdMovimiento.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {

        }
    }
}
