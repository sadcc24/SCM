﻿/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Menú
    Fecha de asignación: 23/Junio
    Fecha de entrega: 20/Junio
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
using DAL;

namespace SCM
{
    public partial class mostrarMenu : Form
    {
        private int childFormNumber = 0;

        public mostrarMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void movimientosAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoInventario temp = new ingresoInventario();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;            
            temp.Show();
        }

        private void facturasDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoFacturaProveedor temp = new ingresoFacturaProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void devoluciónAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaDevolucionProveedor temp = new generaDevolucionProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void contraseñaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generaContrasena temp = new generaContrasena();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void pagoAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorizaPagoProveedores temp = new autorizaPagoProveedores();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoOrdenCompra temp = new ingresoOrdenCompra();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaciónDeÓrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizacionOC temp = new AutorizacionOC();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void transportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarSolicitudTransporte temp = new buscarSolicitudTransporte();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoDeOrdenDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verOrdenes temp = new verOrdenes();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaciónDeOrdenDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AutorizacionOC temp = new AutorizacionOC();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimientosAlInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Movimientos de Inventario");
            ingresoInventario temp = new ingresoInventario();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ordenesDeCompraRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoTrasladoEntreBodegas temp = new ingresoTrasladoEntreBodegas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void órdenesDeCompraPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoFacturaProveedor temp = new ingresoFacturaProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturasIngresadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            generaDevolucionProveedor temp = new generaDevolucionProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void proveedoresYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Genera Contraseña");
            generaContrasena temp = new generaContrasena();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void autorizaPagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorizaPagoProveedores temp = new autorizaPagoProveedores();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void manteniminetoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Mantenimiento de Productos");
            mantenimientoProductos temp = new mantenimientoProductos();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Mantenimiento de Bodegas");
            mantenimientoBodegas temp = new mantenimientoBodegas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void vehículosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buscarVehiculos temp = new buscarVehiculos();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void solicitudDeTransportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarSolicitudTransporte temp = new buscarSolicitudTransporte();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void serviciosAVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoOrdenServicio temp = new ingresoOrdenServicio();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void congelarExitenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Congelar Existencias");
            congelarExistencias temp = new congelarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void capturarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Capturar Existencias");
            capturarExistencias temp = new capturarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ajustarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Ajustar Existencias");
            ajustarExistencias temp = new ajustarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void descongelarExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Descongelar Existencias");
            descongelarExistencias temp = new descongelarExistencias();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoProveedores temp = new mantenimientoProveedores();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mostrarMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            //Captura de Rol, Usuario, Moneda y Empresa Actuales de Seguridad SAD
            string rolactual = Globales.Usuario.CapturarRol(Globales.Conexion);
            string[] usuario = Globales.Usuario.CapturarUsuario();
            this.tsStatusUsuario.Text = usuario[1];
            string[] moneda = Globales.Usuario.CapturarMoneda(Globales.Conexion);
            this.tsStatusMoneda.Text = moneda[1];
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            this.tsStatusEmpresa.Text = empresa[1];
            //Captura de Fecha Actual
            this.tsStatusFecha.Text = DateTime.Now.ToString("D");
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Aplicación Cerrada");
            Application.Exit();
        }

        private void cambiarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cambio;
            this.Hide();
            cambio = MessageBox.Show("¿Está seguro de cambiar de Empresa?", "Seguridad SAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cambio == DialogResult.Yes)
            {
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Cambio de Empresa");
                mostrarEmpresa temp = new mostrarEmpresa();   
                temp.Show();
            }
            else
            {                
                this.Show();
            }
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cambio;
            this.Hide();
            cambio = MessageBox.Show("¿Está seguro de cambiar de Usuario?", "Seguridad SAD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cambio == DialogResult.Yes)
            {
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Sesión Finalizada");
                mostrarLogin temp = new mostrarLogin();
                temp.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void mantenimientoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoUsuarios temp = new mantenimientoUsuarios();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientosLíneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Mantenimiento de Lineas");
            mantenimientoLineas temp = new mantenimientoLineas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Mantenimiento de Tipos de Movimiento");
            mantenimientoTipoMovimientoInventario temp = new mantenimientoTipoMovimientoInventario();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Mantenimiento de Marcas");
            mantenimientoMarca temp = new mantenimientoMarca();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void tipoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoTipoVehiculo temp = new mantenimientoTipoVehiculo();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void tipoTrayectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoTrayecto temp = new mantenimientoTrayecto();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void estadoSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEstadoSolicitud temp = new mantenimientoEstadoSolicitud();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void tipoSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoTipoSolicitud temp = new mantenimientoTipoSolicitud();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void bitácoraDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora temp = new Bitacora();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mantenimientoMonedas temp = new mantenimientoMonedas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }
        private void kardexProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kardexProductos temp = new kardexProductos();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEmpresas temp = new mantenimientoEmpresas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void asignaciónDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEmpleados temp = new mantenimientoEmpleados();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoEstadoContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEstadoContrasena temp = new mantenimientoEstadoContrasena();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoEstadoOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEstadoOrdenCompra temp = new mantenimientoEstadoOrdenCompra();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoEstadosFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoEstadoFacturas temp = new mantenimientoEstadoFacturas();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void mantenimientoTipoOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoTipoOrdenCompra temp = new mantenimientoTipoOrdenCompra();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verCuentaxPagar temp = new verCuentaxPagar();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }
    }
}
