using System;

namespace FuncionesLambdaEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            Func<int, int, int> operacionSuma = (x, y) => x + y;
            Func<int, int, int> operacionResta = (x, y) => x - y;
            Func<int, int, int> operacionMultiplicacion = (x, y) => x * y;
            Func<int, int, int> operacionDivision = (x, y) => x / y;

            List<Func<int, int, int>> ListaOperaciones = new List<Func<int, int, int>> { };
            ListaOperaciones.Add(operacionSuma);
            ListaOperaciones.Add(operacionResta);
            ListaOperaciones.Add(operacionMultiplicacion);
            ListaOperaciones.Add(operacionDivision);

            foreach (Func<int, int, int> operacion in ListaOperaciones) 
            {
                Console.WriteLine(operacion(x, y));
            }
        }
    }
}
