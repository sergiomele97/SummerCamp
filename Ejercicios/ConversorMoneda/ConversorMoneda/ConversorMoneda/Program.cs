using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConversorMoneda
{
    internal class Program
    {
        /*Crea un programa que permita convertir entre Euros, Dolares y Libras.
         * Debe pedir la moneda origen, la moneda destino y el importe y mostrar 
         * por pantalla la conversión.
         */
        static void Main(string[] args)
        {
            Dictionary<string, double> conversiones = new Dictionary<string, double>();
            conversiones["Euros"] = 1;
            conversiones["Dolares"] = 1.07;
            conversiones["Libras"] = 0.84;

            List<string> valoresAceptables = new List<string> { "Euros", "Dolares", "Libras" };
            
            printIntro();
            Console.WriteLine("\nIntroduzca moneda de origen:");
            string monedaOrigen = Console.ReadLine();  

            while (!valoresAceptables.Contains(monedaOrigen))
            {
                printIntro();
                Console.WriteLine("\nEl valor introducido de moneda de origen no es aceptable, por favor ingrese uno nuevo:");
                monedaOrigen = Console.ReadLine();
            }

            Console.Clear();
            printIntro();
            Console.WriteLine("\nIntroduzca moneda de destino:");
            string monedaDestino = Console.ReadLine();

            while (!valoresAceptables.Contains(monedaDestino))
            {
                printIntro();
                Console.WriteLine("\nEl valor introducido de moneda de destino no es aceptable, por favor ingrese uno nuevo:");
                monedaDestino = Console.ReadLine();
            }

            Console.Clear();
            Console.Write("Por favor, ingresa un importe válido: ");
            double importe;

            while (!double.TryParse(Console.ReadLine(), out importe))
            {
                Console.Clear();
                Console.Write("Por favor, ingresa un importe válido: ");
            }

            Console.Clear();
            Console.WriteLine($"\nEl resultado de convertir {monedaOrigen} a {monedaDestino} es: " + convertCurrency(monedaOrigen, monedaDestino, importe));

        double convertCurrency(string ori, string dest, double value)
            {

                return value * conversiones[dest] / conversiones[ori];
            }


            
        }

        static void printIntro()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Convertor de monedas \n\nMonedas compatibles: Euros, Dolares y Libras");
        }
    }
}
