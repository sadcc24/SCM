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
        public seguimientoST(string idmovimiento, string idsolicitud)
        {
            InitializeComponent();
            txtIdMovimiento.Text = idmovimiento;
            txtIdSolicitud.Text = idsolicitud;
            CargaCBEstado();
            cargaDatosST(Convert.ToInt32(txtIdSolicitud.Text.Trim()), Convert.ToInt32(idmovimiento));
            ActualizaGridBitacora();
            
        }
        #region Funciones y Metodos
        private void ActualizaGridBitacora()
        {
            if (lblAvisoFlota.Text == "No Asignado") { button1.Enabled = false; }
            else { button1.Enabled = true; }
            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                dgvBitacoraST.DataSource = new SolicitudTransporte_BOL().BitacoraST(st); //.verDetalleST(st);
                dgvBitacoraST.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CargaCBEstado()
        {
            try
            {
                cmbEstados.DisplayMember = "nombreestadost";
                cmbEstados.ValueMember = "idestadost";
                cmbEstados.DataSource = new SolicitudTransporte_BOL().verEstadosST();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void cargaDatosST(int codigo, int mov)
        {
            try
            {

                SolicitudTransporte_Entity st = new SolicitudTransporte_BOL().verUnoST(codigo, mov);
                lblEstado.Text = st.NombreEstado;
                txtIdSolicitud.Text = st.idSolicitud.ToString();
                txtIdMovimiento.Text = st.idMovimiento.ToString();
                lblFechaCreacion.Text = st.FechaSolicitud.ToString();
                lblFechaSalida.Text = st.FechaRegreso.ToString();
                cmbEstados.SelectedValue = st.idEstado;
                lblNotas.Text = st.Notas.ToString();
                if(st.idVehiculo > 0)
                {
                    lblAvisoFlota.Text = "Vehiculo Asignado";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idST, idMov;
            idST = Convert.ToInt32(txtIdSolicitud.Text.Trim());
            idMov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
            cargaDatosST(idST, idMov);
            ActualizaGridBitacora();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede dejar el campo vacio");
            }
            else
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.Notas = txtDescripcion.Text.Trim();
                st.idEstado = Convert.ToInt32(cmbEstados.SelectedValue);
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                try
                {
                    new BO.SolicitudTransporte_BOL().seguimientoTracking(st);
                    MessageBox.Show("Registro Guardado Exitosamente");
                    //Actualiza la info del form
                    ActualizaGridBitacora();
                    int idMov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    cargaDatosST(Convert.ToInt32(txtIdSolicitud.Text.Trim()), idMov);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void seguimientoST_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignaTransporte_Click(object sender, EventArgs e)
        {
            string idst, idmov;
            idst = txtIdSolicitud.Text.Trim();
            idmov = txtIdMovimiento.Text.Trim();
            asignacionFlota ST = new asignacionFlota(idst, idmov);
            //seguimientoST ST = new seguimientoST(idmovimiento.ToString(), idsolicitud);
            ST.MdiParent = this.MdiParent;
            ST.Show();
        }

        private void btnTrayecto_Click(object sender, EventArgs e)
        {
            int idst, idmov;
            idst = Convert.ToInt32(txtIdSolicitud.Text.Trim());
            idmov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
            asignarTrayectoST ST = new asignarTrayectoST(idst, idmov);
            ST.MdiParent = this.MdiParent;
            ST.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idst, idmov;
            idst = Convert.ToInt32(txtIdSolicitud.Text.Trim());
            idmov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
            ingresoGastoGasolina ST = new ingresoGastoGasolina(idst);
            ST.MdiParent = this.MdiParent;
            ST.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string fullpath = System.IO.Path.Combine(Application.StartupPath, "ManualUsuarioSCM.pdf");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fullpath;
            proc.Start();
            proc.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
