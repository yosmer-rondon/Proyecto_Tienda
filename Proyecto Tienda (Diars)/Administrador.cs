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
            llenarcomboxtalla();
            llenarcomboxcolor();
            llenarcomboxcategoria();
            llenarcomboxmarca();
            llenarcomboxtipoproducto();
        }
        public void llenarcomboxtalla()
        {
            cbtalla.DataSource = logProducto.Instancia.LlenarCombotalla();
            cbtalla.DisplayMember = "Talla";
        }
        public void llenarcomboxcolor()
        {
            cbcolor.DataSource = logProducto.Instancia.LlenarCombocolor();
            cbcolor.DisplayMember = "Nombre";
        }
        public void llenarcomboxcategoria()
        {
            cbcategoria.DataSource = logProducto.Instancia.LlenarCombocategoria();
            cbcategoria.DisplayMember = "Nombre";
        }
        public void llenarcomboxmarca()
        {
            cbmarca.DataSource = logProducto.Instancia.LlenarCombomarca();
            cbmarca.DisplayMember = "Nombre";
        }
        public void llenarcomboxtipoproducto()
        {
            cbtipoproducto.DataSource = logProducto.Instancia.LlenarComboTipoProducto();
            cbtipoproducto.DisplayMember = "Nombre";
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
            dgvtalla.DataSource = logTalla.Instancia.Listartalla();
        }
        public void listarcolor()
        {
            dgvcolor.DataSource = logColor.Instancia.Listarcolor();
        }
        public void listarcategoria()
        {
            dgvcategoria.DataSource = logCategoria.Instancia.Listarcategoria();
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

        private void agregarcolor_Click(object sender, EventArgs e)
        {
            try
            {
                entColor mep = new entColor();
                mep.Nombre = txtnombrecolor.Text.Trim();
                logColor.Instancia.Insertarcolor(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarcolor();
        }

        private void mostrarcolor_Click(object sender, EventArgs e)
        {
            listarcolor();
        }

        private void eliminarcolor_Click(object sender, EventArgs e)
        {
            
                try
                {
                    entColor c = new entColor();

                    c.id_Color = int.Parse(txtidcolor.Text.Trim());
                    logColor.Instancia.EliminarColor(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                //LimpiarVariables();
                listarcolor();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                entTalla c = new entTalla();
                c.id_Talla = int.Parse(txtidtalla.Text.Trim());
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

        private void modificarcolor_Click(object sender, EventArgs e)
        {
            try
            {
                entColor c = new entColor();
                c.id_Color = int.Parse(txtidcolor.Text.Trim());
                c.Nombre = txtnombrecolor.Text.Trim();
                logColor.Instancia.Editarcolor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarcolor();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listartalla();
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
            llenarcomboxtalla();
        }

        private void eliminartalla_Click(object sender, EventArgs e)
        {
            try
            {
                entTalla c = new entTalla();

                c.id_Talla = int.Parse(txtidtalla.Text.Trim());
                logTalla.Instancia.Eliminartalla(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listartalla();
        }

        private void mostrarcategoria_Click(object sender, EventArgs e)
        {
            listarcategoria();
        }

        private void agregarcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria mep = new entCategoria();
                mep.Nombre = txtnombrecategoria.Text.Trim();
                logCategoria.Instancia.Insertarcategoria(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarcategoria();
        }

        private void eliminarcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();

                c.id_Categoria = int.Parse(txtidcategoria.Text.Trim());
                logCategoria.Instancia.Eliminarcategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarcategoria();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void modificarcategoria_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.id_Categoria = int.Parse(txtidcategoria.Text.Trim());
                c.Nombre = txtnombrecategoria.Text.Trim();
                logCategoria.Instancia.Editarcategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarcategoria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto mep = new entProducto();
                mep.nombre = txtnombreproducto.Text.Trim();
                mep.stock = Convert.ToInt32(txtstockproducto.Text.Trim());
                mep.precio = Convert.ToDouble(txtprecioproducto.Text.Trim());
                mep.NombreTipoProducto = cbtipoproducto.Text.Trim();
                mep.NombreMarca = cbmarca.Text.Trim();
                mep.NombreTalla = cbtalla.Text.Trim();
                mep.NombreColor = cbcolor.Text.Trim();
                mep.NombreCategoria = cbcategoria.Text.Trim();
                logProducto.Instancia.Insertarproducto(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarproducto();
        }
    }
}
