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
        private List<entDetallePedido> listaDetalleP = new List<entDetallePedido>();
        public Empleado()
        {
            InitializeComponent();
            txtventa.Enabled = false;
            txtpedido.Enabled = false;
            txtidproducto.Enabled = false;
            txtprecioproducto.Enabled = false;
            txtsubtotaldetalle.Enabled = false;
            txttotalventa.Enabled = false;


        }
        private void Actualizardetalle()
        {
            dbvdetalleventa.DataSource = null;
            dbvdetalleventa.DataSource = listaDetalles;
            dbvdetalleventa.Columns["id_Venta"].Visible = false;
        }
        private void Actualizardetallepedido()
        {
            dgvdetallep.DataSource = null;
            dgvdetallep.DataSource = listaDetalleP;
            dgvdetallep.Columns["IdPedido"].Visible = true;
        }
        private async void verificarcliente(int dnia)
        {
            api apiCliente = new api();
            try
            {
                int dni = dnia;
                if (!logCliente.Instancia.VerificarClientePorDNI(dni))
                {
                    api cli = await apiCliente.ObtenerDatosClienteAsync(Convert.ToString(dni));
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

        private void CalcularTotal()
        {
            double total = listaDetalles.Sum(detalle => detalle.Subtotal);
            txttotalventa.Text = total.ToString("F2");
        }
        private void CalcularTotalP()
        {
            double total = listaDetalleP.Sum(detalle => detalle.SubTotal);
            txttotalpagarp.Text = total.ToString("F2");
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
            verificarcliente(Convert.ToInt32(txtdnicliente.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtdniempleado.Text.Trim());
            if (!logEmpleado.Instancia.VerificarEmpleadoPorDNI(dni)) {
                MessageBox.Show("Empleado no existe");
                txtdniempleado.Text = "";
            }
            else
            {

                int idCliente = logCliente.Instancia.BuscarIdClientePorDNI(Convert.ToInt32(txtdnicliente.Text.Trim()));
                int idEmpleado = logEmpleado.Instancia.BuscarIdempleadoPorDNI(Convert.ToInt32(txtdniempleado.Text.Trim()));
                if (idCliente > 0)
                {
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
                txtdnicliente.Text = "";
            }
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
                Actualizardetalle();
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
            double.TryParse(txttotalventa.Text.Trim(), out total);
            double.TryParse(txtmontorecibido.Text.Trim(), out montopagado);
            double vuelto = montopagado - total;
            txtvuelto1.Text = vuelto.ToString("F2");
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
                int idFormaPago = 1;
                logPago.Instancia.RegistrarPagoYActualizarVenta(idVenta, idFormaPago);
                txtventa.Text = "";
                txtidproducto.Text = "";
                txtprecioproducto.Text = "";
                txtsubtotaldetalle.Text = "";
                txttotalventa.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnAgregarproducto_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Color borderColor = Color.Turquoise;
                int borderWidth = 3;
                ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Color borderColor = Color.Turquoise;
                int borderWidth = 3;
                ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            verificarcliente(Convert.ToInt32(txtdniclientep.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string termino = txtbuscarproductop.Text.Trim();
            List<entProducto> productos = logProducto.Instancia.BuscarProductoConNombres(termino);
            dgvproductosp.DataSource = productos;
            dgvproductosp.Columns["id_tipo_producto"].Visible = false;
            dgvproductosp.Columns["id_marca"].Visible = false;
            dgvproductosp.Columns["id_color"].Visible = false;
            dgvproductosp.Columns["id_categoria"].Visible = false;
            dgvproductosp.Columns["id_talla"].Visible = false;
        }

        private void Pago_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void btnagregarorpedido_Click(object sender, EventArgs e)
        {
            int idCliente = logCliente.Instancia.BuscarIdClientePorDNI(Convert.ToInt32(txtdniclientep.Text.Trim()));
            if (!logCliente.Instancia.VerificarClientePorDNI(idCliente))
            {
                MessageBox.Show("CLIENTE NO EXISTE PRESIONE VERIFICAR Y SE AGREGARA AUTOMATICAMENTE");
            }
            else {
                entPedido pedido = new entPedido
                {
                    IdCliente = idCliente,
                    Fecha = DateTime.Now,
                    FechaEnvio = DateTime.Now.AddDays(2),
                    FechaEntrega = DateTime.Now.AddDays(5),
                    Estado = false,
                    Direccion = txtdireccionp.Text,
                    Ciudad = txtciudadp.Text,
                    NumeroSeguimiento = txtnumeroseguimiento.Text,
                };

                int idpedido = logPedido.Instancia.InsertarPedido(pedido);
                txtpedido.Text = idpedido.ToString();
                MessageBox.Show("Orden de pedido registrada correctamente.");

            }
        }

        private void btnmostrarproductosp_Click(object sender, EventArgs e)
        {
            dgvproductosp.DataSource = logProducto.Instancia.ListarProducto();
        }

        private void dgvdetallep_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproductosp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproductosp.Rows[e.RowIndex];
                txtidproductop.Text = row.Cells["id_producto"].Value.ToString();
                double precio = Convert.ToDouble(row.Cells["precio"].Value.ToString());
                txtprecioproductop.Text = precio.ToString("F2");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double montopagado = 0;
            double.TryParse(txttotalpagarp.Text.Trim(), out total);
            double.TryParse(txtmontorecibidop.Text.Trim(), out montopagado);
            double vuelto = montopagado - total;
            txtvueltop.Text = vuelto.ToString("F2");
        }

        private void numproductop_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(numproductop.Value);
            double precio = Convert.ToDouble(txtprecioproductop.Text);
            double subtotal = precio * cantidad;
            txtsubtotalp.Text = subtotal.ToString("F2");
        }

        private void btnagregarproductop_Click(object sender, EventArgs e)
        {
            try
            {
                int idpedido = Convert.ToInt32(txtpedido.Text.Trim());
                int idProducto = Convert.ToInt32(txtidproductop.Text.Trim());
                int cantidad = Convert.ToInt32(numproductop.Value);
                double precioUnitario = Convert.ToDouble(txtprecioproductop.Text.Trim());
                double subtotal = precioUnitario * cantidad;

                entDetallePedido detalle = new entDetallePedido
                {
                    IdPedido = idpedido,
                    IdProducto = idProducto,
                    Cantidad = cantidad,
                    SubTotal = subtotal
                };

                logDetallePedido.Instancia.InsertarDetallePedido(detalle);
                listaDetalleP.Add(detalle);
                Actualizardetallepedido();
                CalcularTotalP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}

