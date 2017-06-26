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
    public partial class mantenimientoBodegas : Form
    {
        public mantenimientoBodegas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Bodegas prdu = new Bodegas();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtID.ReadOnly = true;
            this.Hide();
        
            prdu.Show();

      
        }

        private void mantenimientoBodegas_Load(object sender, EventArgs e)
        {
            vConsultarBodegasActivas();
           // gvBodegas.DataBindingComplete()
        }

        private void vConsultarBodegasActivas()
        {
            clsBodegas_BO bodega = new clsBodegas_BO();
            gvBodegas.DataSource = bodega.vConsultaBodegas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarBodegasActivas();
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

        #region "FLECHAS"
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvBodegas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvBodegas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvBodegas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvBodegas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                clsBodegas_Entity bod = new clsBodegas_Entity();
                clsBodegas_BO bodega = new clsBodegas_BO();
                bod.strNombreBodega = txtBuscador.Text;
                gvBodegas.DataSource =  bodega.vConsultaFiltro(bod);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, descripcion, encargado, stock_minimo, stock_maximo;
        private void gvBodegas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = gvBodegas.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvBodegas.Rows[e.RowIndex].Cells[1].Value.ToString();
        
            id = gvBodegas.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = gvBodegas.Rows[e.RowIndex].Cells[1].Value.ToString();
            encargado = gvBodegas.Rows[e.RowIndex].Cells[2].Value.ToString();
            stock_minimo = gvBodegas.Rows[e.RowIndex].Cells[3].Value.ToString();
            stock_maximo = gvBodegas.Rows[e.RowIndex].Cells[4].Value.ToString();
            MessageBox.Show(id + "_" + descripcion);
      

            Bodegas frm = new Bodegas();
            frm.txtID.Text = id;
            frm.txtBodega.Text = descripcion;
            frm.txtEncargado.Text = encargado;
            frm.txtSMin.Text = stock_minimo;
            frm.txtSMax.Text = stock_maximo;
            frm.btnEditar.Enabled = true;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtID.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }


    }
}
