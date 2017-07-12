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
        public ingresoSolicitudTransporte(int idmov)
        {
            //Recibo como parámetro el id del movimiento, con base este id se crea una solicitud de transporte
            InitializeComponent();
            actualizaGridDetalle(idmov);
            txtMovimiento.Text = idmov.ToString();
        }
        #region Funciones y Metodos
        private void actualizaGridDetalle(int codigo)
        {

            try
            {
                SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                //st.idSolicitud = codigo;
                st.idMovimiento = codigo;
                dgvDetalleST.DataSource = new SolicitudTransporte_BOL().verDetalleST(st);
                dgvDetalleST.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            st.Notas = txtNotas.Text.Trim();
            st.idMovimiento = Convert.ToInt32(txtMovimiento.Text.Trim());
            //st.idEmpresa = 1;
            //st.idUsuario = 1;
            //string[] empresa = Globales.Empresa.CapturarEmpresa();
            //string[] usuario = Globales.Usuario.CapturarUsuario();
            st.idEmpresa = 1;//Convert.ToInt32(empresa[0]);
            st.idUsuario = 1;//Convert.ToInt32(usuario[0]);
             
            
            try
            {
                new BO.SolicitudTransporte_BOL().binsertaEncabezadoST(st);
                MessageBox.Show("Solicitud Guardada Exitosamente");
                //int idsolicitud = st.idMovimiento;
                //envia como parámetros el movimiento y la solicitud creada.
                seguimientoST ST = new seguimientoST(txtMovimiento.Text.Trim(), "0");
                ST.MdiParent = this.MdiParent;
                ST.Show();
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
           /*
                try
                {
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    new BO.SolicitudTransporte_BOL().actualizaST(st);
                    MessageBox.Show("Solicitud Actualizada Exitosamente");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                */
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtMovimiento.Clear();
            txtNotas.Clear();
            dgvDetalleST.Enabled = true;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Enabled();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de rechazar la solicitud", "Solicitud de Transporte",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                try
                {
                    SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
                    st.Notas = txtNotas.Text.Trim();
                    st.idSolicitud = Convert.ToInt32(txtMovimiento.Text.Trim());
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

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void ingresoSolicitudTransporte_Load(object sender, EventArgs e)
        {

        }
    }
}
