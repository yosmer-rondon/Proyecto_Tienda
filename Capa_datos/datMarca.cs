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
    public class datMarca
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datMarca _instancia = new datMarca();
        //privado para evitar la instanciación directa
        public static datMarca Instancia
        {
            get
            {
                return datMarca._instancia;
            }
        }
        #endregion singleton
        public List<entMarca> ListarMarca()
        {
            SqlCommand cmd = null;
            List<entMarca> lista = new List<entMarca>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("MostrarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMarca mc = new entMarca();
                    mc.id_Marca = Convert.ToInt32(dr["id_Marca"]);
                    mc.Nombre = dr["Nombre"].ToString();
                    lista.Add(mc);
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
        public Boolean Insertartipoproducto(entTipo_producto mep)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Insertartipoproducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", mep.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", mep.Descripcion);

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
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}
