using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logCliente
    {
            #region sigleton
            //Patron Singleton
            // Variable estática para la instancia
            private static readonly logCliente _instancia = new logCliente();
            //privado para evitar la instanciación directa
            public static logCliente Instancia
            {
                get
                {
                    return logCliente._instancia;
                }
            }
        #endregion singleton
        public List<entCliente> Listarcliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public void InsertarCliente(entCliente mc)
        {
            datCliente.Instancia.InsertarCliente(mc);
        }
        public void EditarCliente(entCliente mc)
        {
            datCliente.Instancia.ModificarCliente(mc);
        }
        public void EliminarCliente(int mc)
        {
            datCliente.Instancia.EliminarCliente(mc);

        }
    }

}
