﻿using System;
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
namespace SCM
{
    public partial class mantenimientoLineas : Form
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        public mantenimientoLineas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Lineas Linea = new Lineas();
            Linea.MdiParent = this.MdiParent;
            Linea.btnEditar.Enabled = false;
            Linea.btnEliminar.Enabled = false;
            Linea.txtCod.ReadOnly = true;
            this.Hide();
        
            Linea.Show();

      
        }

        private void mantenimientoLineas_Load(object sender, EventArgs e)
        {
            /* string[] usuario = Globales.Usuario.CapturarUsuario();
             string query = "SELECT Rol.idrol, Rol.Rol as Rol, codusuario FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol  WHERE Status = 1 AND codusuario =" + usuario[0];
             DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Usuario_1");

             gvLineasA.DataSource = ds.Tables[0];
             Globales.Rol = gvLineasA.Rows[0].Cells[0].Value.ToString();
             if (Globales.Rol == "1")
             {
                 //MessageBox.Show("Sí tiene permisos de Administrador");
                 vConsultarLineasActivas();
             }
             else
             {
                 MessageBox.Show("No tiene permisos de Administrador");
                 this.BeginInvoke(new MethodInvoker(this.Close));
             }*/
            vConsultarLineasActivas();
        }
        

        private void vConsultarLineasActivas()
        {
            Lineas_BO Lineaega = new Lineas_BO();
            gvLineas.DataSource = Lineaega.vConsultaLineas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarLineasActivas();
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
            funirPrimero(gvLineas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvLineas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvLineas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvLineas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Lineas_Entity Linea = new Lineas_Entity();
                Lineas_BO usuario = new Lineas_BO();
                Linea.strDescripcion = txtBuscador.Text;
                gvLineas.DataSource =  usuario.vConsultaFiltro(Linea);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, descripcion;
        private void gvLineas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = gvLineas.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvLineas.Rows[e.RowIndex].Cells[1].Value.ToString();

            id = gvLineas.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = gvLineas.Rows[e.RowIndex].Cells[1].Value.ToString();            

            Lineas frm = new Lineas();
            frm.txtCod.Text = id;            
            frm.txtDescripcion.Text = descripcion;                   
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
