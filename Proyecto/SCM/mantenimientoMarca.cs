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
using DAL;
namespace SCM
{
    public partial class mantenimientoMarca : Form
    {
        public mantenimientoMarca()
        {
            InitializeComponent();
        }
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Marca prdu = new Marca();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtID.ReadOnly = true;
            this.Hide();

            prdu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clsMarcas_Entity mar = new clsMarcas_Entity();
                clsMarcas_BO marca = new clsMarcas_BO();
                mar.strDescripcion = txtMarcaBusc.Text;
                gvMarcas.DataSource = marca.vConsultaFiltro(mar);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarMarcasDisponibles();
        }

        private void vConsultarMarcasDisponibles()
        {
            clsMarcas_BO marcas = new clsMarcas_BO();
            gvMarcas.DataSource = marcas.vConsultarMarcas();
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consultar Marcas.");
        }

        private void mantenimientoMarca_Load(object sender, EventArgs e)
        {
            vConsultarMarcasDisponibles();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvMarcas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvMarcas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvMarcas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvMarcas);
        }

        private void gvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmarca, descripcion;
            idmarca = gvMarcas.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = gvMarcas.Rows[e.RowIndex].Cells[1].Value.ToString();

            //    MessageBox.Show(operacion);

            Marca frm = new Marca();
            frm.txtID.Text = idmarca;
            frm.txtDescripcion.Text = descripcion;
            
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
    

