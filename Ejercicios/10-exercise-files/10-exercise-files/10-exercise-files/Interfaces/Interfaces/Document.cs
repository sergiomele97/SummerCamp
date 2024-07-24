using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public class MiDocumento : IStorable
    {
        public void Read(string fichero)
        {

        }

        public void Write(string fichero)
        {

        }
    }

   public class Document : IStorable, ISpeak
   {

      public void Reformat()
      {
         Console.WriteLine("Reformatting the document");

      }


       // IStorable
      public void Read(string nameOfFile)
      {
         Console.WriteLine($"Reading from {nameOfFile}...");
      }

      // IStorable
       public void Write(string fileName)
      {
         Console.WriteLine($"Writing to {fileName}...");
      }

      // ISpeak  
      public double DurationOfSpeach
      {
         get
         {
            return 42;
         }
      }

      // ISpeak 
      public void Speak()
      {
         Console.WriteLine("Speaking...");
      }
   }

}
