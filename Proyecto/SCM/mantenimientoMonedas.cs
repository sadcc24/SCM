/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Líneas
    Fecha de asignación: 27/Junio
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
    public partial class mantenimientoMonedas : Form
    {
        MRP_BD cnn = Globales.cnn;
        public mantenimientoMonedas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Monedas Moneda = new Monedas();
            Moneda.MdiParent = this.MdiParent;
            Moneda.btnEditar.Enabled = false;
            Moneda.btnEliminar.Enabled = false;
            Moneda.txtCod.ReadOnly = true;
            this.Hide();
        
            Moneda.Show();

      
        }

        private void mantenimientoMonedas_Load(object sender, EventArgs e)
        {
            /* string[] usuario = Globales.Usuario.CapturarUsuario();
             string query = "SELECT Rol.idrol, Rol.Rol as Rol, codusuario FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol  WHERE Status = 1 AND codusuario =" + usuario[0];
             DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Usuario_1");

             gvMonedasA.DataSource = ds.Tables[0];
             Globales.Rol = gvMonedasA.Rows[0].Cells[0].Value.ToString();
             if (Globales.Rol == "1")
             {
                 //MessageBox.Show("Sí tiene permisos de Administrador");
                 vConsultarMonedasActivas();
             }
             else
             {
                 MessageBox.Show("No tiene permisos de Administrador");
                 this.BeginInvoke(new MethodInvoker(this.Close));
             }*/
            vConsultarMonedasActivas();
        }
        

        private void vConsultarMonedasActivas()
        {
            Monedas_BO Monedaega = new Monedas_BO();
            gvMonedas.DataSource = Monedaega.vConsultaMonedas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarMonedasActivas();
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
            funirPrimero(gvMonedas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvMonedas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvMonedas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvMonedas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Monedas_Entity Moneda = new Monedas_Entity();
                Monedas_BO usuario = new Monedas_BO();
                Moneda.strmoneda = txtBuscador.Text;
                gvMonedas.DataSource =  usuario.vConsultaFiltro(Moneda);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, simbolo, moneda, activo;

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            /*  Programador: Josué Enrique Zeceña González
            Analista: Josué Enrique Zeceña González
            Comentarios: Abrir documento de ayuda/manual de usuario
            Fecha de asignación: 10/Julio
            Fecha de entrega: 12/Julio
            */
            string fullpath = System.IO.Path.Combine(Application.StartupPath, "ManualUsuarioSCM.pdf");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fullpath;
            proc.Start();
            proc.Close();
        }

        private void gvMonedas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = gvMonedas.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvMonedas.Rows[e.RowIndex].Cells[1].Value.ToString();

            id = gvMonedas.Rows[e.RowIndex].Cells[0].Value.ToString();
            simbolo = gvMonedas.Rows[e.RowIndex].Cells[1].Value.ToString();
            moneda = gvMonedas.Rows[e.RowIndex].Cells[2].Value.ToString();            

            Monedas frm = new Monedas();
            frm.txtCod.Text = id;            
            frm.txtMoneda.Text = moneda;
            frm.txtSimbolo.Text = simbolo;            
            frm.btnEditar.Enabled = true;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtCod.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }


    }
}
