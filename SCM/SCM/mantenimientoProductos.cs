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
    public partial class mantenimientoProductos : Form
    {
        public mantenimientoProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Productos prdu = new Productos();
            prdu.Show();
        }
    }
}
