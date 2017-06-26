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
    public partial class ingresoSolicitudTransporte : Form
    {
        public ingresoSolicitudTransporte(int codigost)
        {
            InitializeComponent();
           // txtCodST.Text = codigost.ToString();
            if (codigost != 0)
            {
                buscarUno(codigost);
            }
        }

        private void buscarUno(int codigo)
        {
            SolicitudTransporte_Entity eST = new SolicitudTransporte_BOL().verUnoST(codigo);
            txtNotas.Text = eST.Notas;
           
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            ingresoDetalleST idst = new ingresoDetalleST();
            idst.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            st.Notas = txtNotas.Text.Trim();
            new BO.SolicitudTransporte_BOL().binsertaEncabezadoST(st);
        }
    }
}
