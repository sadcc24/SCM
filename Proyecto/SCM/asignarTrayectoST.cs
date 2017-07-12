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
    public partial class asignarTrayectoST : Form
    {
        public asignarTrayectoST(int idst, int idmov)
        {
            InitializeComponent();
            buscarTracyeto(idst, idmov);
            if(txtIdTrayecto.Text != "")
            {
                Bloquear();
            }
            
        }

        public void Bloquear()
        {
            dtpFechaRegreso.Enabled = false;
            dtpFechaSalida.Enabled = false;
            txtDestino.Enabled = false;
            txtOrigen.Enabled = false;
            txtKms.Enabled = false;
        }

        public void Desbloquear()
        {
            dtpFechaRegreso.Enabled = true;
            dtpFechaSalida.Enabled = true;
            txtDestino.Enabled = true;
            txtOrigen.Enabled = true;
            txtKms.Enabled = true;
        }
        public void buscarTracyeto(int idst, int idmov)
        {
            txtIdSolicitud.Text = idst.ToString();
            txtIdMovimiento.Text = idmov.ToString();
            try
            {
                TrayectoST_Entity st = new ST_Asignaciones_BOL().verTrayecto(idst, idmov);

                txtDestino.Text = st.destino;
                txtOrigen.Text = st.origen;
                txtKms.Text = st.kms.ToString();
               // dtpFechaRegreso = Convert.ToDateTime(st.fechallegada);
                txtIdTrayecto.Text = st.idTrayecto.ToString();
              
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdTrayecto.Text == "" || txtIdTrayecto.Text == "0")
            {
                try
                {
                    TrayectoST_Entity st = new TrayectoST_Entity();
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    //dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                    st.fechasalida = dtpFechaSalida.Value.Year + "/"+ dtpFechaSalida.Value.Month + "/" + dtpFechaSalida.Value.Day;
                    st.fechallegada = dtpFechaRegreso.Value.Year + "/" + dtpFechaRegreso.Value.Month + "/" + dtpFechaRegreso.Value.Day;
                    st.origen = txtOrigen.Text;
                    st.destino = txtDestino.Text;
                    st.kms = Convert.ToDecimal(txtKms.Text.Trim());

                    new BO.ST_Asignaciones_BOL().guardarTrayecto(st);
                    MessageBox.Show("Se ha guardado el trayecto exitosamente");
                    int idst, idmov;
                    idst = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    idmov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    buscarTracyeto(idst, idmov);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                try
                {
                    TrayectoST_Entity st = new TrayectoST_Entity();
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    st.fechasalida = dtpFechaSalida.Value.Year + "/" + dtpFechaSalida.Value.Month + "/" + dtpFechaSalida.Value.Day;
                    st.fechallegada = dtpFechaRegreso.Value.Year + "/" + dtpFechaRegreso.Value.Month + "/" + dtpFechaRegreso.Value.Day;
                    st.origen = txtOrigen.Text;
                    st.destino = txtDestino.Text;
                    st.kms = Convert.ToDecimal(txtKms.Text.Trim());

                    new BO.ST_Asignaciones_BOL().actualiaTrayecto(st);
                    MessageBox.Show("Se ha actualizado el trayecto exitosamente");
                    int idst, idmov;
                    idst = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    idmov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    buscarTracyeto(idst, idmov);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void asignarTrayectoST_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TrayectoST_Entity st = new TrayectoST_Entity();
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                st.fechasalida = dtpFechaSalida.Text;
                st.fechallegada = dtpFechaRegreso.Text;
                st.origen = txtOrigen.Text;
                st.destino = txtDestino.Text;
                st.kms = Convert.ToDecimal(txtKms.Text.Trim());

                new BO.ST_Asignaciones_BOL().eliminaTrayecto(st);
                MessageBox.Show("Se ha eliminado el trayecto exitosamente");
                int idst, idmov;
                idst = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                idmov = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                buscarTracyeto(idst, idmov);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Desbloquear();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string fullpath = System.IO.Path.Combine(Application.StartupPath, "ManualUsuarioSCM.pdf");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fullpath;
            proc.Start();
            proc.Close();
        }

        private void txtKms_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
