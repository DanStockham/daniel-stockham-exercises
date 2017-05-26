using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleList = new List<IVehicle>();
            Random randMiles = new Random();
            int totalMiles = 0;
            double revenue = 0.0;

            vehicleList.Add( new Car(false) );
            vehicleList.Add( new Car(true) );
            vehicleList.Add( new Tank());
            vehicleList.Add( new Truck(6) );

            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Vehicle", "Distance Traveled", "Toll $");
            Console.WriteLine("----------------------------------------------");
            foreach(IVehicle vehicle in vehicleList)
            {
                int milesTraveled = randMiles.Next(10, 240);
                double amountCharged = vehicle.CalculateToll(milesTraveled);

                Console.WriteLine("{0,-20}{1,-20}{2,-20:$0.00}", vehicle.Type, milesTraveled, amountCharged);

                totalMiles += milesTraveled;
                revenue += amountCharged;
            }

            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled: " + totalMiles);
            Console.WriteLine("Total Tollbooth Revenue: ${0:0.00}", revenue);
        }
    }
}
