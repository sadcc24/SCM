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
    public partial class ingresoFacturaProveedor : Form
    {
        public ingresoFacturaProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarOCInventario bocin = new buscarOCInventario();
            bocin.Show();
        }
    }
}
