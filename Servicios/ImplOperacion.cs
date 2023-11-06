using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5Mix.Servicios
{
    /// <summary>
    /// IMPLEMENTACION para el calculo de los dias
    /// 061123 - David RA
    /// </summary>
    internal class ImplOperacion:InterfazOperacion
    {
        /// <summary>
        /// Método que calcula el número de dias que tiene un mes dependiendo del 
        /// mes y del anyo si es bisiesto o no
        /// 061123 - David Rodriguez Alonso
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        public void calculoDias(int mes, int anyo)
        {
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("\nEste mes tiene 31 dias");

            }
            else if (mes == 2)
            {
                //If para saber si el año es bisiesto o no y poner los dias correspondientes con el mes y el año
                if(anyo % 4 == 0 && anyo % 100 != 0 || anyo % 400 == 0){
                    Console.WriteLine("\nEste mes tiene 29 días");
                }
                else
                {
                    Console.WriteLine("\nEste mes tiene 28 días");
                }
                
                
            }
            else
            {
                Console.WriteLine("\nEste mes tiene 30 dias"); 
            }
        }

       
    }
}
