using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   class Program
   {

        // Crear tres empleados, uno de ellos es un gerente
        // y los otros dos son trabajadores
        // Llamar al método CalcularVacaciones() para cada uno de ellos // e imprimir el resultado en la consola
        // El método CalcularVacaciones() debe imprimir un mensaje
        // que indique cuantos dias tiene el empleado de vacaciones
        // y si el empleado es un gerente, debe imprimir un mensaje
        // adicional que indique si el gerente tiene plaza de parking y el numero de
        // Si el empleado es un trabajador, debe imprimir un mensaje
        // adicional que indique el turno en el que trabaja el trabajador
        // El método CalcularVacaciones() debe ser implementado en la clase base // y sobrescrito en las clases derivadas
        // El método CalcularVacaciones() debe ser llamado desde el método Main()
        // y no debe ser llamado directamente desde las clases derivadas
        // Encontrar otra forma mas optimizada para mostrar el resultado
        // en la consola (eliminar el for)
        // Crear una lista de empleados y agregar los tres empleados

        static void Main(string[] args)
      {
         Employee Paco = new Worker("Bob", 35.00, "noche");
         Employee Pepe = new Manager("Joe", true, 6);

         List<Employee> employees = new List<Employee>()
         {
            Paco,
            Pepe
         };

            foreach (Employee employee in employees)
            {

                Console.WriteLine(employee);
                employee.getVacations();
            
            }
      }
   }
}
