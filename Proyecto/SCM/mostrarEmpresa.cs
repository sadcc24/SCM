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
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "localhost");
        public mostrarEmpresa()
        {
            InitializeComponent();
        }

        public void ActualizarGridView()
        {
            string[] usuario = Globales.Usuario.CapturarUsuario();
            string regusuario = usuario[0];
            dgvEmpresa.DataSource = cnn.getSQL("Select  empresa.idempresa, nombre_empresa From empresa Inner join Empleado ON empresa.idempresa = empleado.idempresa Inner join Usuario_1 ON empleado.codusuario = usuario_1.codusuario where usuario_1.codusuario =" + regusuario);
            int i;
            for (i= 0; i < dgvEmpresa.RowCount-1; i++)
            {
                cmbEmpresa.Items.Add(dgvEmpresa[1, i].Value.ToString());
            }
        }
        private void frmEmpresa_Load(object sender, EventArgs e)
        {
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
