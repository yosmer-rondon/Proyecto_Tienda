using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logTipo_producto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipo_producto _instancia = new logTipo_producto();
        //privado para evitar la instanciación directa
        public static logTipo_producto Instancia
        {
            get
            {
                return logTipo_producto._instancia;
            }
        }
        public List<entTipo_producto> ListartipoProducto()
        {
            return datTipo_producto.Instancia.ListartipoProducto();
        }
        public void Insertartipoproducto(entTipo_producto tip)
        {
            datTipo_producto.Instancia.Insertartipoproducto(tip);
        }
        public void EditarTipoproducto(entTipo_producto Cli)
        {
            datTipo_producto.Instancia.Editartipoproducto(Cli);
        }
        public void Eliminartipoproducto(entTipo_producto Cli)
        {
            datTipo_producto.Instancia.Eliminartipoproducto(Cli);
        }

        #endregion singleton
    }
}
