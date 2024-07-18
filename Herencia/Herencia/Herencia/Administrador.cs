using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, Boolean tieneCocheEmpresa)
        {
            this.Nombre = nombre;
            this.TieneCocheEmpresa = tieneCocheEmpresa;
        }

        public bool TieneCocheEmpresa { get;  set; }
    }
}


