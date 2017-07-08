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
    public partial class Bodegas : Form
    {
        public Bodegas()
        {
            InitializeComponent();
        }

        private void Bodegas_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           
               if (string.IsNullOrEmpty(txtBodega.Text))
                {
                    MessageBox.Show("Debe agregar el nombre de la bodega.");
                    return;
                }
                else {
                    if (string.IsNullOrEmpty(txtEncargado.Text))
                    {
                        MessageBox.Show("Debe agregar el nombre del encargado de la bodega.");
                        return;
                    }
                    else {
                        if (string.IsNullOrEmpty(txtSMin.Text))
                        {
                            MessageBox.Show("Debe agregar el stock mínimo en la bodega.");
                            return;
                        }
                        else {
                            if (string.IsNullOrEmpty(txtSMax.Text))
                            {
                                MessageBox.Show("Debe agregar el stock máximo en la bodega.");
                                return;
                            }
                            else {
                                int smin, smax;
                                smin = (Convert.ToInt32(txtSMin.Text.ToString()));
                                smax = (Convert.ToInt32(txtSMax.Text.ToString()));
                                if (smin > smax)
                                {
                                    MessageBox.Show("Stock mínimo debe ser menor o igual que el stock máximo.");
                                    return;
                                }
                                else {

                               

                                try
                                {
                                    clsBodegas_Entity bod = new clsBodegas_Entity();
                                    clsBodegas_BO bodega = new clsBodegas_BO();
                                    bod.strNombreBodega = txtBodega.Text;
                                    bod.strNombreEncargado = txtEncargado.Text;
                                    bod.iStockMinimo = txtSMin.Text;
                                    bod.iStockMaximo = txtSMax.Text;
                                    string[] empresa = Globales.Empresa.CapturarEmpresa();
                                    bod.iIdEmpresa = empresa[0];
                                    bodega.vInsertarBodega(bod);
                                    MessageBox.Show("Bodega ha sido guardada.");
                                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Guardar Bodegas.");
                                    mantenimientoBodegas prdu = new mantenimientoBodegas();
                                    prdu.MdiParent = this.MdiParent;
                                    this.Hide();
                                    prdu.Show();
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            }
                        }
                    }

                } //termina if





        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBodega.Text = "";
            txtEncargado.Text = "";
            txtSMax.Text = "";
            txtSMin.Text = "";
            fnConsultarUltimoId();
        }

        private void fnConsultarUltimoId()
        {
            clsBodegas_BO bodega = new clsBodegas_BO();
           // bodega.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            clsBodegas_Entity bod = new clsBodegas_Entity();
            clsBodegas_BO bodega = new clsBodegas_BO();
            bod.strNombreBodega = txtBodega.Text;
            bodega.vConsultaFiltro(bod);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtID.Text))
                {
                MessageBox.Show("Debe escribir el id de la bodega a editar.");
                return;
            } else {
                if (string.IsNullOrEmpty(txtBodega.Text))
                {
                    MessageBox.Show("Debe agregar el nombre de la bodega.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEncargado.Text))
                    {
                        MessageBox.Show("Debe agregar el nombre del encargado de la bodega.");
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtSMin.Text))
                        {
                            MessageBox.Show("Debe agregar el stock mínimo en la bodega.");
                            return;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtSMax.Text))
                            {
                                MessageBox.Show("Debe agregar el stock máximo en la bodega.");
                                return;
                            }
                            else
                            {
                                int smin, smax;
                                smin = (Convert.ToInt32(txtSMin.Text.ToString()));
                                smax = (Convert.ToInt32(txtSMax.Text.ToString()));
                                if (smin > smax)
                                {
                                    MessageBox.Show("Stock mínimo debe ser menor o igual que el stock máximo.");
                                    return;
                                }
                                else
                                {



                                    try
                                    {
                                        clsBodegas_Entity bod = new clsBodegas_Entity();
                                        clsBodegas_BO bodega = new clsBodegas_BO();
                                        bod.iIdBodega = txtID.Text;
                                        bod.strNombreBodega = txtBodega.Text;
                                        bod.strNombreEncargado = txtEncargado.Text;
                                        bod.iStockMinimo = txtSMin.Text;
                                        bod.iStockMaximo = txtSMax.Text;
                                        bodega.vModificarBodega(bod);
                                        MessageBox.Show("Bodega ha sido Modificada.");
                                        Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Modificar Bodegas.");
                                        mantenimientoBodegas prdu = new mantenimientoBodegas();
                                        Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Consultar Bodegas.");
                                        prdu.MdiParent = this.MdiParent;
                                        this.Hide();
                                        prdu.Show();
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                    }

                } //termina if
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe escribir el id de la bodega a editar.");
                return;
            }
            else
            {
                if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsBodegas_Entity bod = new clsBodegas_Entity();
                    clsBodegas_BO bodega = new clsBodegas_BO();
                    bod.iIdBodega = txtID.Text;

                    bodega.vEliminarBodega(bod);
                    MessageBox.Show("Bodega ha sido Eliminada.");
                    Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Eliminar Bodegas.");
                    mantenimientoBodegas prdu = new mantenimientoBodegas();
                    prdu.MdiParent = this.MdiParent;
                    this.Hide();
                    prdu.Show();  
                }
                
                
                
                
            }
            }
    }
}
