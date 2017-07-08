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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar la Descripción de Tipo de Movimiento de Inventarios.");
                return;
            }
            else
            {
                try
                {
                    clsMarcas_Entity marc = new clsMarcas_Entity();
                    clsMarcas_BO marcas = new clsMarcas_BO();
                    marc.strDescripcion = txtDescripcion.Text;
                    marcas.vInsertarMarca(marc);
                    MessageBox.Show("Marca Ha sido Guardada.");
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Guardar Marca.");
                    // vConsultarMarcasDisponibles();
                    txtDescripcion.Text = "";
                

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsMarcas_Entity tip = new clsMarcas_Entity();
                clsMarcas_BO  tipo = new clsMarcas_BO();
                tip.strIdMarca = txtID.Text;

                tipo.vEliminarMarca(tip);
                MessageBox.Show("Marca ha sido eliminada..");
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Eliminar Marca.");
                //  vConsultarTiposActivos();


            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                string error = ex.ToString();
                MessageBox.Show("No es posible eliminar la marca, hay productos asociados a la misma.");

            }
        }

        private void Marca_Load(object sender, EventArgs e)
        {

        }
    }
}
