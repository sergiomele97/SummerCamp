using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un trabajador llamado Juan Carlos Maria de la Esperanza que cobre 35 a la hora
            Trabajador trabajadorJuanCarlosMariadelaEsperanza = new Trabajador("Juan Carlos María de la Esperanza", 35.0);
            trabajadorJuanCarlosMariadelaEsperanza.TomarVacaciones();
            // Crear un administrativo llamado Lidia Parral Rodriguez que tiene coche de empresa
            Administrador administradorLidia = new Administrador("Lidia Parral", true);
            administradorLidia.TomarVacaciones();


            Empleado emp1 = new Empleado("pepe");
            Empleado emp2 = new Administrador("juan", true);
            Empleado emp3 = new Trabajador("Jose", 100);

            List<Empleado> empleados = new List<Empleado>()
           {
               emp1,emp2, emp3
           };

            List<int> enteros = new List<int>();
            enteros.Add(1);

            foreach (var numero in enteros)
            {

            }

            foreach (var empleado in empleados)
            {
                empleado.TomarVacaciones();
                Console.WriteLine(empleado.DiasVacaciones);
                //if (empleado.Nombre == "juan")
                //{
                //    var administrador = (Administrador)empleado;
                //    Console.WriteLine(administrador.TieneCocheEmpresa);
                //}
                Console.WriteLine(empleado.ToString());
            }

            Console.ReadLine();


        }
    }
}
