using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }
        public string Name { get; set; }

        public string Owner { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{Owner} This is the virtual method already implemented"); 
        }
    }
}
