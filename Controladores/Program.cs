/*.
Escribe un programa que solicite un mes en número y un año de forma repetida. A partir de estos datos, el 
programa mostrará por consola el número de días que tiene ese mes.
Se definirán un mínimo de dos servicios, uno que contenga los metodos referentes a la petición del mes y año 
por consola; y otro que se encargue de la operativa de la aplicación.
Tras indicar el número de días, se deberá preguntar si se quiere hacer otra consula de mes y año. Si la 
respuesta es 's' se continuará la ejecución volviendo a solicitar los datos necesarios. En caso contrario se
cerrará la aplicación.
Observación: Un año bisiesto es divisible por cuatro, excepto cuando es divisible por 100, que entonces será
necesario que sea divisible por 400. Ejemplo: 1900 no fue bisiesto, pero 2000 si lo es.
*/

using Ejerc5Mix.Servicios;

namespace Ejerc5Mix.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 061123 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Creación de dos objetos para hacer copias de las clases y usarlas en el main
            InterfazSolicitudN ni=new ImplSolicitudN();
            InterfazOperacion mi=new ImplOperacion();

            char respuesta;

            
            do
            {
                Console.Clear();
                //Declaración e inicialización de dos variables para guardar el valor introducido por el usuario llamando al método de la clase
                int mes = ni.solicitudMesAnyo(0);
                int anyo = ni.solicitudMesAnyo(1);

                //Llamada al método de calculo de dias 
                mi.calculoDias(mes, anyo);

                //Preguntamos si el usuario quiere seguir preguntando o quiere salir del programa
                Console.Write("\n¿Quiere hacer otra consulta sobre el mes y el año (s/n)?\t");
                respuesta = Convert.ToChar(Console.ReadLine());

            } while (respuesta == 's' || respuesta == 'S');
            //Controlamos con el do si el usuario quiere continuar o salir del programa con la variable respuesta

            Console.WriteLine("\n\nGracias por usar nuestro programa\n\n");
        }

    }

}
