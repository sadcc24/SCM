/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Empresas
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
    public partial class mantenimientoEmpresas : Form
    {
        MRP_BD cnn = Globales.cnn;
        public mantenimientoEmpresas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Empresas Empresa = new Empresas();
            Empresa.MdiParent = this.MdiParent;
            Empresa.btnEditar.Enabled = false;
            Empresa.btnEliminar.Enabled = false;
            Empresa.txtCod.ReadOnly = true;
            this.Hide();
        
            Empresa.Show();

      
        }

        private void mantenimientoEmpresas_Load(object sender, EventArgs e)
        {
            //Verificación de Rol de Administrador            
            if (Globales.Usuario.CapturarRol(Globales.Conexion) == "1")
            {
                //MessageBox.Show("Sí tiene permisos de Administrador");
                vConsultarEmpresasActivas();
            }
            else
            {
                MessageBox.Show("No tiene permisos de Administrador", "Seguridad SAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            //Verificación de Rol de Administrador
            
        }
        

        private void vConsultarEmpresasActivas()
        {
            Empresas_BO Empresaega = new Empresas_BO();
            gvEmpresas.DataSource = Empresaega.vConsultaEmpresas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            vConsultarEmpresasActivas();
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
            funirPrimero(gvEmpresas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirAnterior(gvEmpresas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(gvEmpresas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(gvEmpresas);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Empresas_Entity Empresa = new Empresas_Entity();
                Empresas_BO usuario = new Empresas_BO();
                Empresa.strempresa = txtBuscador.Text;
                gvEmpresas.DataSource =  usuario.vConsultaFiltro(Empresa);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public string id, Empresa, idSede, idMoneda, razon, direccion, telefono, identificacion, activo;
        private void gvEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataIndexNo = gvEmpresas.Rows[e.RowIndex].Index.ToString();
            string cellValue = gvEmpresas.Rows[e.RowIndex].Cells[1].Value.ToString();

            id = gvEmpresas.Rows[e.RowIndex].Cells[0].Value.ToString();
            Empresa = gvEmpresas.Rows[e.RowIndex].Cells[1].Value.ToString();
            idSede = gvEmpresas.Rows[e.RowIndex].Cells[2].Value.ToString();
            idMoneda = gvEmpresas.Rows[e.RowIndex].Cells[4].Value.ToString();
            razon = gvEmpresas.Rows[e.RowIndex].Cells[6].Value.ToString();
            direccion = gvEmpresas.Rows[e.RowIndex].Cells[7].Value.ToString();
            telefono = gvEmpresas.Rows[e.RowIndex].Cells[8].Value.ToString();
            identificacion = gvEmpresas.Rows[e.RowIndex].Cells[9].Value.ToString();

            Empresas frm = new Empresas();
            frm.txtCod.Text = id;            
            frm.txtEmpresa.Text = Empresa;
            frm.txtActivo.Text = "1";
            frm.txtRazon.Text = razon;
            frm.txtDireccion.Text = direccion;
            frm.txtTelefono.Text = telefono;
            frm.txtIdentificacion.Text = identificacion;
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
