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
    public partial class mantenimientoProductos : Form
    {
        public mantenimientoProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Productos prdu = new Productos();
            prdu.MdiParent = this.MdiParent;
            prdu.btnEditar.Enabled = false;
            prdu.btnEliminar.Enabled = false;
            prdu.txtID.ReadOnly = true;
            this.Hide();
            //prdu.btnEditar.Enabled = false;
            //prdu.btnEliminar.Enabled = false;
            prdu.Show();
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
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvProductos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvProductos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvProductos);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvProductos);
        }

        private void mantenimientoProductos_Load(object sender, EventArgs e)
        {
            vConsultarProductosActivos();          
        }

        public void vConsultarProductosActivos()
        {
            clsProductos_BO producto = new clsProductos_BO();
            gvProductos.DataSource = producto.vConsultaProducto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarProductosActivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos_Entity pro = new clsProductos_Entity();
                clsProductos_BO producto = new clsProductos_BO();
                pro.strProducto = txtProducto.Text;
                gvProductos.DataSource = producto.vConsultaFiltro(pro);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string idProducto, descripcion,stockmaximo,stockminimo, idproveedor, id_tipo_producto, idmarca, codmetodo, codlinea, tamano, peso, unidadpeso,unidadtamano;
        private void gvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dataIndexNo = gvProductos.Rows[e.RowIndex].Index.ToString();
            //string cellValue = gvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();

            idProducto = gvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = gvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            stockminimo = gvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            stockmaximo = gvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            idproveedor = gvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            id_tipo_producto = gvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
            idmarca = gvProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
            codmetodo = gvProductos.Rows[e.RowIndex].Cells[9].Value.ToString();
            codlinea = gvProductos.Rows[e.RowIndex].Cells[10].Value.ToString();
            tamano = gvProductos.Rows[e.RowIndex].Cells[11].Value.ToString();
            peso = gvProductos.Rows[e.RowIndex].Cells[12].Value.ToString();
            unidadpeso = gvProductos.Rows[e.RowIndex].Cells[16].Value.ToString();
            unidadtamano = gvProductos.Rows[e.RowIndex].Cells[17].Value.ToString();


            Productos frm = new Productos();
            frm.txtID.Text = idProducto;
            frm.txtProducto.Text = descripcion;
            frm.txtsmin.Text = stockminimo;
            frm.txtsmax.Text = stockmaximo;
            frm.cmbProveedor.SelectedValue = idproveedor;
            frm.cmbTipProd.SelectedValue = id_tipo_producto;
            frm.cmbMarca.SelectedValue = idmarca;
            frm.cmbmetodo.SelectedValue = codmetodo;
            frm.cmbLinea.SelectedValue = codlinea;
            frm.txttam.Text = tamano;
            frm.txtpeso.Text = peso;
            frm.cmbUnidadPeso.SelectedValue = unidadpeso;
            frm.cmbUnidadTamano.SelectedValue = unidadtamano;
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
