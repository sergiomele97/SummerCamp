using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoProyecto
{
    internal class Producto
    {
        public string nombre = "";
        public int ventas = 0;

        public Producto(string nombre, int ventas) { 
            
            this.nombre = nombre;
            this.ventas = ventas;
        }
    }
}
