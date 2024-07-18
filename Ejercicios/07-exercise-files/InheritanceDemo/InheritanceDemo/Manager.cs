using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   public class Manager : Employee
   {
      public bool TienePlaza { get; set; }
      public int NumeroPlaza { get; set; }

        public Manager(string name, bool hasCar, int numeroPlaza)
         :base(name)
      {
         TienePlaza = hasCar;
         NumeroPlaza = numeroPlaza;
      }


        public override void getVacations()
        {
            Console.Write($"{Name} es un gerente y ");

            if (TienePlaza) { Console.Write($"tiene plaza de parking: numero {NumeroPlaza}"); }
            else { Console.Write("no tiene plaza de parking."); }

            Console.WriteLine($"\n{Name} cuenta con {vacationDays + 4} dias de vacaciones disponibles.");
            
        }


        public override string ToString()
      {
         return
            $"[Manager. Name={Name} Plaza de parking={NumeroPlaza}, Vacation={vacationDays}]";
      }
   }
}
