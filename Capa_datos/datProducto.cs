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
                    Cli.id_producto = Convert.ToInt32(dr["id_producto"]);
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
        public Boolean InsertarProducto(entProducto producto)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@stock", producto.stock);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@nombre_tipo_producto", producto.NombreTipoProducto);
                cmd.Parameters.AddWithValue("@nombre_marca", producto.NombreMarca);
                cmd.Parameters.AddWithValue("@nombre_talla", producto.NombreTalla);
                cmd.Parameters.AddWithValue("@nombre_color", producto.NombreColor);
                cmd.Parameters.AddWithValue("@nombre_categoria", producto.NombreCategoria);

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
                cmd.Connection.Close();
            }
            return inserta;
        }

        public Boolean EditarProducto(entProducto producto)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_producto", producto.id_producto);
                cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@stock", producto.stock);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@nombre_tipo_producto", producto.NombreTipoProducto);
                cmd.Parameters.AddWithValue("@nombre_marca", producto.NombreMarca);
                cmd.Parameters.AddWithValue("@nombre_talla", producto.NombreTalla);
                cmd.Parameters.AddWithValue("@nombre_color", producto.NombreColor);
                cmd.Parameters.AddWithValue("@nombre_categoria", producto.NombreCategoria);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }

        public Boolean EliminarProducto(entProducto Producto)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_producto", Producto.id_producto);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
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
            return elimina;
        }
        /////////////////////////llenacombobox/////////////////////////
       
        public DataTable Obtenertalla()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("SELECT Talla FROM Talla", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Obtenercolor()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Color", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Obtenercategoria()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Categoria", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Obtenermarca()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Marca", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ObtenerTipoProducto()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("SELECT Nombre FROM tipo_producto", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /////////////////////////llenacombobox/////////////////////////

    }
}
