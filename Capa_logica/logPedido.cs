using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logPedido
    {
        public static readonly logPedido _instancia = new logPedido();
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }

        public int InsertarPedido(entPedido pedido)
        {
            return datPedido.Instancia.InsertarPedido(pedido);
        }
    }
}
