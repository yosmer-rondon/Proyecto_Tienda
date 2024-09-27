using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logTalla
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTalla _instancia = new logTalla();
        //privado para evitar la instanciación directa
        public static logTalla Instancia
        {
            get
            {
                return logTalla._instancia;
            }
        }
        public List<entTalla> listartalla()
        {
            return datTalla.Instancia.Listartalla();
        }
        public void Insertartalla(entTalla tll)
        {
            datTalla.Instancia.InsertarTalla(tll);
        }
        public void Editartalla(entTalla tll)
        {
            datTalla.Instancia.ModificarTalla(tll);
        }
        public void Eliminartalla(entTalla tll)
        {
            datTalla.Instancia.EliminarTalla(tll);
        }

        #endregion singleton

    }
}
