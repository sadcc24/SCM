﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class generaDevolucionProveedor : Form
    {
        public generaDevolucionProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            buscarFacturasIngresadas bfing = new buscarFacturasIngresadas();
            bfing.Show();
        }
    }
}
