using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   public class Worker : Employee
   {
      public double HourlyWage { get; set; }
      public string Turno { get; set; }

      public Worker(string name, double wage, string turno)
           : base(name)
        {
            HourlyWage = wage;
            Turno = turno;
        }

        public override void getVacations()
        {
            Console.WriteLine($"{Name} es un trabajador, cuenta con {vacationDays + 2} dias de vacaciones disponibles y trabaja en el turno de {Turno}\n");
        }

        public override string ToString()
      {
         return 
            $"[Worker.  Name: {Name} Turno: {Turno} Vacation: { vacationDays}]";
      }
   }
}
