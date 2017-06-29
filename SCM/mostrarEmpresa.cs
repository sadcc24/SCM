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


namespace SCM
{
    public partial class mostrarEmpresa : Form
    {        
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "localhost");
        Enterprise Empresa = new Enterprise();

        public mostrarEmpresa()
        {
            InitializeComponent();
        }

        public void ActualizarGridView()
        {
            dgvEmpresa.DataSource = cnn.getSQL("Select  idempresa, nombre_empresa From empresa");
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
                    autenticado = Empresa.RegistrarEmpresa(dgvEmpresa[0,seleccionado].Value.ToString(), dgvEmpresa[1, seleccionado].Value.ToString());
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
            }
        }
    }
}
