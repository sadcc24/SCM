using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM
{
    public partial class descongelarExistencias : Form
    {
        public descongelarExistencias()
        {
            InitializeComponent();
        }

        private void btnDescongelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro de descongelar estas existencias?", "Descongelar Existencias",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void descongelarExistencias_Load(object sender, EventArgs e)
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
            string query2 = "SELECT idbodega, nombre_bodega FROM [dbo].[Bodega] where activo = 1 and idempresa=" + empresa[0];
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Bodega");
            dgvBodega.DataSource = ds2.Tables[0];
            for (i = 0; i < dgvBodega.RowCount - 1; i++)
            {
                cmbBodega.Items.Add(dgvBodega[0, i].Value.ToString() + " " + dgvBodega[1, i].Value.ToString());
            }
        }
    }
}
