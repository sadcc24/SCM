/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Líneas
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
    public partial class Lineas : Form
    {
        public Lineas()
        {
            InitializeComponent();
        }

        private void Lineas_Load(object sender, EventArgs e)
        {
            // cmbEstado.Items.Insert(1,"ACTIVO");
            //  cmbEstado.Items.Insert(0, "INACTIVO");
            btnCancelar.Enabled = false;            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Línea.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtCondicion.Text))
                {
                    MessageBox.Show("Debe agregar la condicíon de la línea.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEstado.Text))
                    {
                        MessageBox.Show("Debe agregar el estao de la línea.");
                        return;
                    }
                    else
                    {                        
                        try
                        {
                            Lineas_Entity Line = new Lineas_Entity();
                            Lineas_BO Lineas = new Lineas_BO();
                            Line.strDescripcion = txtDescripcion.Text;
                            Line.iCondicion = txtCondicion.Text;
                            Line.iEstado = txtEstado.Text;
                            Lineas.vInsertarLinea(Line);
                            MessageBox.Show("Línea ha sido creada.");
                            mantenimientoLineas prdu = new mantenimientoLineas();
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
            txtDescripcion.Text = "";            
            fnConsultarUltimoId();
        }

        private void fnConsultarUltimoId()
        {
            Lineas_BO Lineas = new Lineas_BO();
            // Lineas.vConsultarID();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {
            Lineas_Entity Line = new Lineas_Entity();
            Lineas_BO Lineas = new Lineas_BO();
            Line.strDescripcion= txtDescripcion.Text;
            Lineas.vConsultaFiltro(Line);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar la descripción de la Línea.");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtCondicion.Text))
                {
                    MessageBox.Show("Debe agregar la condicíon de la línea.");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtEstado.Text))
                    {
                        MessageBox.Show("Debe agregar el estao de la línea.");
                        return;
                    }
                    else
                    {
                        try
                        {
                            Lineas_Entity Line = new Lineas_Entity();
                            Lineas_BO Lineas = new Lineas_BO();
                            Line.iCodLineas = txtCod.Text;
                            Line.strDescripcion = txtDescripcion.Text;
                            Line.iCondicion = txtCondicion.Text;
                            Line.iEstado = txtEstado.Text;
                            Lineas.vModificarLinea(Line);
                                MessageBox.Show("Lineas ha sido Modificado.");
                                mantenimientoLineas prdu = new mantenimientoLineas();
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
                MessageBox.Show("Debe escribir el id de la Lineas a eliminar.");
                return;
            }
            else
            {
                Lineas_Entity Line = new Lineas_Entity();
                Lineas_BO Lineas = new Lineas_BO();
                Line.iCodLineas = txtCod.Text;

                Lineas.vEliminarLinea(Line);
                MessageBox.Show("Lineaa ha sido Eliminada.");
                mantenimientoLineas prdu = new mantenimientoLineas();
                prdu.MdiParent = this.MdiParent;
                this.Hide();
                prdu.Show();
            }
        }
    }
}
