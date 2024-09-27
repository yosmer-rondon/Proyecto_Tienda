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
        public void listarmarca()
        {
            dgvmarca.DataSource = logMarca.Instancia.Listarmarca();
        }
        public void listartalla()
        {
            dgvtalla.DataSource = logTalla.Instancia.listartalla();
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
            try
            {
                entMarca c = new entMarca();
                c.id_Marca = int.Parse(txtidtipoproducto.Text.Trim());
                c.Nombre = txtnombretipoproducto.Text.Trim();
                logMarca.Instancia.Editarmarca(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartipoproducto();
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

        private void btnagregarmarca_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca mep = new entMarca();
                mep.Nombre = txtNombre_marca.Text.Trim();
                logMarca.Instancia.Insertarmarca(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarmarca();
        }

        private void btnmostrarmarca_Click(object sender, EventArgs e)
        {
            listarmarca();
        }

        private void btneliminarmarca_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca c = new entMarca();

                c.id_Marca = int.Parse(txtid_Marca.Text.Trim());
                logMarca.Instancia.Eliminarmarca(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarmarca();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                entTalla mep = new entTalla();
                mep.Talla = txtnombretalla.Text.Trim();
                logTalla.Instancia.Insertartalla(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartalla();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            listartalla();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entTalla c = new entTalla();

                c.id_Talla = int.Parse(txtid_talla.Text.Trim());
                logTalla.Instancia.Eliminartalla(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartalla();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTalla c = new entTalla();
                c.id_Talla = int.Parse(txtid_talla.Text.Trim());
                c.Talla = txtnombretalla.Text.Trim();
                logTalla.Instancia.Editartalla(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartalla();
        }
    }
}
