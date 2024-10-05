using Capa_logica;
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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvproducto.DataSource = logProducto.Instancia.ListarProducto();
            dgvproducto.Columns["NombreTipoProducto"].Visible = false;
            dgvproducto.Columns["NombreMarca"].Visible = false;
            dgvproducto.Columns["NombreTalla"].Visible = false;
            dgvproducto.Columns["NombreColor"].Visible = false;
            dgvproducto.Columns["NombreCategoria"].Visible = false;
        }
    }
}
