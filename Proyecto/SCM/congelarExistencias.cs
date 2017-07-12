/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Congelar Existencias
    Fecha de asignación: 20/Junio
    Fecha de entrega: 09/Julio
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
    public partial class congelarExistencias : Form
    {
        public congelarExistencias()
        {
            InitializeComponent();
        }

        private void congelarExistencias_Load(object sender, EventArgs e)
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
            string query2 = "SELECT idbodega, nombre_bodega FROM [dbo].[Bodega] where activo = 1 and idempresa=" +  empresa[0];
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
        }

        private void btnCongelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("¿Está seguro de congelar estas existencias?", "Congelar Existencias",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
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
                            string query5 = "SELECT idbodega,Producto.idproducto,cantidad FROM [dbo].[Existencia] INNER JOIN Producto ON Existencia.idproducto = Producto.idproducto INNER JOIN Linea ON Producto.idlinea = Linea.idlinea WHERE linea.idlinea = " + dgvLineas[0, linea].Value.ToString()  + " and idbodega = " + dgvBodega[0, bodega].Value.ToString();
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

                
                //Crear Inventario Físico
                try
                {
                    string[] usuario = Globales.Usuario.CapturarUsuario();
                    string rol = Globales.Usuario.CapturarRol(Globales.Conexion);

                    string query4 = "begin try" +
                        "--inicio la transaccion"+
                        "begin tran"+

                        "declare @idinventario int" +
                        "declare @total int"+

                        "INSERT INTO[DBO].[INVENTARIOFISICO](fecha, codusuario, idrol) VALUES(GETDATE(), 2012, 1)" +


                        "SELECT @idinventario = SCOPE_IDENTITY()--identity de sesión y alcance actual" +

                        "--SELECT SCOPE_IDENTITY() AS[SCOPE_IDENTITY]; identity de sesión acutla y alcance global" +

                       "--SELECT @@IDENTITY AS[@@IDENTITY];" +
                                        "--DECLARE @i INT = 0;" +
                                        "--SELECT @total = 2;" +

                                        "--WHILE @i < @total" +
                                        "--BEGIN" +

                                        "INSERT INTO[dbo].[DETALLEINVENTARIOFISICO]([idbodega],[idproducto],[idinventariofisico],[existencia_congelada],[existencia_fisica]) VALUES(2,6, @idinventario,(SELECT cantidad FROM[dbo].[Existencia] where idbodega = 2 and idproducto = 6),0)" +

	                    "--SET @i = @i + 1;" +

	                    "--END" +


                        "commit" +
                    "end try" +
                    "begin catch" +

	                    "-- si hay error vuelvo a atras" +

                        "rollback" +

                    "end catch" +
                    "go";


                    DataSet ds4 = Globales.Usuario.EjecutarQuery(Globales.Conexion, query4, "InventarioFisico");
                    //dgvExistencias.DataSource = ds4.Tables[0];
                    //dgvExistencias.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al crear inventario físico.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
               
                
                MessageBox.Show("Las existencias han sido congeladas", "Congelar Existencias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            

        }

        private void gbxProductos_Enter(object sender, EventArgs e)
        {

        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void txtHasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void txtDesde_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblBodega_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLíneas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
