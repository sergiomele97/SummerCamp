using System;

namespace HolaMundoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio productos
            Console.WriteLine("-----------------------------------------------------------\nEjercicio productos: \n");

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


            // Ejercicio coches
            Console.WriteLine("-----------------------------------------------------------\nEjercicio coches: \n");
            Car coche1 = new Car("Green", "Ford", "Mustang", "Gasoline", "12d1d23r");
            Car coche2 = new Car("Red", "Toyota", "Prius", "Electric", "13d1113r");
            Car coche3 = new Car("Blue", "Volskwagen", "Golf", "Deisel", "113423r");

            List<Car> Car_list = new List<Car>();

            Car_list.Add(coche1);
            Car_list.Add(coche2);
            Car_list.Add(coche3);

            foreach (Car c in Car_list)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
