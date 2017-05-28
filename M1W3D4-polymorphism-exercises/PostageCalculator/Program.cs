using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Interfaces;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> postageServices = new List<IDeliveryDriver>();

            postageServices.Add(new PostalService1st());
            postageServices.Add(new PostalService2nd());
            postageServices.Add(new PostalService3rd());
            postageServices.Add(new FexEd());
            postageServices.Add(new SPU(0));
            postageServices.Add(new SPU(1));
            postageServices.Add(new SPU(2));

            Console.WriteLine("Please enter the weight of the package? ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("(P)ounds or (O)unces? ");
            string unit = Console.ReadLine().ToLower();

            if(unit == "p")
            {
                weight *= 16;
            }

            Console.WriteLine("What distance will it be traveling to? ");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-40}{1}", "Delivery Method", "$ cost");
            Console.WriteLine("-----------------------------------------------");

            foreach (IDeliveryDriver item in postageServices)
            {
                Console.WriteLine("{0,-40}{1:$0.00}", item.Name,item.CalculateRate(distance,weight));
            }


            
            

        }
    }
}
