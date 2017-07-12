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
    public partial class buscarSolicitudTransporte : Form
    {
        public buscarSolicitudTransporte()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //ingresoSolicitudTransporte vehiculo = new ingresoSolicitudTransporte(0);
            ingresoST_Encabezado st = new ingresoST_Encabezado();
            st.MdiParent = this.MdiParent;
            st.Show();
            //vehiculo.MdiParent = this.MdiParent;
           // vehiculo.Show();

        }

        #region Funciones y metodos
        private void ActualizarForm(int tipo)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            //string[] empresa = Globales.Empresa.CapturarEmpresa();
            //string[] usuario = Globales.Usuario.CapturarUsuario();
            //st.stEmpresa = Convert.ToInt32(empresa[0]);
            //st.stUsuario = Convert.ToInt32(usuario[0]);
            st.stEmpresa = 1;
            st.stUsuario = 1;

            if (tipo == 2)
            {
                if (txtSolicit.Text != "")
                {
                    st.idMovimiento = Convert.ToInt32(txtSolicit.Text.Trim());
                }
            }
            try
            {
                dgvSolicitud.DataSource = new SolicitudTransporte_BOL().verTodoST(st);
                dgvSolicitud.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        #endregion

        private void buscarSolicitudTransporte_Load(object sender, EventArgs e)
        {
            ActualizarForm(1);
        }

        private void dgvSolicitud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!(e.RowIndex > -1))
            {
                return;

            }

            DataGridViewRow row = dgvSolicitud.Rows[e.RowIndex];
            int idmovimiento = (int)row.Cells[0].Value;
            string idsolicitud = (string)row.Cells[1].Value;
            //Verifica si la solicitud ya ha sido creada 
            if(idsolicitud == "PENDIENTE")
            {
                //Pantalla para la creacion de la solicitud
                ingresoSolicitudTransporte ST = new ingresoSolicitudTransporte(idmovimiento);
                ST.MdiParent = this.MdiParent;
                ST.Show();
            }
            else
            {
                //Pantalla para el seguimiento de la solicitud
                seguimientoST ST = new seguimientoST(idmovimiento.ToString(), idsolicitud);
                ST.MdiParent = this.MdiParent;
                ST.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarForm(2);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarForm(1);
        }

        private void txtSolicit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }   
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(dgvSolicitud);
        }

        #region Navegacion
        //Para ir al primer registro:
        public static int funirPrimero(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                gridDatos.Rows[0].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[0].Cells[0];

                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }

        }
        //Para ir al último registro registro:
        public static int funirUltimo(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int max = gridDatos.Rows.Count - 2;
                gridDatos.Rows[max].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[max].Cells[0];
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }
        }
        //Para ir al registro anterior
        public static int funirAnterior(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor - 1;
                if (valor >= 0)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("PRIMER REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }
        }
        // para ir al registro siguiente.
        public static int funirSiguiente(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor + 1;
                if (valor <= max)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("ULTIMO REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }

        }
        #endregion

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(dgvSolicitud);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(dgvSolicitud);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(dgvSolicitud);
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
