/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Seguridad
    Fecha de asignación: 13/Junio
    Fecha de entrega: 27/Junio
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
using Microsoft.Win32;
using dllSeguridadSAD;
using DAL;

namespace SCM
{
    public partial class mostrarEmpresa : Form
    {
        MRP_BD cnn = Globales.cnn;
        public mostrarEmpresa()
        {
            InitializeComponent();
        }

        public void ActualizarGridView()
        {
            string[] usuario = Globales.Usuario.CapturarUsuario();
            if (usuario[0] != "No Autenticado")
            {                
                dgvEmpresa.DataSource = cnn.getSQL("Select  empresa.idempresa, nombre_empresa From empresa Inner join Empleado ON empresa.idempresa = empleado.idempresa Inner join Usuario_1 ON empleado.codusuario = usuario_1.codusuario where usuario_1.codusuario =" + usuario[0]);
                int i;
                for (i = 0; i < dgvEmpresa.RowCount - 1; i++)
                {
                    cmbEmpresa.Items.Add(dgvEmpresa[1, i].Value.ToString());
                }
            }
            if (cmbEmpresa.Items.Count == 0)
            {
                
                MessageBox.Show("El usuario " +usuario[1] + " no tiene asignado ninguna empresa", "Seguridad SAD",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Verificación de Rol de Administrador            
                if (Globales.Usuario.CapturarRol(Globales.Conexion) == "1")
                {
                    //MessageBox.Show("Sí tiene permisos de Administrador");

                    Empleados frm = new Empleados();
                    frm.ShowInTaskbar = false;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(mostrarEmpresa.ActiveForm);

                }
                else
                {
                    MessageBox.Show("No tiene permisos de Administrador", "Seguridad SAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.BeginInvoke(new MethodInvoker(this.Close));
                }
                //Verificación de Rol de Administrador

            }
        }
        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            string[] emp = Globales.Empresa.CapturarEmpresa();
            if (emp[0] == "No Autenticado")
            {
                MessageBox.Show("Debe crear una empresa", "Seguridad SAD",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empresas frm = new Empresas();
                frm.txtCod.ReadOnly = true;
                frm.btnEditar.Enabled = false;
                frm.btnEliminar.Enabled = false;
                frm.txtCod.ReadOnly = true;
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(mostrarEmpresa.ActiveForm);

                Empleados frm2 = new Empleados();
                frm2.ShowInTaskbar = false;
                frm2.StartPosition = FormStartPosition.CenterScreen;
                frm2.ShowDialog(mostrarEmpresa.ActiveForm);
            }
            else
                this.Close();
            ActualizarGridView();            
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Hide();            
            bool autenticado = false;
            int seleccionado = 0;
            try
            {
                seleccionado = cmbEmpresa.SelectedIndex;
                if ((cmbEmpresa.Text != "") && (cmbEmpresa.Text != "Seleccione"))
                    autenticado = Globales.Empresa.RegistrarEmpresa(dgvEmpresa[0,seleccionado].Value.ToString(), dgvEmpresa[1, seleccionado].Value.ToString());
                else
                {
                    MessageBox.Show("Seleccione una empresa", "Seguridad SAD",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                    
                }
                if (autenticado == true)
                {
                    // MessageBox.Show("¡Bienvenido " + dgvEmpresa[1, seleccionado].Value.ToString() + "!", "Seguridad SAD",
                    //             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Empresa seleccionada");
                    mostrarMenu temp = new mostrarMenu();
                    this.Hide();
                    temp.Show();
                }
                else
                    this.Show();
            }
            catch
            {
                //en caso que la contraseña sea erronea mostrara un mensaje
                //dentro de los parentesis va: "Mensaje a mostrar","Titulo de la ventana",botones a mostrar en ste caso OK, icono a mostrar en este caso uno de error
                MessageBox.Show("Seleccione una empresa", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Error en Selección de Empresa");
            }
        }
    }
}
