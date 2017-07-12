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
    public partial class buscarEgresos : Form
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :
        public buscarEgresos()
        {
            InitializeComponent();
        }

        private void buscarEgresos_Load(object sender, EventArgs e)
        {
            clsMovimientosInventario_BO movimientos = new clsMovimientosInventario_BO();
            clsMovimientosInventario_Entity movi = new clsMovimientosInventario_Entity();
            movi.strIdBodega = (lblBodega.Text.ToString());
            movi.strIdTipoMovimiento = "3";
            grdInventario.DataSource = movimientos.dtConsultarEgresos(movi);
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consultar Egresos de Bodega.");
        }

        private void grdInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string oc;
            clsMovimientosInventario_BO movimientos = new clsMovimientosInventario_BO();
            clsMovimientosInventario_Entity fac = new clsMovimientosInventario_Entity();
            fac.strIdBodega = (lblBodega.Text.ToString());
            fac.strIdMovimiento = grdInventario.Rows[e.RowIndex].Cells[3].Value.ToString();

            ingresoInventario frm = new ingresoInventario();
            frm.grdInventario.DataSource = movimientos.detalleEgreso(fac);
            frm.cmbBodega.SelectedValue = lblBodega.Text.ToString();
            frm.cmbProveedor.SelectedValue = lblProveedor.Text.ToString();
            frm.txtDocRef.Text = grdInventario.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm.txtbodega.Text = lblBodega.Text;
         //   frm.txtTotal.Text = grdInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string fullpath = System.IO.Path.Combine(Application.StartupPath, "ManualUsuarioSCM.pdf");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fullpath;
            proc.Start();
            proc.Close();
        }
    }
}
