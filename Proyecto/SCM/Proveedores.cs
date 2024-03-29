﻿using System;
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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            proveedores_BO proveedor = new proveedores_BO();
            proveedores_Entity prov = new proveedores_Entity();
            try {
                if (txtNombre.Text == "") {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else { 
                    prov.nombre_proveedor = txtNombre.Text;
                }
                if (txtDireccion.Text == "")
                {
                    MessageBox.Show("Campo Direccion Vacio");
                    return;
                }
                else
                {
                    prov.direccion = txtDireccion.Text;
                }
                if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Campo Telefono Vacio");
                    return;
                }
                else
                {
                    prov.telefono = int.Parse(txtTelefono.Text);
                }
                if (txtNit.Text == "")
                {
                    MessageBox.Show("Campo Nit Vacio");
                    return;
                }
                else
                {
                    prov.nit = txtNit.Text;
                }
                prov.id_sede = int.Parse(cboSede.SelectedValue.ToString());
                prov.activo = true;
                proveedor.insertProveedor(prov);
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtNit.Text = "";
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Registro de Datos");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedores_BO proveedor = new proveedores_BO();
            proveedores_Entity prov = new proveedores_Entity();
            try
            {
                prov.id_proveedor = int.Parse(txtCodigo.Text);
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Campo Nombre Vacio");
                    return;
                }
                else
                {
                    prov.nombre_proveedor = txtNombre.Text;
                }
                if (txtDireccion.Text == "")
                {
                    MessageBox.Show("Campo Direccion Vacio");
                    return;
                }
                else
                {
                    prov.direccion = txtDireccion.Text;
                }
                if (txtTelefono.Text == "")
                {
                    MessageBox.Show("Campo Telefono Vacio");
                    return;
                }
                else
                {
                    prov.telefono = int.Parse(txtTelefono.Text);
                }
                if (txtNit.Text == "")
                {
                    MessageBox.Show("Campo Nit Vacio");
                    return;
                }
                else
                {
                    prov.nit = txtNit.Text;
                }
                prov.activo = true;
                proveedor.updateProveedores(prov);
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtNit.Text = "";
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Actualizacion de Datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedores_BO proveedor = new proveedores_BO();
            proveedores_Entity prov = new proveedores_Entity();
            prov.id_proveedor = int.Parse(txtCodigo.Text);
            try
            {
                
                proveedor.deleteProveedores(prov);
                MessageBox.Show("Producto ha sido Borrado.");

                mantenimientoProveedores prdu = new mantenimientoProveedores();
                prdu.MdiParent = this.MdiParent;
                //prdu.vConsultarProductosActivos();
                this.Hide();
                prdu.Show();

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
                MessageBox.Show("Error en el Eliminacion de Datos");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNit.Text = "";
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            proveedores_BO oc = new proveedores_BO();
            DataTable dtSede = oc.verSedes();
            cboSede.DataSource = dtSede;
            cboSede.DisplayMember = "nombre_sede";
            cboSede.ValueMember = "idsede";
        }
    }
}
