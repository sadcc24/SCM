using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace SCM
{
    public partial class congelarExistencias : Form
    {
        public congelarExistencias()
        {
            InitializeComponent();
        }

        private void congelarExistencias_Load(object sender, EventArgs e)
        {
            string[] usuario = Globales.Usuario.CapturarUsuario();
            //cmbLinea
            string query = "SELECT idlinea, descripcion FROM [dbo].[Linea] where estado = 1";
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Linea");
            int i;
            dgvLíneas.DataSource = ds.Tables[0];
            for (i = 0; i < dgvLíneas.RowCount - 1; i++)
            {
                cmbLinea.Items.Add(dgvLíneas[0, i].Value.ToString() + " " + dgvLíneas[1, i].Value.ToString());
            }
            //cmbBodega            
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            string query2 = "SELECT idbodega, nombre_bodega FROM [dbo].[Bodega] where activo = 1 and idempresa=" +  empresa[0];
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Bodega");            
            dgvBodega.DataSource = ds2.Tables[0];
            for (i = 0; i < dgvBodega.RowCount - 1; i++)
            {
                cmbBodega.Items.Add(dgvBodega[0, i].Value.ToString() + " " + dgvBodega[1, i].Value.ToString());
            }
            //cmbMarca
            string query3 = "SELECT idmarca, descripcion FROM [dbo].[Marca]";
            DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query3, "Marca");
            dgvMarcas.DataSource = ds3.Tables[0];
            for (i = 0; i < dgvMarcas.RowCount - 1; i++)
            {
                cmbMarca.Items.Add(dgvMarcas[0, i].Value.ToString() + " " + dgvMarcas[1, i].Value.ToString());
            }
        }

        private void btnCongelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Está seguro de congelar estas existencias?", "Congelar Existencias",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                //gdvExistencias            
                string query3 = "SELECT idbodega,idproducto,cantidad FROM [dbo].[Existencia] where idproducto between " + txtDesde.Text.ToString() + " and " + txtHasta.Text.ToString();
                DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query3, "Existencia");
                dgvExistencias.DataSource = ds3.Tables[0];
                int i;
                for (i = 0; i < dgvBodega.RowCount - 1; i++)
                {
                    //cmbBodega.Items.Add(dgvExistencias[0, i].Value.ToString() + " " + dgvExistencias[1, i].Value.ToString());
                }
                //Crear Inventario Físico
                string[] usuario = Globales.Usuario.CapturarUsuario();
                string query4 = "INSERT INTO [DBO].[INVENTARIOFISICO] (fecha,codusuario,idrol) VALUES(GETDATE()," + usuario[0] + ",1)";
                DataSet ds4 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query4, "InvenarioFisico");
                //dgvExistencias.DataSource = ds3.Tables[0];
                //int i;
                //for (i = 0; i < dgvBodega.RowCount - 1; i++)
                {
                    //cmbBodega.Items.Add(dgvExistencias[0, i].Value.ToString() + " " + dgvExistencias[1, i].Value.ToString());
                }

                this.Close();
            }            

        }

        private void gbxProductos_Enter(object sender, EventArgs e)
        {

        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void txtHasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void txtDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblBodega_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLíneas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
