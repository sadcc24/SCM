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
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;

            string query = "SELECT idsede, nombre_sede FROM [dbo].[Sede]";
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Sede");
            int i;
            gvSedes.DataSource = ds.Tables[0];
            for (i = 0; i < gvSedes.RowCount - 1; i++)
            {
                cmbSede.Items.Add(gvSedes[0, i].Value.ToString() + " " + gvSedes[1, i].Value.ToString());
            }

            string query2 = "SELECT idmoneda, nombre_moneda FROM [dbo].[Moneda]";
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Moneda");
            int i2;
            gvMonedas.DataSource = ds2.Tables[0];
            for (i2 = 0; i2 < gvMonedas.RowCount - 1; i2++)
            {
                cmbMoneda.Items.Add(gvMonedas[0, i2].Value.ToString() + " " + gvMonedas[1, i2].Value.ToString());
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Empresa.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtRazon.Text))
                {
                    MessageBox.Show("Debe agregar la razón social de la Empresa.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtActivo.Text))
                    {
                        MessageBox.Show("Debe agregar el estado de la Empresa.");
                        return;
                    }
                    else
                    {                        
                        try
                        {
                            Empresas_Entity Money = new Empresas_Entity();
                            Empresas_BO Empresas = new Empresas_BO();
                            int ssede, smoneda;
                            
                            Money.strempresa = txtEmpresa.Text;                            
                            Money.strrazon = txtRazon.Text;

                            ssede = cmbSede.SelectedIndex;
                            Money.idsede = gvSedes[0, ssede].Value.ToString();

                            smoneda = cmbMoneda.SelectedIndex;
                            Money.idmoneda = gvMonedas[0, smoneda].Value.ToString();

                            Money.strdireccion= txtDireccion.Text;
                            Money.strtelefono = txtTelefono.Text;
                            Money.stridentificacion = txtIdentificacion.Text;
                            Money.iactivo = txtActivo.Text;
                            Empresas.vInsertarEmpresa(Money);
                            MessageBox.Show("Empresa ha sido creada.");
                            string[] emp = Globales.Empresa.CapturarEmpresa();
                            if (emp[0] != "No Autenticado")
                            {
                                mantenimientoEmpresas prdu = new mantenimientoEmpresas();
                                prdu.MdiParent = this.MdiParent;
                                this.Hide();
                                prdu.Show();
                            }
                            else
                                this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Error!.");
                        }
                        
                    }
                }
            } //termina if

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = "";            
            fnConsultarUltimoId();
        }

        private void fnConsultarUltimoId()
        {
            Empresas_BO Empresas = new Empresas_BO();
            // Empresas.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            Empresas_Entity Money = new Empresas_Entity();
            Empresas_BO Empresas = new Empresas_BO();
            Money.strempresa = txtEmpresa.Text;
            Empresas.vConsultaFiltro(Money);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpresa.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Empresa.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtRazon.Text))
                {
                    MessageBox.Show("Debe agregar la razón social  de la Empresa.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtActivo.Text))
                    {
                        MessageBox.Show("Debe agregar el estado de la Empresa.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            Empresas_Entity Money = new Empresas_Entity();
                            Empresas_BO Empresas = new Empresas_BO();
                            Money.idempresa = txtCod.Text;
                            Money.idsede = cmbSede.SelectedText;
                            Money.idmoneda = cmbMoneda.SelectedText;
                            Money.strempresa = txtEmpresa.Text;
                            Money.strrazon = txtRazon.Text;
                            Money.strdireccion = txtDireccion.Text;
                            Money.strtelefono = txtTelefono.Text;
                            Money.stridentificacion = txtIdentificacion.Text;
                            Money.iactivo = txtActivo.Text;
                            Empresas.vModificarEmpresa(Money);
                                MessageBox.Show("Empresa ha sido Modificada.");
                                mantenimientoEmpresas prdu = new mantenimientoEmpresas();
                                prdu.MdiParent = this.MdiParent;
                                this.Close();
                                prdu.Show();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                } //termina if
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Debe escribir el id de la Empresas a eliminar.");
                return;
            }
            else
            {
                Empresas_Entity Money = new Empresas_Entity();
                Empresas_BO Empresas = new Empresas_BO();
                Money.idempresa = txtCod.Text;

                Empresas.vEliminarEmpresa(Money);
                MessageBox.Show("Empresa ha sido Eliminada.");
                mantenimientoEmpresas prdu = new mantenimientoEmpresas();
                prdu.MdiParent = this.MdiParent;
                this.Hide();
                prdu.Show();
            }
        }
    }
}
