using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class datDetalleVenta
    {
        // Singleton
        public static readonly datDetalleVenta _instancia = new datDetalleVenta();
        public static datDetalleVenta Instancia
        {
            get
            {
                return datDetalleVenta._instancia;
            }
        }

        public bool InsertarDetalleVenta(entDetalleVenta detalle)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarDetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Venta", detalle.id_Venta);
                cmd.Parameters.AddWithValue("@id_Producto", detalle.id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Preciounitario", detalle.Preciounitario);
                cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                    cmd.Connection.Close();
            }
            return inserta;
        }
    }
}
