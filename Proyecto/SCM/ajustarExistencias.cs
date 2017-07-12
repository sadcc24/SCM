/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Auditoria
    Fecha de asignación: 27/Junio
    Fecha de entrega: 12/Julio
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
    public partial class ajustarExistencias : Form
    {
        public ajustarExistencias()
        {
            InitializeComponent();
        }

        private void btnCongelar_Click(object sender, EventArgs e)
        {
            /*Clases de Congelación
                <1. Rango productos
                <2. Línea
                <3. Marca
                <4. Rango productos con Línea
                <5. Rango productos con Marca
                <6. Línea con Marcas
                <7. Rango productos con Línea y Marca
                8. Bodega
                9. Bodega con Rango productos
                10. Bodega con Línea
                11. Bodega con Marca
                12. Bodega con Rango productos con Línea    
                13. Bodega con Rango productos con Marca
                14. Bodega con Línea con Marca
                15. Bodega con Rango productos con Línea y Marca             
                */
            int caseCongelar = 0;
            if ((txtDesde.Text != "") && (txtHasta.Text != ""))
                caseCongelar = 1;
            if (cmbLinea.SelectedIndex != -1)
                caseCongelar = 2;
            if (cmbMarca.SelectedIndex != -1)
                caseCongelar = 3;
            if ((txtDesde.Text != "") && (txtHasta.Text != "") && (cmbLinea.SelectedIndex != -1))
                caseCongelar = 4;
            if ((txtDesde.Text != "") && (txtHasta.Text != "") && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 5;
            if ((cmbLinea.SelectedIndex != -1) && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 6;
            if ((txtDesde.Text != "") && (txtHasta.Text != "") && (cmbLinea.SelectedIndex != -1) && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 7;
            if (cmbBodega.SelectedIndex != -1)
                caseCongelar = 8;
            if ((cmbBodega.SelectedIndex != -1) && (txtDesde.Text != "") && (txtHasta.Text != ""))
                caseCongelar = 9;
            if ((cmbBodega.SelectedIndex != -1) && (cmbLinea.SelectedIndex != -1))
                caseCongelar = 10;
            if ((cmbBodega.SelectedIndex != -1) && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 11;
            if ((cmbBodega.SelectedIndex != -1) && (txtDesde.Text != "") && (txtHasta.Text != "") && (cmbLinea.SelectedIndex != -1))
                caseCongelar = 12;
            if ((cmbBodega.SelectedIndex != -1) && (txtDesde.Text != "") && (txtHasta.Text != "") && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 13;
            if ((cmbBodega.SelectedIndex != -1) && (cmbLinea.SelectedIndex != -1) && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 14;
            if ((cmbBodega.SelectedIndex != -1) && (txtDesde.Text != "") && (txtHasta.Text != "") && (cmbLinea.SelectedIndex != -1) && (cmbMarca.SelectedIndex != -1))
                caseCongelar = 15;

            // MessageBox.Show(caseCongelar.ToString(), "Clases de Congelación");

            switch (caseCongelar)
            {
                case 8:
                    //Congelar por Bodega
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        string query5 = "SELECT idbodega,idproducto,cantidad FROM [dbo].[Existencia] where idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por bodega.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 9:
                    //Congelar por Productos
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        string query5 = "SELECT idbodega,idproducto,cantidad FROM [dbo].[Existencia] where idproducto between " + txtDesde.Text.ToString() + " and " + txtHasta.Text.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 10:
                    //Congelar por Línea
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int linea;
                        linea = cmbLinea.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Linea ON Producto.idlinea = Linea.idlinea WHERE linea.idlinea = " + dgvLineas[0, linea].Value.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por línea.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 11:
                    //Congelar por Marca
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int marca;
                        marca = cmbMarca.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Marca ON Producto.idmarca = Marca.idmarca WHERE marca.idmarca = " + dgvMarcas[0, marca].Value.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por marca.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 12:
                    //Congelar por Productos con Línea
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int linea;
                        linea = cmbLinea.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Linea ON Producto.idlinea = Linea.idlinea  where idproducto between " + txtDesde.Text.ToString() + " and " + txtHasta.Text.ToString() + " and WHERE linea.idlinea = " + dgvLineas[0, linea].Value.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por productos con línea.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 13:
                    //Congelar por Productos con Marca
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int marca;
                        marca = cmbMarca.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Marca ON Producto.idmarca = Marca.idmarca where idproducto between " + txtDesde.Text.ToString() + " and " + txtHasta.Text.ToString() + " and WHERE marca.idmarca = " + dgvMarcas[0, marca].Value.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por productos con marca.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 14:
                    //Congelar por Línea con Marca
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int linea;
                        linea = cmbLinea.SelectedIndex;
                        int marca;
                        marca = cmbMarca.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Linea ON Producto.idlinea = Linea.idlinea INNER JOIN Marca ON Producto.idmarca = Marca.idmarca WHERE linea.idlinea = " + dgvLineas[0, linea].Value.ToString() + " AND marca.idmarca = " + dgvMarcas[0, marca].Value.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por línea y marca.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 15:
                    //Congelar por Rango de productos con Línea y Marca
                    try
                    {
                        int bodega;
                        bodega = cmbBodega.SelectedIndex;
                        int linea;
                        linea = cmbLinea.SelectedIndex;
                        int marca;
                        marca = cmbMarca.SelectedIndex;
                        string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Linea ON Producto.idlinea = Linea.idlinea INNER JOIN Marca ON Producto.idmarca = Marca.idmarca WHERE linea.idlinea = " + dgvLineas[0, linea].Value.ToString() + " AND marca.idmarca = " + dgvMarcas[0, marca].Value.ToString() + " AND where Producto.idproducto between " + txtDesde.Text.ToString() + " and " + txtHasta.Text.ToString() + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
                        DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Existencia");
                        dgvExistencias.DataSource = ds3.Tables[0];
                        dgvExistencias.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al congelar por productos con línea y marca.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    {
                        //throw new NotImplementedException ("Debe seleccionar una bodega.");
                        MessageBox.Show("Debe seleccionar una bodega", "Error al congelar existencias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }

            MessageBox.Show("Existencias seleccionadas: " + dgvExistencias.RowCount.ToString(), "Congelar Existencias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "InventarioFisico", dgvExistencias.RowCount.ToString() + "Existencias seleccionadas");
            if (dgvExistencias.RowCount == 0)
            {
                MessageBox.Show("No hay existencias!\nSeleccione otros parámetros ", "Congelar Existencias",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
                cmbBodega.Enabled = false;
                cmbLinea.Enabled = false;
                cmbMarca.Enabled = false;
                btnCongelar.Enabled = false;
                btnAjustar.Enabled = true;
                dgvExistencias.Visible = false;
                gbxMovimientos.Visible = true;
            }
        }

        private void ajustarExistencias_Load(object sender, EventArgs e)
        {
            string[] usuario = Globales.Usuario.CapturarUsuario();
            //cmbLinea
            string query = "SELECT idlinea, descripcion FROM [dbo].[Linea] where estado = 1";
            DataSet ds = Globales.Usuario.EjecutarQuery(Globales.Conexion, query, "Linea");
            int i;
            dgvLineas.DataSource = ds.Tables[0];
            for (i = 0; i < dgvLineas.RowCount - 1; i++)
            {
                cmbLinea.Items.Add(dgvLineas[0, i].Value.ToString() + " " + dgvLineas[1, i].Value.ToString());
            }
            //cmbBodega            
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            string query2 = "SELECT idbodega, nombre_bodega FROM [dbo].[Bodega] where activo = 1 and idempresa=" + empresa[0];
            DataSet ds2 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query2, "Bodega");
            dgvBodega.DataSource = ds2.Tables[0];
            for (i = 0; i < dgvBodega.RowCount - 1; i++)
            {
                cmbBodega.Items.Add(dgvBodega[0, i].Value.ToString() + " " + dgvBodega[1, i].Value.ToString());
            }
            //cmbMarca
            string query3 = "SELECT idmarca, descripcion FROM [dbo].[Marca]";
            DataSet ds3 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query3, "Marca");
            dgvMarcas.DataSource = ds3.Tables[0];
            for (i = 0; i < dgvMarcas.RowCount - 1; i++)
            {
                cmbMarca.Items.Add(dgvMarcas[0, i].Value.ToString() + " " + dgvMarcas[1, i].Value.ToString());
            }
            //cmbEntrada
            string query4 = "SELECT idtipomovimiento, descripcion FROM [dbo].[TipoMovimiento] where operacion = 1";
            DataSet ds4 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query4, "Marca");
            dgvEntrada.DataSource = ds4.Tables[0];
            for (i = 0; i < dgvEntrada.RowCount - 1; i++)
            {
                cmbEntrada.Items.Add(dgvEntrada[0, i].Value.ToString() + " " + dgvEntrada[1, i].Value.ToString());
            }
            //cmbSalida
            string query5 = "SELECT idtipomovimiento, descripcion FROM [dbo].[TipoMovimiento] where operacion = 0";
            DataSet ds5 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query5, "Marca");
            dgvSalida.DataSource = ds5.Tables[0];
            for (i = 0; i < dgvSalida.RowCount - 1; i++)
            {
                cmbSalida.Items.Add(dgvSalida[0, i].Value.ToString() + " " + dgvSalida[1, i].Value.ToString());
            }
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            //Actualizar Detalle Inventario Físico
            try
            {
                string[] usuario = Globales.Usuario.CapturarUsuario();
                string rol = Globales.Usuario.CapturarRol(Globales.Conexion);

                string query4 = "";

                int i;
                for (i = 0; i < dgvDetalleInventarioFisico.RowCount; i++)
                {

                    //MessageBox.Show(i.ToString());
                    query4 += "UPDATE [dbo].[DETALLEINVENTARIOFISICO] SET [existencia_fisica] = " + dgvDetalleInventarioFisico[3, i].Value.ToString() + " where idproducto = " + dgvDetalleInventarioFisico[0, i].Value.ToString() + " and idinventariofisico = IDENT_CURRENT('INVENTARIOFISICO')";

                }


                DataSet ds4 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query4, "MovimientosInventario");
                //dgvExistencias.DataSource = ds4.Tables[0];
                //dgvExistencias.Visible = true;
                MessageBox.Show("Las existencias han sido ajustadas", "Congelar Existencias",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globales.Usuario.RegistrarBitácora(Globales.Conexion, "InventarioFisico", "Existencias ajustadas");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al ajustar existencias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
