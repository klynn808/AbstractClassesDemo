using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE 
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.- DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax - DONE all for mike/lani - DONE
             */
            
            Car katesCar = new Car();
            Motorcycle mikesMotorcycle = new Motorcycle();
            Vehicle kalisToyCar = new Car();
            Vehicle lanisToyMotorcycle = new Motorcycle();

            katesCar.Model = "Wrangler";
            katesCar.Owner = "Kate";
            katesCar.Name = "Rumbler";
            katesCar.Year = 2027;
            katesCar.Make = "Jeep";
            katesCar.DriveAbstract();
            katesCar.DriveVirtual();
            katesCar.HasLockedGloveBox = true;
            katesCar.NumberOfDoors = 4;

            mikesMotorcycle.Model = "Renegade";
            mikesMotorcycle.Owner = "Mike Mike";
            mikesMotorcycle.Name = "Vroom Vroom";
            mikesMotorcycle.DriveAbstract();
            mikesMotorcycle.DriveVirtual();
            mikesMotorcycle.LevelOfFun = "Super Duper Fun";
            mikesMotorcycle.HasSideCar = true;
            mikesMotorcycle.Make = "Indian";
            mikesMotorcycle.Year = 2024;

            lanisToyMotorcycle.Model = "Super Speeder";
            lanisToyMotorcycle.Owner = "Lani";
            lanisToyMotorcycle.Name = "Zoom Zoom";
            lanisToyMotorcycle.DriveAbstract();
            lanisToyMotorcycle.DriveVirtual();
            lanisToyMotorcycle.Make = "Baby Speedsters";
            lanisToyMotorcycle.Year = 2023;
            // WOW casting to Motorcycle - allows you to utilize Motorcycle specific properties
            ((Motorcycle)lanisToyMotorcycle).HasSideCar = true;

            kalisToyCar.Model = "Little Baby Roadster";
            kalisToyCar.Owner = "Kali Coco";
            kalisToyCar.Name = "Kangavroom";
            kalisToyCar.Make = "Tiny Baby Speedsters";
            kalisToyCar.DriveVirtual();
            kalisToyCar.DriveAbstract();
            kalisToyCar.Year = 2022;


            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties DONE
             */
            vehicles.Add(katesCar);
            vehicles.Add(mikesMotorcycle);
            vehicles.Add(lanisToyMotorcycle);
            vehicles.Add(kalisToyCar);

            foreach(Vehicle v in vehicles)
            {
                Console.WriteLine($"{v.Name} is {v.Owner}'s {v.Year} {v.Make} {v.Model} ride");
                Console.WriteLine("___________________");
                v.DriveVirtual();
                v.DriveAbstract();
                Console.WriteLine("_____________________________");
            }
            

            // Call each of the drive methods for one car and one motorcycle DONE (called them all above)

            #endregion            
            Console.ReadLine();
        }
    }
}
