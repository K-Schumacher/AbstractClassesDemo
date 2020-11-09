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
             * Create an abstract class called Vehicle -- DONE
             * The vehicle class shall have three string properties Year, Make, and Model -- Done
             * Set the defaults to something generic in the Vehicle class -- DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation -- DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. -- DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -- DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -- DONE
             * Provide the implementations for the abstract methods -- DONE
             * Only in the Motorcycle class will you override the virtual drive method -- DONE
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car fusion = new Car()
            {
                Make = "Ford",
                Model = "Fusion",
                Year = 2019,
                HasTrunk = true
            };

            Motorcycle harley = new Motorcycle()
            {
                Make = "Harley Davidson",
                Model = "Street 750",
                Year = 2020,
                HasSideCart = false
            };

            Vehicle sedan = new Car()
            {
                Make = "Infinity",
                Model = "Q70L",
                Year = 2019,
                HasTrunk = true
            };

            Vehicle muscle = new Car()
            {
                Make = "Dodge",
                Model = "Viper",
                Year = 2018,
                HasTrunk = false
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(muscle);
            vehicles.Add(sedan);
            vehicles.Add(harley);
            vehicles.Add(fusion);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Year: {veh.Year}");
                Console.WriteLine($"Make: {veh.Make}");
                Console.WriteLine($"Model: {veh.Model}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine();

            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
