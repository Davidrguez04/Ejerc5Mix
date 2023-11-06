using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5Mix.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del calculo
    /// Contiene el calculo de los dias
    /// </summary>
    internal interface InterfazOperacion
    {
        public void calculoDias(int mes, int anyo);
    }
}
