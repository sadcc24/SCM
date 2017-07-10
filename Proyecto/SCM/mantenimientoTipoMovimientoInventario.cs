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
    public partial class mantenimientoTipoMovimientoInventario : Form
    {
        public mantenimientoTipoMovimientoInventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoTipoMovimientoInventario_Load(object sender, EventArgs e)
        {
            vConsultarTiposActivos();
        }

        private void vConsultarTiposActivos()
        {
            clsTipoMovimiento_BO tipom = new clsTipoMovimiento_BO();
            gvTiposMovimiento.DataSource = tipom.vConsultarTipoMovimiento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clsTipoMovimiento_Entity tip = new clsTipoMovimiento_Entity();
                clsTipoMovimiento_BO tipmov = new clsTipoMovimiento_BO();
                tip.strDescripcion = txtTipoMov.Text;
                gvTiposMovimiento.DataSource = tipmov.vConsultaFiltro(tip);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region Navegacion
        //Para ir al primer registro:
        public static int funirPrimero(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                gridDatos.Rows[0].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[0].Cells[0];

                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }

        }
        //Para ir al último registro registro:
        public static int funirUltimo(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int max = gridDatos.Rows.Count - 2;
                gridDatos.Rows[max].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[max].Cells[0];
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }
        }
        //Para ir al registro anterior
        public static int funirAnterior(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor - 1;
                if (valor >= 0)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("PRIMER REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }
        }
        // para ir al registro siguiente.
        public static int funirSiguiente(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor + 1;
                if (valor <= max)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("ULTIMO REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }

        }
        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarTiposActivos();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvTiposMovimiento);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvTiposMovimiento);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvTiposMovimiento);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvTiposMovimiento);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoMovimiento prdu = new TipoMovimiento();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtID.ReadOnly = true;
            this.Hide();

            prdu.Show();
        }

        private void gvTiposMovimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idtipomovimiento, descripcion, operacion;
            idtipomovimiento = gvTiposMovimiento.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = gvTiposMovimiento.Rows[e.RowIndex].Cells[1].Value.ToString();
            operacion = gvTiposMovimiento.Rows[e.RowIndex].Cells[2].Value.ToString();

        //    MessageBox.Show(operacion);

            TipoMovimiento frm = new TipoMovimiento();
            frm.txtID.Text = idtipomovimiento;
            frm.txtDescripcion.Text = descripcion;
           if (operacion == "False")
            {
                frm.rbResta.Checked = true;
            }
            else {
                if (operacion == "True")
                {
                    frm.rbSuma.Checked = true;
                }
            }
            frm.btnEditar.Enabled = false;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtID.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }
    }
}
