﻿using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class datTipo_producto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datTipo_producto _instancia = new datTipo_producto();
        //privado para evitar la instanciación directa
        public static datTipo_producto Instancia
        {
            get
            {
                return datTipo_producto._instancia;
            }
        }
        #endregion singleton
        public List<entTipo_producto> ListartipoProducto()
        {
            SqlCommand cmd = null;
            List<entTipo_producto> lista = new List<entTipo_producto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("MostrarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipo_producto tip = new entTipo_producto();
                    tip.id_tìpo_producto = Convert.ToInt32(dr["id_tipo_producto"]);
                    tip.Nombre = dr["Nombre"].ToString();
                    tip.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(tip);
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
