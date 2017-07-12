/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Empleados
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
    public partial class mantenimientoEmpleados : Form
    {
        MRP_BD cnn = Globales.cnn;
        public mantenimientoEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Empleados Empleado = new Empleados();
            Empleado.MdiParent = this.MdiParent;
            Empleado.btnEditar.Enabled = false;
            Empleado.btnEliminar.Enabled = false;
            Empleado.txtCod.ReadOnly = true;
            this.Hide();
        
            Empleado.Show();

      
        }

        private void mantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            //Verificación de Rol de Administrador            
            if (Globales.Usuario.CapturarRol(Globales.Conexion) == "1")
            {
                //MessageBox.Show("Sí tiene permisos de Administrador");
                vConsultarEmpleadosActivas();
            }
            else
            {
                MessageBox.Show("No tiene permisos de Administrador", "Seguridad SAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            //Verificación de Rol de Administrador
           
        }
        

        private void vConsultarEmpleadosActivas()
        {
            Empleados_BO Empleadoega = new Empleados_BO();
            gvEmpleados.DataSource = Empleadoega.vConsultaEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarEmpleadosActivas();
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
            funirPrimero(gvEmpleados);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvEmpleados);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvEmpleados);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvEmpleados);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Empleados_Entity Empleado = new Empleados_Entity();
                Empleados_BO usuario = new Empleados_BO();
                Empleado.codusuario= txtBuscador.Text;
                gvEmpleados.DataSource =  usuario.vConsultaFiltro(Empleado);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string idempleado;
        private void gvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = gvEmpleados.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();

            idempleado = gvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
           


            Empleados frm = new Empleados();
            frm.txtCod.Text = idempleado;
            frm.txtCod.Visible = true;
            frm.btnNuevo.Enabled = false;
            frm.btnEditar.Enabled = false;
            frm.btnEliminar.Enabled = true;
            frm.btnGuardar.Enabled = false;
            frm.txtCod.ReadOnly = true;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(mostrarMenu.ActiveForm);
        }

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
    }
}
