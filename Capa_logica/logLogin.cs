using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class logLogin
    {
        #region singleton
        private static readonly logLogin _instancia = new logLogin();
        public static logLogin Instancia
        {
            get { return logLogin._instancia; }
        }
        #endregion singleton

        public bool VerificarLogin(string dni, string contraseña)
        {
            return datLogin.Instancia.VerificarLogin(dni, contraseña);
        }
    }
}
