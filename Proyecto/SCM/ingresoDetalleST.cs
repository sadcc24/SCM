using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;

namespace SCM
{
    public partial class ingresoDetalleST : Form
    {
        public ingresoDetalleST()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Detalle_ST_Entity pDetalle = new Detalle_ST_Entity();
            pDetalle.idProducto = Convert.ToInt32(txtCodProducto.Text);
            pDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            pDetalle.idSolicitud = 1;
            new BO.SolicitudTransporte_BOL().insertaDetalleST(pDetalle);
         }
    }
}
