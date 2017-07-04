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
    public partial class ingresoSolicitudTransporte : Form
    {
        public ingresoSolicitudTransporte(int codigost)
        {
            InitializeComponent();
            cargaCBEstado();
            if (codigost != 0)
            {
                buscarUno(codigost);
                actualizaGridDetalle(codigost);
                Disabled();
            }
           
        }
        #region Funciones y Metodos
        private void cargaCBEstado()
        {
            try
            {
                cmbTipoST.DisplayMember = "nombretipost";
                cmbTipoST.ValueMember = "idtiposolict";
                cmbTipoST.DataSource = new SolicitudTransporte_BOL().verTipoST();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void buscarUno(int codigo)
        {
            SolicitudTransporte_Entity eST = new SolicitudTransporte_BOL().verUnoST(codigo);
            txtNotas.Text = eST.Notas;
            txtIdSolicitud.Text = eST.idSolicitud.ToString();
            cmbTipoST.SelectedValue = eST.idTipoSolicitud;
            lblFecEntrega.Text = eST.FechaSolicitud;
            lblFecSalida.Text = eST.FechaSalida;
            lblFecSolicitud.Text = eST.FechaRegreso;
            lblEstado.Text = eST.NombreEstado;
           
        }

        private void Disabled()
        {
            txtNotas.Enabled = false;
            cmbTipoST.Enabled = false;
            btnDetalle.Enabled = false;
            dgvDetalleST.Enabled = false;
        }

        private void Enabled()
        {
            txtNotas.Enabled = true;
            cmbTipoST.Enabled = true;
            btnDetalle.Enabled = true;
            dgvDetalleST.Enabled = true;
        }

        private void actualizaGridDetalle(int codigo)
        {
            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                st.idSolicitud = codigo;
                dgvDetalleST.DataSource = new SolicitudTransporte_BOL().verDetalleST(st);
                dgvDetalleST.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        #endregion

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if(txtIdSolicitud.Text == "")
            {
                MessageBox.Show("Debe de crear la solicitud primero");
            }
            else
            {
                
                string codigo = txtIdSolicitud.Text;
                ingresoDetalleST idst = new ingresoDetalleST(codigo);
                idst.MdiParent = this.MdiParent;
                idst.Show();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            st.Notas = txtNotas.Text.Trim();
            st.idTipoSolicitud = Convert.ToInt32(cmbTipoST.SelectedValue);
            if (txtIdSolicitud.Text == "")
            {
                try
                {
                    new BO.SolicitudTransporte_BOL().binsertaEncabezadoST(st);
                    MessageBox.Show("Solicitud Guardada Exitosamente");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                try
                {
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    new BO.SolicitudTransporte_BOL().actualizaST(st);
                    MessageBox.Show("Solicitud Actualizada Exitosamente");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
            //buscarUno(Convert.ToInt32(txtIdSolicitud.Text.Trim()));
            Disabled();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdSolicitud.Clear();
            txtNotas.Clear();
            cmbTipoST.Enabled = true;
            btnDetalle.Enabled = true;
            dgvDetalleST.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtIdSolicitud.Text);
            buscarUno(id);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Enabled();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar la solicitud", "Solicitud de Transporte",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                try
                {
                    SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                    st.Notas = txtNotas.Text.Trim();
                    st.idTipoSolicitud = Convert.ToInt32(cmbTipoST.SelectedValue);
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    new BO.SolicitudTransporte_BOL().eliminarST(st);
                    MessageBox.Show("Solicitud Eliminada Exitosamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            string codigo = txtIdSolicitud.Text;
            seguimientoST sst = new seguimientoST(codigo);
            sst.MdiParent = this.MdiParent;
            sst.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
