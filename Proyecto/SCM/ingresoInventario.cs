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
    public partial class ingresoInventario : Form
    {
        public ingresoInventario()
        {
            InitializeComponent();
        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            buscarOC boc = new buscarOC();
            boc.Show();
        }
    }
}
