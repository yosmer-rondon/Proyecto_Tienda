using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logDetallePedido
    {
        public static readonly logDetallePedido _instancia = new logDetallePedido();
        public static logDetallePedido Instancia
        {
            get
            {
                return logDetallePedido._instancia;
            }
        }

        public void InsertarDetallePedido(entDetallePedido detallePedido)
        {
            datDetallePedido.Instancia.InsertarDetallePedido(detallePedido);
        }
    }
}
