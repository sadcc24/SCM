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
    }
}
