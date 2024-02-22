using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"{base.Name} is a speedy little moving thang");
        }

        public bool HasLockedGloveBox { get; set; }
        public int NumberOfDoors { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine($"{base.Owner} likes to drive around saying vroom");
        }
    }
}
