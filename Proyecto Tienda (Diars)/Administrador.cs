using Capa_entidad;
using Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            txtidproducto.Enabled = false;
            cargarcargos();
        }

        public void cargarcargos() {
            try
            {
                txtcargoempleado.DataSource = logCargo.Instancia.ListarCargo();
                txtcargoempleado.DisplayMember = "Nombre";
                //txtcargoempleado.ValueMember = "id_Cargo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cargos: " + ex.Message);
            }
        }
        public void listarEmpleados()
        {
            dgvempleados.DataSource = logEmpleado.Instancia.ListarEmpleados();
        }
        public void MostrarCargos()
        {
            dgvcargo.DataSource = logCargo.Instancia.ListarCargo();
        }
        public void listarClientes()
        {
            dgvcliente.DataSource = logCliente.Instancia.Listarcliente();
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
            dgvproducto.Columns["NombreTipoProducto"].Visible = false;
            dgvproducto.Columns["NombreMarca"].Visible = false;
            dgvproducto.Columns["NombreTalla"].Visible = false;
            dgvproducto.Columns["NombreColor"].Visible = false;
            dgvproducto.Columns["NombreCategoria"].Visible = false;
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
            llenarcomboxtipoproducto();
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
            llenarcomboxmarca();
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
            llenarcomboxcolor();
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
            llenarcomboxcategoria();
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
            try
            {
                entCliente cliente = new entCliente();
                cliente.Nombre = txtnombrecliente.Text.Trim();
                cliente.Apellido = txtapellidoscliente.Text.Trim();
                cliente.DNI = Convert.ToInt32(txtdnicliente.Text.Trim());
                cliente.Telefono = Convert.ToInt32(txttelefonocliente.Text.Trim());
                cliente.Estado = cbtestadocliente.Checked;
                logCliente.Instancia.InsertarCliente(cliente);
                //MessageBox.Show("Cliente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarClientes(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.id_Cliente = int.Parse(txtidcliente.Text.Trim());
                c.Nombre = txtnombrecliente.Text.Trim();
                c.Apellido = txtapellidoscliente.Text.Trim();
                c.DNI = Convert.ToInt32(txtdnicliente.Text);
                c.Telefono = Convert.ToInt32(txttelefonocliente.Text);
                c.Estado = Convert.ToBoolean(cbtestadocliente.Checked);
                logCliente.Instancia.EditarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarClientes();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listarClientes();
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

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproducto.Rows[e.RowIndex];

                // Obtener los IDs de la fila
                int id_tipo_producto = Convert.ToInt32(row.Cells["id_tipo_producto"].Value);
                int id_marca = Convert.ToInt32(row.Cells["id_marca"].Value);
                int id_talla = Convert.ToInt32(row.Cells["id_talla"].Value);
                int id_color = Convert.ToInt32(row.Cells["id_color"].Value);
                int id_categoria = Convert.ToInt32(row.Cells["id_categoria"].Value);

                // Cargar los valores en los TextBox
                txtidproducto.Text = row.Cells["id_producto"].Value.ToString();
                txtnombreproducto.Text = row.Cells["nombre"].Value.ToString();
                txtstockproducto.Text = row.Cells["stock"].Value.ToString();
                txtprecioproducto.Text = row.Cells["precio"].Value.ToString();

                // Buscar los nombres de los ComboBox
                cbtipoproducto.Text = logProducto.Instancia.ObtenerNombreTipoProducto(id_tipo_producto);
                cbmarca.Text = logProducto.Instancia.ObtenerNombreMarca(id_marca);
                cbtalla.Text = logProducto.Instancia.ObtenerNombreTalla(id_talla);
                cbcolor.Text = logProducto.Instancia.ObtenerNombreColor(id_color);
                cbcategoria.Text = logProducto.Instancia.ObtenerNombreCategoria(id_categoria);
            }
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();

                c.id_producto = int.Parse(txtidproducto.Text.Trim());
                logProducto.Instancia.Eliminarproducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            listarproducto();
        }

        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                    logCliente.Instancia.EliminarCliente(Convert.ToInt32(txtidcliente.Text));
                    MessageBox.Show("Cliente eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarClientes(); // Actualiza la tabla después de eliminar
        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcliente.Rows[e.RowIndex];
                // Cargar los valores en los TextBox
                txtidcliente.Text = row.Cells["id_Cliente"].Value.ToString();
                txtnombrecliente.Text = row.Cells["Nombre"].Value.ToString();
                txtapellidoscliente.Text = row.Cells["Apellido"].Value.ToString();
                txtdnicliente.Text = row.Cells["Dni"].Value.ToString();
                txttelefonocliente.Text = row.Cells["Telefono"].Value.ToString();
                txtcorreocliente.Text = row.Cells["Estado"].Value.ToString();
                cbtestadocliente.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
            }
        }

        private void btnagregarcargo_Click(object sender, EventArgs e)
        {
            try
            {
                entCargo cargo = new entCargo();
                cargo.Nombre = txtnombrecargo.Text.Trim();
                logCargo.Instancia.InsertarCargo(cargo);
                MostrarCargos();
                cargarcargos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btneliminarcargo_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Cargo = Convert.ToInt32(txtidcargo.Text.Trim());
                logCargo.Instancia.EliminarCargo(id_Cargo);
                MessageBox.Show("Cargo eliminado correctamente");
                MostrarCargos();
                cargarcargos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnmodificarcargo_Click(object sender, EventArgs e)
        {
            try
            {
                entCargo cargo = new entCargo();
                cargo.id_Cargo = Convert.ToInt32(txtidcargo.Text.Trim());
                cargo.Nombre = txtnombrecargo.Text.Trim();
                logCargo.Instancia.ModificarCargo(cargo);
                MessageBox.Show("Cargo modificado correctamente");
                MostrarCargos();
                cargarcargos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnmostrarcargo_Click(object sender, EventArgs e)
        {
            MostrarCargos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado emp = new entEmpleado();
                emp.Nombre = txtnombreempleado.Text.Trim();
                emp.Apellidos = txtapellidoempleado.Text.Trim();
                emp.DNI = Convert.ToInt32(txtdniempleado.Text.Trim());
                emp.Telefono = Convert.ToInt32(txttelefonoempleado.Text.Trim());
                emp.Correo = txtcorreoempleado.Text.Trim();
                emp.NombreCargo = txtcargoempleado.SelectedItem.ToString();
                emp.Estado = cbestadoempleado.Checked;

                logEmpleado.Instancia.InsertarEmpleado(emp);
                listarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }
        }

        private void btnmostrarempleado_Click(object sender, EventArgs e)
        {
            listarEmpleados();
        }

        private void btnmodifiarempleado_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado emp = new entEmpleado();
                emp.ID_Empleado = Convert.ToInt32(txtidempleado.Text.Trim());
                emp.Nombre = txtnombreempleado.Text.Trim();
                emp.Apellidos = txtapellidoempleado.Text.Trim();
                emp.DNI = Convert.ToInt32(txtdniempleado.Text.Trim());
                emp.Telefono = Convert.ToInt32(txttelefonoempleado.Text.Trim());
                emp.Correo = txtcorreoempleado.Text.Trim();
                emp.NombreCargo = txtcargoempleado.SelectedItem.ToString();
                emp.Estado = cbestadoempleado.Checked;

                logEmpleado.Instancia.ModificarEmpleado(emp);
                listarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el empleado: " + ex.Message);
            }
        }

        private void btneliminarempleado_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(txtidempleado.Text.Trim());
                logEmpleado.Instancia.EliminarEmpleado(idEmpleado);
                listarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
        }
    }
}
