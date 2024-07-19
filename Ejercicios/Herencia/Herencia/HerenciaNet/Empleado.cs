using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado
    {

        public string Nombre { get; set; }

        public double DiasVacaciones { get; set; }


        public Empleado(string nombre)
        {
            Nombre = nombre;
        }
        public Empleado()
        {

        }

        public virtual void TomarVacaciones() {

            //this.DiasVacaciones = 30;

        }

        public override string ToString()
        {
            return $"[Empleado: Nombre = {Nombre}]";
        }





    }
}
