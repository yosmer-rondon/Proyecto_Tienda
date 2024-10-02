using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logEmpleado
    {
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get { return logEmpleado._instancia; }
        }

        public void InsertarEmpleado(entEmpleado emp)
        {
            datEmpleado.Instancia.InsertarEmpleado(emp);
        }

        public void ModificarEmpleado(entEmpleado emp)
        {
            datEmpleado.Instancia.ModificarEmpleado(emp);
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            datEmpleado.Instancia.EliminarEmpleado(idEmpleado);
        }

        public List<entEmpleado> ListarEmpleados()
        {
            return datEmpleado.Instancia.ListarEmpleados();
        }
    }
}
