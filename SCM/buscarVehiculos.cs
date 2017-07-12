using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BO;

namespace SCM
{
    public partial class buscarVehiculos : Form
    {
        public buscarVehiculos()
        {
            InitializeComponent();
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funirPrimero(grdVehiculos);
        }
             

        private void buscarVehiculos_Load(object sender, EventArgs e)
        {
            ActualizarForm(1);
            CargaCBTipo();
        }

        private void grdVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!(e.RowIndex > -1))
            {
                return;
            }

            DataGridViewRow row = grdVehiculos.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            //int codigo = Convert.ToInt32(valor);
            ingresoVehiculo vehiculo = new ingresoVehiculo(valor);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();
        }

        #region Funciones y Metodos
        private void ActualizarForm(int tipo)
        {
            vehiculo_Entity vc = new vehiculo_Entity();
            vc._chasis = txtChasis.Text.Trim();
            vc._marca = txtMarca.Text.Trim();
            vc._modelo = txtModelo.Text.Trim();
            vc._motor = txtMotor.Text.Trim();
            vc._placa = txtPlaca.Text.Trim();
            if(tipo == 2)
            {
                vc._tipovehiculo = Convert.ToInt32(cmbTipo.SelectedValue);
            }
            
            try
            {
                grdVehiculos.DataSource = new Vehiculo_BO().verTodosVehiculos(vc);
                grdVehiculos.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BuscarUno()
        {

        }

        private void CargaCBTipo()
        {
            try
            {
                cmbTipo.DisplayMember = "nombretipotrans";
                cmbTipo.ValueMember = "idtipotrans";
                cmbTipo.DataSource = new Vehiculo_BO().verTipoVH();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ingresoVehiculo vehiculo = new ingresoVehiculo(0);
            vehiculo.MdiParent = this.MdiParent;
            vehiculo.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarForm(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarForm(2);
        }
        #region Navegacion
        //Para ir al primer registro:
        public static int funirPrimero(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                gridDatos.Rows[0].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[0].Cells[0];

                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }

        }
        //Para ir al último registro registro:
        public static int funirUltimo(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int max = gridDatos.Rows.Count - 2;
                gridDatos.Rows[max].Selected = true;
                gridDatos.CurrentCell = gridDatos.Rows[max].Cells[0];
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS");
                return 0;
            }
        }
        //Para ir al registro anterior
        public static int funirAnterior(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor - 1;
                if (valor >= 0)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("PRIMER REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }
        }
        // para ir al registro siguiente.
        public static int funirSiguiente(DataGridView gridDatos)
        {
            if (gridDatos.Rows.Count > 1)
            {
                int valor = gridDatos.CurrentCell.RowIndex;
                int max = gridDatos.Rows.Count - 2;
                valor = valor + 1;
                if (valor <= max)
                {
                    gridDatos.Rows[valor].Selected = true;
                    gridDatos.CurrentCell = gridDatos.Rows[valor].Cells[0];
                }
                else { MessageBox.Show("ULTIMO REGISTRO"); }
                return 0;
            }
            else
            {
                MessageBox.Show("NO HAY DATOS");
                return 0;
            }
            
        }
        #endregion

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            funirAnterior(grdVehiculos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            funirSiguiente(grdVehiculos);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            funirUltimo(grdVehiculos);
        }
    }
}
