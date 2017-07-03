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
            int operacion = 0;

            if (rbSuma.Checked == true)
            {
                operacion = 1;
            }
            else {
                if (rbResta.Checked == true)
                {
                    operacion = 0;
                }
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar la Descripción de Tipo de Movimiento de Inventarios.");
                return;
            }
            else {
                try
                {
                    clsTipoMovimiento_Entity tip = new clsTipoMovimiento_Entity();
                    clsTipoMovimiento_BO tipo = new clsTipoMovimiento_BO();
                    tip.strDescripcion = txtDescripcion.Text;
                    tip.strOperacion = operacion.ToString();
                    tipo.vInsertarTipoMovimiento(tip);
                    MessageBox.Show("Tipo de Movimiento Ha sido Guardado.");
                    vConsultarTiposActivos();
                    txtDescripcion.Text = "";
                    gbInsertar.Enabled = false;
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            gbInsertar.Enabled = true;
        }
    }
}
