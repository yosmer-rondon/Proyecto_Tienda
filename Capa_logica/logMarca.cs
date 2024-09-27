using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logMarca
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMarca _instancia = new logMarca();
        //privado para evitar la instanciación directa
        public static logMarca Instancia
        {
            get
            {
                return logMarca._instancia;
            }
        }
        public List<entMarca> Listarmarca()
        {
            return datMarca.Instancia.ListarMarca();
        }
        public void Insertarmarca(entMarca mc)
        {
            datMarca.Instancia.InsertarMarca(mc);
        }
        public void Editarmarca(entMarca mc)
        {
            datMarca.Instancia.ModificarMarca(mc);
        }
        public void Eliminarmarca(entMarca mc)
        {
            datMarca.Instancia.EliminarMarca(mc);
        }

        #endregion singleton
    }
}
