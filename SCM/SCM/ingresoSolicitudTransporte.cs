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
    public partial class ingresoSolicitudTransporte : Form
    {
        public ingresoSolicitudTransporte()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            ingresoDetalleST idst = new ingresoDetalleST();
            idst.Show();
        }
    }
}
