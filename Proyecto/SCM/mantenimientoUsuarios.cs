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
namespace SCM
{
    public partial class mantenimientoUsuarios : Form
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        public mantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Usuarios User = new Usuarios();
            User.MdiParent = this.MdiParent;
            User.btnEditar.Enabled = false;
            User.btnEliminar.Enabled = false;
            User.txtCod.ReadOnly = true;
            this.Hide();
        
            User.Show();

      
        }

        private void mantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            string[] usuario = Globales.Usuario.CapturarUsuario();
            string query = "SELECT Rol.idrol, Rol.Rol as Rol, codusuario FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol  WHERE Status = 1 AND codusuario =" + usuario[0];
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Usuario_1");

            gvUsuariosA.DataSource = ds.Tables[0];
            Globales.Rol = gvUsuariosA.Rows[0].Cells[0].Value.ToString();
            if (Globales.Rol == "1")
            {
                //MessageBox.Show("Sí tiene permisos de Administrador");
                vConsultarUsuariosActivas();
            }
            else
            {
                MessageBox.Show("No tiene permisos de Administrador");
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            string query2 = "SELECT idrol, Rol FROM [dbo].[Rol]";
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Rol");
            int i;
            gvUsuariosA.DataSource = ds2.Tables[0];
        }
        

        private void vConsultarUsuariosActivas()
        {
            Usuarios_BO Userega = new Usuarios_BO();
            gvUsuarios.DataSource = Userega.vConsultaUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarUsuariosActivas();
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
            funirPrimero(gvUsuarios);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvUsuarios);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvUsuarios);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvUsuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Usuarios_Entity User = new Usuarios_Entity();
                Usuarios_BO usuario = new Usuarios_BO();
                User.strUsuario = txtBuscador.Text;
                gvUsuarios.DataSource =  usuario.vConsultaFiltro(User);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, usuario, rol;
        private void gvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = gvUsuarios.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();

            rol = gvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = gvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            usuario = gvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();

            Usuarios frm = new Usuarios();
            frm.txtCod.Text = id;
            //int i = int.Parse(rol);
            //frm.cmbRol.SelectedItem = i;
            frm.txtUsuario.Text = usuario;
            frm.txtPassword.Text = "";
            frm.txtPregunta.Text = "Pregunta";            
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
