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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        public void listarproducto()
        {
            dgvproducto.DataSource = logProducto.Instancia.ListarProducto();
        }
        public void listartipoproducto()
        {
            dgvtipoproducto.DataSource = logTipo_producto.Instancia.ListartipoProducto();
        }
        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarproducto();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listartipoproducto();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                entTipo_producto mep = new entTipo_producto();
                mep.Nombre = txtnombretipoproducto.Text.Trim();
                mep.Descripcion = txtdescripciontipoproducto.Text.Trim();
                logTipo_producto.Instancia.Insertartipoproducto(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartipoproducto();
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                entTipo_producto c = new entTipo_producto();
                c.id_tìpo_producto = int.Parse(txtidtipoproducto.Text.Trim());
                c.Nombre = txtnombretipoproducto.Text.Trim();
                c.Descripcion = txtdescripciontipoproducto.Text.Trim();
                logTipo_producto.Instancia.EditarTipoproducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartipoproducto();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                entTipo_producto c = new entTipo_producto();

                c.id_tìpo_producto = int.Parse(txtidtipoproducto.Text.Trim());
                logTipo_producto.Instancia.Eliminartipoproducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartipoproducto();
        }
    }
}
