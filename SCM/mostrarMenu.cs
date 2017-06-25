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
    public partial class mostrarMenu : Form
    {
        private int childFormNumber = 0;

        public mostrarMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void movimientosAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoInventario temp = new ingresoInventario();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;            
            temp.Show();
        }

        private void facturasDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoFacturaProveedor temp = new ingresoFacturaProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void devoluciónAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaDevolucionProveedor temp = new generaDevolucionProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void contraseñaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaContrasena temp = new generaContrasena();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void pagoAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorizaPagoProveedores temp = new autorizaPagoProveedores();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoOrdenCompra temp = new ingresoOrdenCompra();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaciónDeÓrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizacionOC temp = new AutorizacionOC();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void transportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarSolicitudTransporte temp = new buscarSolicitudTransporte();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoDeOrdenDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ingresoOrdenCompra temp = new ingresoOrdenCompra();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaciónDeOrdenDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AutorizacionOC temp = new AutorizacionOC();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimientosAlInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ingresoInventario temp = new ingresoInventario();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ordenesDeCompraRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoTrasladoEntreBodegas temp = new ingresoTrasladoEntreBodegas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void órdenesDeCompraPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoFacturaProveedor temp = new ingresoFacturaProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturasIngresadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            generaDevolucionProveedor temp = new generaDevolucionProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void proveedoresYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaContrasena temp = new generaContrasena();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaPagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorizaPagoProveedores temp = new autorizaPagoProveedores();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void manteniminetoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoProductos temp = new mantenimientoProductos();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoBodegas temp = new mantenimientoBodegas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void vehículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarVehiculos temp = new buscarVehiculos();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void solicitudDeTransportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarSolicitudTransporte temp = new buscarSolicitudTransporte();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void serviciosAVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoOrdenServicio temp = new ingresoOrdenServicio();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void congelarExitenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            congelarExistencias temp = new congelarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void capturarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capturarExistencias temp = new capturarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ajustarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajustarExistencias temp = new ajustarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void descongelarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            descongelarExistencias temp = new descongelarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }
    }
}
