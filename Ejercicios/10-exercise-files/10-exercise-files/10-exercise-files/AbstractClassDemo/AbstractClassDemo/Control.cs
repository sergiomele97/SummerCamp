using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public interface IControl
    {
        string Name { get; set; }
    }

    public abstract class Control //:  IControl
    {
        
        //public string Name { get; set; }
        
        protected int xPos;
        protected int yPos;

        public Control(int xPosition, int yPosition)
        {
            xPos = xPosition;
            yPos = yPosition;
        }

        public virtual void Clear()
        {
            Console.WriteLine("Clearing control");

        }

        public abstract void Draw();

       
    }
}
