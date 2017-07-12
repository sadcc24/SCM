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
using DAL;
using BO;
namespace SCM
{
    public partial class kardexProductos : Form
    {
        public kardexProductos()
        {
            InitializeComponent();
        }

        private void z_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void kardexProductos_Load(object sender, EventArgs e)
        {
            clsProductos_BO producto = new clsProductos_BO();
            cmbProductos.DataSource = producto.vConsultaProducto();
            cmbProductos.ValueMember = "ID";
            cmbProductos.DisplayMember = "Descripcion";
            gvExistencias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvMovimientos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvExistencias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvMovimientos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos_Entity pro = new clsProductos_Entity();
                clsProductos_BO producto = new clsProductos_BO();
                pro.strIdProd= cmbProductos.SelectedValue.ToString();
                gvMovimientos.DataSource = producto.vMovimientoProductos(pro);
                gvProductos.DataSource = producto.vConsultaFiltro(pro);
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                pro.strIdEmpresa = empresa[0];
                gvExistencias.DataSource = producto.vExistenciaProductos(pro);
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consulta Kardex Productos");
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
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvMovimientos);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvMovimientos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvMovimientos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvMovimientos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
