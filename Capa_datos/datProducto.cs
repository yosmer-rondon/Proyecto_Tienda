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
    public class datProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("MostrarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Cli = new entProducto();
                    Cli.id_producto = Convert.ToInt32(dr["id"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.stock = Convert.ToInt32(dr["stock"]);
                    Cli.precio = Convert.ToDouble(dr["precio"]);
                    Cli.id_tipo_producto = Convert.ToInt32(dr["id_tipo_producto"]);
                    Cli.id_marca = Convert.ToInt32(dr["id_marca"]);
                    Cli.id_talla = Convert.ToInt32(dr["id_talla"]);
                    Cli.id_color = Convert.ToInt32(dr["id_color"]);
                    Cli.id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
