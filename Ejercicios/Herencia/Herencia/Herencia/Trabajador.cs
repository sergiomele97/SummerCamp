using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Trabajador : Empleado 
    {
        public Trabajador(string nombre, double horaPrecio)
        {

            this.Nombre = nombre;
            this.horaPrecio = horaPrecio;

        }


        public double horaPrecio { get; set; }

    }
}
