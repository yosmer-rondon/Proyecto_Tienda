using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logCategoria
    {
        #region sigleton
        private static readonly logCategoria _instancia = new logCategoria();
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        public List<entCategoria> Listarcategoria()
        {
            return datCategoria.Instancia.Listarcategoria();
        }
        public void Insertarcategoria(entCategoria mc)
        {
            datCategoria.Instancia.InsertarCategoria(mc);
        }
        public void Editarcategoria(entCategoria mc)
        {
            datCategoria.Instancia.ModificarCategoria(mc);
        }
        public void Eliminarcategoria(entCategoria mc)
        {
            datCategoria.Instancia.EliminarCategoria(mc);
        }
        #endregion singleton
    }
}
