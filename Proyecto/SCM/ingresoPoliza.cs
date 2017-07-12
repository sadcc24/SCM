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
    public partial class ingresoPoliza : Form
    {
        public ingresoPoliza()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ingresoPoliza_Load(object sender, EventArgs e)
        {
            try
            {
                string[] empresa = Globales.Empresa.CapturarEmpresa();
                string[] usuario = Globales.Usuario.CapturarUsuario();
                clsInventarios_BO oc = new clsInventarios_BO();
     
                DataTable dtCuenta = oc.verCuentaContable();
                cboCuentaContable.DataSource = dtCuenta;
                cboCuentaContable.DisplayMember = "nombre";
                cboCuentaContable.ValueMember = "idCuenta";
            }
            catch (Exception Ex) { String error = Ex.ToString(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            string[] usuario = Globales.Usuario.CapturarUsuario();
            poliza_BO orden = new poliza_BO();
            poliza_Entity oc = new poliza_Entity();
            try
            {
                oc.nombre = txtNombre.Text;
                oc.descripcion = txtDescripcion.Text;
                oc.idempresa = Convert.ToInt32(empresa[0].ToString());
                oc.fecha = dtfecha.Value.ToString("yyyy-MM-dd");
                orden.insertPoliza(oc);

                int id = Convert.ToInt32(orden.dtConsultarUltimaPoliza().Rows[0][0].ToString());

                detalle_poliza_BO detalle = new detalle_poliza_BO();
                detalle_poliza_Entity det = new detalle_poliza_Entity();
                det.idpoliza = id;
                det.idcuenta = Convert.ToInt32(cboCuentaContable.SelectedValue.ToString());
                det.total = Convert.ToDecimal(txttotal.Text.ToString());
                det.clasificacion = txtClasificacion.Text;
                detalle.insertDetallePoliza(det);
                MessageBox.Show("Póliza Guardada.");
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Ingreso de Póliza:" + txtDescripcion.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Registro de Datos");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClasificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboCuentaContable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
