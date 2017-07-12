/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Monedas
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

namespace SCM
{
    public partial class Monedas : Form
    {
        public Monedas()
        {
            InitializeComponent();
        }

        private void Monedas_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtMoneda.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Moneda.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtSimbolo.Text))
                {
                    MessageBox.Show("Debe agregar la condicíon de la Moneda.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtActivo.Text))
                    {
                        MessageBox.Show("Debe agregar el estao de la Moneda.");
                        return;
                    }
                    else
                    {                        
                        try
                        {
                            Monedas_Entity Money = new Monedas_Entity();
                            Monedas_BO Monedas = new Monedas_BO();
                            Money.strmoneda = txtMoneda.Text;
                            Money.strsimbolo = txtSimbolo.Text;
                            Money.iactivo = txtActivo.Text;
                            Monedas.vInsertarMoneda(Money);
                            MessageBox.Show("Moneda ha sido creada.");
                            mantenimientoMonedas prdu = new mantenimientoMonedas();
                            prdu.MdiParent = this.MdiParent;
                            this.Hide();
                            prdu.Show();
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
            txtMoneda.Text = "";            
            fnConsultarUltimoId();
        }

        private void fnConsultarUltimoId()
        {
            Monedas_BO Monedas = new Monedas_BO();
            // Monedas.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            Monedas_Entity Money = new Monedas_Entity();
            Monedas_BO Monedas = new Monedas_BO();
            Money.strmoneda = txtMoneda.Text;
            Monedas.vConsultaFiltro(Money);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoneda.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Moneda.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtSimbolo.Text))
                {
                    MessageBox.Show("Debe agregar la condicíon de la Moneda.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtActivo.Text))
                    {
                        MessageBox.Show("Debe agregar el estao de la Moneda.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            Monedas_Entity Money = new Monedas_Entity();
                            Monedas_BO Monedas = new Monedas_BO();
                            Money.idmoneda= txtCod.Text;
                            Money.strmoneda = txtMoneda.Text;
                            Money.strsimbolo = txtSimbolo.Text;
                            Money.iactivo = txtActivo.Text;
                            Monedas.vModificarMoneda(Money);
                                MessageBox.Show("Moneda ha sido Modificada.");
                                mantenimientoMonedas prdu = new mantenimientoMonedas();
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
                MessageBox.Show("Debe escribir el id de la Monedas a eliminar.");
                return;
            }
            else
            {
                Monedas_Entity Money = new Monedas_Entity();
                Monedas_BO Monedas = new Monedas_BO();
                Money.idmoneda = txtCod.Text;

                Monedas.vEliminarMoneda(Money);
                MessageBox.Show("Moneda ha sido Eliminada.");
                mantenimientoMonedas prdu = new mantenimientoMonedas();
                prdu.MdiParent = this.MdiParent;
                this.Hide();
                prdu.Show();
            }
        }
    }
}
