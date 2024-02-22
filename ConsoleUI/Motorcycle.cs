using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"{base.Name}goes really high speeds and has a {LevelOfFun} level of fun.");
            Console.WriteLine($"Does this cycle have a side car: {HasSideCar}");
        }

        public string LevelOfFun { get; set;  }

        public bool HasSideCar { get; set; }

        

    }
}
