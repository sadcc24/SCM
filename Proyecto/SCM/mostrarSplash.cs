using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllSeguridadSAD;
using DAL;

namespace SCM
{
    public partial class mostarSplash : Form
    {
        public mostarSplash()
        {
            InitializeComponent();
            pbrBarra.Style = ProgressBarStyle.Continuous;
            pbrBarra.Maximum = 100;
            pbrBarra.Value = 0;
            Globales.Usuario.RegistrarBitácora(Globales.Conexion, "Bitacora", "Aplicación ejecutada");
            tmrReloj.Enabled = true;
        }
        public void incrementarBarra()
        {
            pbrBarra.Increment(3);
            pbrBarra.ForeColor = Color.Crimson;            
            lblPorcentaje.Text = pbrBarra.Value.ToString() + "%";
            if (pbrBarra.Value == pbrBarra.Maximum)
            {
                tmrReloj.Stop();
                this.Hide();                
                
                mostrarLogin temp = new mostrarLogin();
                temp.Show();              
            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            incrementarBarra();
        }
    }
}
