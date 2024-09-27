using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logColor
    {
        #region sigleton
        private static readonly logColor _instancia = new logColor();
        public static logColor Instancia
        {
            get
            {
                return logColor._instancia;
            }
        }
        public List<entColor> Listarcolor()
        {
            return datColor.Instancia.ListarColor();
        }
        public void Insertarcolor(entColor mc)
        {
            datColor.Instancia.InsertarColor(mc);
        }
        public void Editarcolor(entColor mc)
        {
            datColor.Instancia.ModificarColor(mc);
        }
        public void EliminarColor(entColor mc)
        {
            datColor.Instancia.EliminarColor(mc);
        }
        #endregion singleton
    }
}
