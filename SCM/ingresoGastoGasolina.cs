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
    public partial class ingresoGastoGasolina : Form
    {
        public ingresoGastoGasolina(int idst)
        {
            InitializeComponent();
            getIdST(idst);
            txtIdSolicitud.Text = idst.ToString();
            ActualizaGrid();
            cargaTipoGasto();
            
        }

        public void getIdST(int idst)
        {
            GatosTransportes_Entity st = new ST_Asignaciones_BOL().verIdGasto(idst); 
            txtIdGasto.Text = st.idGasto.ToString();
            txtIdTransporte.Text = st.idtransporte.ToString();
            txtTotalGastos.Text = st.gastoTotal.ToString();
                        
        }

        public void cargaTipoGasto()
        {
            try
            {
                cmbTipoGasto.DisplayMember = "nombre";
                cmbTipoGasto.ValueMember = "idgasto";
                cmbTipoGasto.DataSource = new BO.ST_Asignaciones_BOL().verTipoGastos();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizaGrid()
        {
            try
            {
                GatosTransportes_Entity st = new GatosTransportes_Entity();
                st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                dgvGastos.DataSource = new ST_Asignaciones_BOL().verTodosGastos(st);
                dgvGastos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtIdGasto.Text == "" || txtIdGasto.Text == "0")
            {
                try
                {
                    GatosTransportes_Entity gasto = new GatosTransportes_Entity();
                    gasto.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    gasto.idtransporte = Convert.ToInt32(txtIdTransporte.Text.Trim());
                    new BO.ST_Asignaciones_BOL().guardarEncabezadoGast(gasto);
                    getIdST(gasto.idSolicitud);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (txtIdGasto.Text == "" || txtIdGasto.Text == "0")
            {
                MessageBox.Show("Error al guardar el encabezado, por favor contacte al administrador");
            }
            else
            {
                try
                {
                    GatosTransportes_Entity st = new GatosTransportes_Entity();
                    st.factura = txtFactura.Text;
                    st.totalGasto = Convert.ToDecimal(txtTotal.Text.Trim());
                    st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                    st.idTipoGasto = 1;
                    //st.fechafactura = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                    st.fechafactura = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                    st.Notas = txtNotas.Text;
                    st.kms = Convert.ToDecimal(txtKms.Text.Trim());
                    st.idGasto = Convert.ToInt32(txtIdGasto.Text.Trim());
                    st.idtransporte = Convert.ToInt32(txtIdTransporte.Text.Trim());
                    if (txtDetalle.Text == "" || txtDetalle.Text == "0")
                    {
                        new BO.ST_Asignaciones_BOL().guardarDetalleGasto(st);
                        MessageBox.Show("Se ha guardado el gasto exitosamente");
                    }else
                    {
                        st.idDetGasto = Convert.ToInt32(txtDetalle.Text);
                        st.gastoPivote = Convert.ToDecimal(txtGastoPivote.Text);
                        new BO.ST_Asignaciones_BOL().actualizarDetalleGasto(st);
                        MessageBox.Show("Se ha actualizado el gasto exitosamente");
                    }

                    limpiar();
                    Bloquear();
                    ActualizaGrid();
                    getIdST(st.idSolicitud);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ingresoGastoGasolina_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            getIdST(Convert.ToInt32(txtIdSolicitud.Text.Trim()));
            ActualizaGrid();
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) { return; }

            DataGridViewRow row = dgvGastos.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            GatosTransportes_Entity gt = new BO.ST_Asignaciones_BOL().verUnGasto(valor); //GatosTransportes_Entity();
            txtDetalle.Text = valor.ToString();
            txtFactura.Text = gt.factura;
            txtTotal.Text = gt.totalGasto.ToString();
            txtGastoPivote.Text = gt.totalGasto.ToString();
            txtKms.Text = gt.kms.ToString();
            txtNotas.Text = gt.Notas;
            
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDetalle.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningun registro");
            }
            else
            {
                if (MessageBox.Show("Esta seguro de eliminar el registro", "Detalle de Solicitud",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes)
                {
                    try
                    {
                        int cod = Convert.ToInt32(txtDetalle.Text);
                        GatosTransportes_Entity st = new GatosTransportes_Entity();
                        st.factura = txtFactura.Text;
                        st.totalGasto = Convert.ToDecimal(txtTotal.Text.Trim());
                        st.idSolicitud = Convert.ToInt32(txtIdSolicitud.Text.Trim());
                        st.idGasto = Convert.ToInt32(txtIdGasto.Text.Trim());
                        st.idtransporte = Convert.ToInt32(txtIdTransporte.Text.Trim());
                        st.idDetGasto = Convert.ToInt32(txtDetalle.Text);
                        new BO.ST_Asignaciones_BOL().eliminarDetalleGasto(st);
                        MessageBox.Show("Se ha eliminado el gasto exitosamente");
                        limpiar();
                        Desbloquear();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtDetalle.Clear();
            txtFactura.Clear();
            txtKms.Clear();
            txtTotal.Clear();
            txtNotas.Clear();
            Desbloquear();
        }

        private void Bloquear()
        {
            txtFactura.Enabled = false;
            cmbTipoGasto.Enabled = false;
            txtKms.Enabled = false;
            txtTotal.Enabled = false;
            txtNotas.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void Desbloquear()
        {
            txtFactura.Enabled = true;
            cmbTipoGasto.Enabled = true;
            txtKms.Enabled = true;
            txtTotal.Enabled = true;
            txtNotas.Enabled = true;
            dtpFecha.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Desbloquear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            Bloquear();
        }
    }
}
