using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Administrador : Empleado
    {

        public Administrador(string nombre, Boolean tieneCocheEmpresa) : base(nombre)
        {
            
            this.TieneCocheEmpresa = tieneCocheEmpresa;
        }

        public bool TieneCocheEmpresa { get; set; }

        public override void TomarVacaciones()
        {
            base.TomarVacaciones();
            DiasVacaciones += 5;
        }

        public override string ToString()
        {
            return
               $"[Trabajador.  Nombre: {Nombre}  Coche Empresa {TieneCocheEmpresa}  Vacaciones: { DiasVacaciones}]";
        }
    }
}


