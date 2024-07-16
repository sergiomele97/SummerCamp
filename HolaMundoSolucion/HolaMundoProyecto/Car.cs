using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoProyecto
{
    internal class Car
    {

        public string Color {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoMotor { get; set; }

        private string matricula;

        public Car(string color, string marca, string modelo, string tipoMotor, string matricula)
        {
            Color = color;
            Marca = marca;
            Modelo = modelo;
            TipoMotor = tipoMotor;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return $"Car: Marca = {Marca}, Modelo = {Modelo}, Color = {Color}, TipoMotor = {TipoMotor}, Matricula = {matricula}";
        }
    }
}
