using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logDetalleVenta
    {
        // Singleton
        private static readonly logDetalleVenta _instancia = new logDetalleVenta();
        public static logDetalleVenta Instancia
        {
            get
            {
                return logDetalleVenta._instancia;
            }
        }

        public bool InsertarDetalleVenta(entDetalleVenta detalle)
        {
            return datDetalleVenta.Instancia.InsertarDetalleVenta(detalle);
        }
    }
}
