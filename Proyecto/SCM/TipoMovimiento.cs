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
    public partial class TipoMovimiento : Form
    {
        public TipoMovimiento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int operacion = 0;

            if (rbSuma.Checked == true)
            {
                operacion = 1;
            }
            else
            {
                if (rbResta.Checked == true)
                {
                    operacion = 0;
                }
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar la Descripción de Tipo de Movimiento de Inventarios.");
                return;
            }
            else
            {
                try
                {
                    clsTipoMovimiento_Entity tip = new clsTipoMovimiento_Entity();
                    clsTipoMovimiento_BO tipo = new clsTipoMovimiento_BO();
                    tip.strDescripcion = txtDescripcion.Text;
                    tip.strOperacion = operacion.ToString();
                    tipo.vInsertarTipoMovimiento(tip);
                    MessageBox.Show("Tipo de Movimiento Ha sido Guardado.");
                    txtDescripcion.Text = "";
                    //  vConsultarTiposActivos();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsTipoMovimiento_Entity tip = new clsTipoMovimiento_Entity();
                clsTipoMovimiento_BO tipo = new clsTipoMovimiento_BO();
                tip.strIdTipoMovimiento = txtID.Text;
            
                tipo.vEliminarTipoMovimiento(tip);
                MessageBox.Show("Tipo de Movimiento Ha sido Eliminado.");
                //  vConsultarTiposActivos();
              

            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("No es posible eliminar este tipo de  movimiento, ya existen registros asociados en Movimientos de inventario.");

            }
        }
    }
}
