using System;

namespace HolaMundoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Producto Producto_A = new Producto("Producto_A", 100);
            Producto Producto_B = new Producto("Producto_B", 200);
            Producto Producto_C = new Producto("Producto_C", 300);

            List<Producto> Producto_List = new List<Producto>();

            Producto_List.Add(Producto_A);
            Producto_List.Add(Producto_B);
            Producto_List.Add(Producto_C);

            int total_ventas = 0;

            foreach (Producto p in Producto_List)
            {
                Console.WriteLine(p.nombre);
                total_ventas = total_ventas + p.ventas;
            }
            Console.WriteLine("El total de ventas es: " + total_ventas);
        }
    }
}
