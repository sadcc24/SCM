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
using DAL;

namespace SCM
{
    public partial class ingresoST_Encabezado : Form
    {
        public ingresoST_Encabezado()
        {
            InitializeComponent();
            ActualizaGrid();
            cargaCombos();
        }

        public void ActualizaGrid()
        {
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            try
            {
                dgvMovimientosEgreso.DataSource  = new Detalle_ST_BO().verTodoST(st);
                dgvMovimientosEgreso.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void cargaCombos()
        { 
            try
            {
                cmbTipoMovimiento.DisplayMember = "descripcion";
                cmbTipoMovimiento.ValueMember = "idtipomovimiento";
                cmbTipoMovimiento.DataSource = new SolicitudTransporte_BOL().verTipoMovimiento();
                cmbBodega.DisplayMember = "nombre_bodega";
                cmbBodega.ValueMember = "idbodega";
                cmbBodega.DataSource = new SolicitudTransporte_BOL().verBodegas();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizaGrid();
            cargaCombos();
        }

        private void dgvMovimientosEgreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)){return;}

            DataGridViewRow row = dgvMovimientosEgreso.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            int bodega = (int)row.Cells[1].Value;
            if (txtValidaDetalle.Text == "1")
            {
                MessageBox.Show("En la siguiente pantalla ingrese el detalle de los productos para el movimiento");
               // Detalle ST = new Detalle(valor.ToString(), bodega.ToString());
                ingresoDetalleST ST = new ingresoDetalleST(valor.ToString(), bodega.ToString());
                ST.MdiParent = this.MdiParent;
                ST.Show();
            }
            else
            {
                Detalle_ST_Entity st = new Detalle_ST_BO().verUno_Movimiento(valor);
                txtIdMovimiento.Text = st.idMovimiento.ToString();
                cmbBodega.SelectedValue = Convert.ToInt32(st.idBodega);
                //dtpFecha.Value = st.fecha
                cmbTipoMovimiento.SelectedValue = Convert.ToInt32(st.idTipoMov);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            string[] usuario = Globales.Usuario.CapturarUsuario();
            string[] moneda = Globales.Usuario.CapturarMoneda(Globales.Conexion);
           // st.idMoneda = Convert.ToInt32(moneda[1]);
            st.idMoneda = 1;
            st.idBodega = Convert.ToInt32(cmbBodega.SelectedValue);
            st.fecha = dtpFecha.Value.Day + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Year;
            //st.fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
            st.idTipoMov = Convert.ToInt32(cmbTipoMovimiento.SelectedValue);
            try
            {
                if (txtIdMovimiento.Text == "" || txtIdMovimiento.Text == "0")
                {
                    new BO.Detalle_ST_BO().guardaEncabezado(st);
                    MessageBox.Show("Movimiento Guardado Exitosamente");
                }
                else
                {
                    st.idMovimiento = Convert.ToInt32(txtIdMovimiento.Text.Trim());
                    new BO.Detalle_ST_BO().actualizaEncabezado(st);
                    MessageBox.Show("Movimiento Actualizado Exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ActualizaGrid();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHabilitaDetalle_Click(object sender, EventArgs e)
        {
            btnDesahibilitaDetalle.Enabled = true;
            btnHabilitaDetalle.Enabled = false;
            //MessageBox.Show("Seleccione un movimiento para agregar el detalle de productos");
            lblAvisoGrid.Text = "Seleccione un movimiento para agregar el detalle de productos";
            txtValidaDetalle.Text = "1";
        }

        private void btnDesahibilitaDetalle_Click(object sender, EventArgs e)
        {
            btnHabilitaDetalle.Enabled = true;
            btnDesahibilitaDetalle.Enabled = false;
            //  MessageBox.Show("Seleccione un movimiento para modificar la información del movimiento");
            lblAvisoGrid.Text = "Seleccione un movimiento para modificar la información del movimiento";
            txtValidaDetalle.Text = "0";
        }

        private void ingresoST_Encabezado_Load(object sender, EventArgs e)
        {
            lblAvisoGrid.Text = "Seleccione un movimiento para modificar la información del movimiento";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdMovimiento.Clear();
            cmbBodega.Enabled = true;
            cmbTipoMovimiento.Enabled = true;
            dtpFecha.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdMovimiento.Clear();
            cmbBodega.Enabled = false;
            cmbTipoMovimiento.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          //  cmbBodega.Enabled = true;
            cmbTipoMovimiento.Enabled = true;
            dtpFecha.Enabled = true;
        }
    }
}
