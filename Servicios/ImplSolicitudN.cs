using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5Mix.Servicios
{
    /// <summary>
    /// IMPLEMENTACION para la solicitud de los numeros de mes y año
    /// 061123 - David RA
    /// </summary>
    internal class ImplSolicitudN:InterfazSolicitudN
    {
        /// <summary>
        /// Método que pide numeros para el mes y el año 
        /// 061123 - David RA
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int solicitudMesAnyo(int k)
        {
            int numero;
            char respuesta;

            

                if (k == 0)
                {

                    do
                    {
                        Console.WriteLine("Introduzca un mes del año en número entero: ");

                    } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 12);

                }
                else
                {
                    do
                    {
                        Console.WriteLine("Introduzca un año: ");

                    } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1);

                    
                }
                
            

            return numero;
            
        }

        
    }

    

}
