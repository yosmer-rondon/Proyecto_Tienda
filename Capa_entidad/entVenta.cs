using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class entVenta
    {
        public int id_venta { get; set; }
        public DateTime fecha { get; set; }
        public int id_cliente { get; set; }
        public int id_empleado { get; set; }
        public Boolean estado { get; set; }

    }
}
