using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM
{
    public partial class mostrarLogin : Form
    {
        public mostrarLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            mostrarMenu Menu = new mostrarMenu();
            Menu.Show();
        }
    }
}
