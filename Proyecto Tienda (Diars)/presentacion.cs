using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda__Diars_
{
    public partial class presentacion : Form
    {
        public presentacion()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lo = new login();
            this.Hide();
            lo.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado lo = new Empleado();
            this.Hide();
            lo.ShowDialog();
            this.Show();
        }
    }
}
