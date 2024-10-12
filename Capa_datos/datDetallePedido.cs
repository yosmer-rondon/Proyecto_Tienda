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
    public class datDetallePedido
    {
        public static readonly datDetallePedido _instancia = new datDetallePedido();
        public static datDetallePedido Instancia
        {
            get
            {
                return datDetallePedido._instancia;
            }
        }

        public void InsertarDetallePedido(entDetallePedido detallePedido)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Pedido", detallePedido.IdPedido);
                cmd.Parameters.AddWithValue("@Id_Producto", detallePedido.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", detallePedido.SubTotal);

                cn.Open();
                cmd.ExecuteNonQuery();
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
        }
    }
}
