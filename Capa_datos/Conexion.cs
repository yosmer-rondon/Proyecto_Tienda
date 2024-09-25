using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class Conexion
    {
        public string ser = "servidorproyectotienda.database.windows.net";
        public string bd = "bdtiendap";
        public string sa = "yhmaster";
        public string contraseña = "(Loco123)";

        // Patrón de diseño Singleton
        private static readonly Conexion _instancia = new Conexion();

        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        // Método para conectar a la base de datos
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=" + ser + "; Initial Catalog=" + bd + ";" +
                                  "User ID=" + sa + "; Password=" + contraseña + ";";

            return cn;
        }
    }
}
