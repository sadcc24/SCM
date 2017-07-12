/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Bitacora
    Fecha de asignación: 20/Junio
    Fecha de entrega: 03/Julio
*/
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
    public partial class Bitacora : Form
    {
        MRP_BD cnn = Globales.cnn;
        public Bitacora()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {                       

      
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            //Verificación de Rol de Administrador
            if (Globales.Usuario.CapturarRol(Globales.Conexion) == "1")
            {
                //MessageBox.Show("Sí tiene permisos de Administrador");
                vConsultarBitacoraActivas();
            }
            else
            {
                MessageBox.Show("No tiene permisos de Administrador", "Seguridad SAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            //Verificación de Rol de Administrador
        }


        private void vConsultarBitacoraActivas()
        {
            Bitacora_BO Bita = new Bitacora_BO();
            gvBitacora.DataSource = Bita.vConsultaBitacora();
            gvBitacora.AutoResizeColumns();
            gvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gvBitacora.AllowUserToResizeColumns = true;
            //gvBitacora.AllowUserToOrderColumns = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarBitacoraActivas();
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

        #region "FLECHAS"
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirPrimero(gvBitacora);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvBitacora);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvBitacora);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvBitacora);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Bitacora_Entity Bita = new Bitacora_Entity();
                Bitacora_BO usuario = new Bitacora_BO();
                Bita.codusuario = txtBuscador.Text;
                gvBitacora.DataSource =  usuario.vConsultaFiltro(Bita);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, usuario, rol;    

    }
}
