using Capa_entidad;
using Capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda__Diars_
{
    public partial class Empleado : Form
    {
        private List<entDetalleVenta> listaDetalles = new List<entDetalleVenta>();
        public Empleado()
        {
            InitializeComponent();
        }
        private void ActualizarDataGridView()
        {
            dbvdetalleventa.DataSource = null;
            dbvdetalleventa.DataSource = listaDetalles;
            dbvdetalleventa.Columns["id_Venta"].Visible = false;
        }

        private void CalcularTotal()
        {
            double total = listaDetalles.Sum(detalle => detalle.Subtotal);
            txttotalventa.Text = total.ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvproducto.DataSource = logProducto.Instancia.ListarProducto();
            dgvproducto.Columns["id_tipo_producto"].Visible = false;
            dgvproducto.Columns["id_marca"].Visible = false;
            dgvproducto.Columns["id_color"].Visible = false;
            dgvproducto.Columns["id_categoria"].Visible = false;
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            api apiCliente = new api();
            try
            {
                int dni = Convert.ToInt32(txtdnicliente.Text.Trim());
                if (!logCliente.Instancia.VerificarClientePorDNI(dni))
                {
                    api cli = await apiCliente.ObtenerDatosClienteAsync(txtdnicliente.Text.Trim());
                    entCliente cliente = new entCliente();
                    cliente.Nombre = cli.Nombre;
                    cliente.Apellido = $"{cli.Apellidos}";
                    cliente.DNI = dni;
                    cliente.Telefono = 0;
                    cliente.Estado = true;
                    logCliente.Instancia.InsertarCliente(cliente);
                    MessageBox.Show("Cliente agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("El cliente con el DNI especificado ya existe.");  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtdniempleado.Text.Trim());
            if (!logCliente.Instancia.VerificarClientePorDNI(dni)) {

                int idCliente = logCliente.Instancia.BuscarIdClientePorDNI(Convert.ToInt32(txtdnicliente.Text.Trim()));
                int idEmpleado = logEmpleado.Instancia.BuscarIdempleadoPorDNI(Convert.ToInt32(txtdniempleado.Text.Trim()));
                if (idCliente > 0)
                {
                    // Lógica para crear una nueva venta
                    entVenta venta = new entVenta
                    {
                        fecha = DateTime.Now,
                        id_cliente = idCliente,
                        id_empleado = idEmpleado,
                        estado = false
                    };

                    int idVenta = logVenta.Instancia.InsertarVenta(venta);
                    txtventa.Text = idVenta.ToString();
                    MessageBox.Show("Venta registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente para registrar la venta.");
                }
            }
            else { }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dgvproducto.DataSource = logProducto.Instancia.ListarProducto();
        }

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproducto.Rows[e.RowIndex];
                // Cargar los valores en los TextBox

                txtidproducto.Text = row.Cells["id_producto"].Value.ToString();
                double precio = Convert.ToDouble(row.Cells["precio"].Value.ToString());
                txtprecioproducto.Text = precio.ToString("F2");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(numcantidadproducto.Value);
            double precio = Convert.ToDouble(txtprecioproducto.Text);
            double subtotal = precio * cantidad;
            txtsubtotaldetalle.Text = subtotal.ToString("F2");
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenta = Convert.ToInt32(txtventa.Text.Trim());
                int idProducto = Convert.ToInt32(txtidproducto.Text.Trim());
                int cantidad = Convert.ToInt32(numcantidadproducto.Value);
                double precioUnitario = Convert.ToDouble(txtprecioproducto.Text.Trim());
                double subtotal = precioUnitario * cantidad;

                entDetalleVenta detalleVenta = new entDetalleVenta
                {
                    id_Venta = idVenta,
                    id_Producto = idProducto,
                    Cantidad = cantidad,
                    Preciounitario = precioUnitario,
                    Subtotal = subtotal
                };

                logDetalleVenta.Instancia.InsertarDetalleVenta(detalleVenta);
                listaDetalles.Add(detalleVenta);
                ActualizarDataGridView();
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void txtmontorecibido_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double montopagado = 0;

            // Intentar convertir los valores de total y monto pagado solo si los campos no están vacíos
            double.TryParse(txttotalventa.Text.Trim(), out total);
            double.TryParse(txtmontorecibido.Text.Trim(), out montopagado);

            // Calcular el vuelto
            double vuelto = montopagado - total;
            txtvuelto1.Text = vuelto.ToString("F2"); // 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string termino = txtbuscarproducto.Text.Trim();
            List<entProducto> productos = logProducto.Instancia.BuscarProductoConNombres(termino);
            dgvproducto.DataSource = productos;
            dgvproducto.Columns["id_tipo_producto"].Visible = false;
            dgvproducto.Columns["id_marca"].Visible = false;
            dgvproducto.Columns["id_color"].Visible = false;
            dgvproducto.Columns["id_categoria"].Visible = false;
            dgvproducto.Columns["id_talla"].Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenta = Convert.ToInt32(txtventa.Text.Trim());
                int idFormaPago = 1; // Suponiendo que tienes un ComboBox con las formas de pago

                logPago.Instancia.RegistrarPagoYActualizarVenta(idVenta, idFormaPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
