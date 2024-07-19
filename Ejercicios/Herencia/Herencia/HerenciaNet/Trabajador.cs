using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre, double horaPrecio) : base(nombre)
        {
            this.HoraPrecio = horaPrecio;

        }

        public double HoraPrecio { get; private set; }

        public override void TomarVacaciones()
        {
            //base.TomarVacaciones();
            DiasVacaciones += 10;
        }

        public override string ToString()
        {
            return
               $"[Trabajador.  Nombre: {Nombre} Salario: {HoraPrecio} Vacaciones: { DiasVacaciones}]";
        }
    }
}
