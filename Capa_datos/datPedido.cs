using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidad;

namespace Capa_datos
{
    public class datPedido
    {
        public static readonly datPedido _instancia = new datPedido();
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }

        public int InsertarPedido(entPedido pedido)
        {
            SqlCommand cmd = null;
            int idPedido = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", pedido.IdCliente);
                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                cmd.Parameters.AddWithValue("@FechaEnvio", pedido.FechaEnvio);
                cmd.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
                cmd.Parameters.AddWithValue("@Estado", pedido.Estado);
                cmd.Parameters.AddWithValue("@Direccion", pedido.Direccion);
                cmd.Parameters.AddWithValue("@Ciudad", pedido.Ciudad);
                cmd.Parameters.AddWithValue("@NumeroSeguimiento", pedido.NumeroSeguimiento);

                SqlParameter outputIdParam = new SqlParameter();
                outputIdParam.ParameterName = "@ID_Pedido";
                outputIdParam.SqlDbType = SqlDbType.Int;
                outputIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputIdParam);

                cn.Open();
                cmd.ExecuteNonQuery();

                idPedido = Convert.ToInt32(outputIdParam.Value);
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
            return idPedido;
        }
    }
}
