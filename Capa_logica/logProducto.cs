using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        public void Insertarproducto(entProducto mc)
        {
            datProducto.Instancia.InsertarProducto(mc);
        }
        public void Editarproducto(entProducto mc)
        {
            datProducto.Instancia.EditarProducto(mc);
        }
        public void Eliminarproducto(entProducto mc)
        {
            datProducto.Instancia.EliminarProducto(mc);
            
        }
        ///////////////////llenarcombobox
        public DataTable LlenarCombotalla()
        {
            return datProducto.Instancia.Obtenertalla();
        }

        public DataTable LlenarCombocolor()
        {
            return datProducto.Instancia.Obtenercolor();
        }
        public DataTable LlenarCombocategoria()
        {
            return datProducto.Instancia.Obtenercategoria();
        }
        public DataTable LlenarCombomarca()
        {
            return datProducto.Instancia.Obtenermarca();
        }

        public DataTable LlenarComboTipoProducto()
        {
            return datProducto.Instancia.ObtenerTipoProducto();
        }
        ///////////////////llenarcombobox
    }
}
