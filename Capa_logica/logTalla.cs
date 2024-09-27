﻿using Capa_datos;
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

        private static readonly logTalla _instancia = new logTalla();
        public static logTalla Instancia
        {
            get
            {
                return logTalla._instancia;
            }
        }
        public List<entTalla> Listartalla()
        {
            return datTalla.Instancia.Listartalla();
        }
        public void Insertartalla(entTalla mc)
        {
            datTalla.Instancia.InsertarTalla(mc);
        }
        public void Editartalla(entTalla mc)
        {
            datTalla.Instancia.ModificarTalla(mc);
        }
        public void Eliminartalla(entTalla mc)
        {
            datTalla.Instancia.EliminarTalla(mc);
        }

        #endregion singleton
    }
}
