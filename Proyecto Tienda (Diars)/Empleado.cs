using Capa_entidad;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdniempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Producto producto in productos)
            {
                entProducto pro = new entProducto();
                Button btnProducto = new Button();
                btnProducto.Text = $"{producto.Nombre}\nS/ {producto.Precio}\nStock: {producto.Stock}";
                btnProducto.Tag = producto;
                btnProducto.Click += BtnProducto_Click;

                flowLayoutPanelProductos.Controls.Add(btnProducto);
            }
        }
    }
}
