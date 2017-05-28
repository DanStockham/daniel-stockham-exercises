using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Interfaces;

namespace PostageCalculator.Classes
{
    public class PostalService3rd : IDeliveryDriver
    {
        private string name;

        public PostalService3rd()
        {
            name = "Postal Service (3rd class)";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double CalculateRate(int distance, double weight)
        {
            if (weight >= 0 && weight <= 2)
            {
                return distance * 0.0020;
            }
            else if (weight >= 3 && weight <= 8)
            {
                return distance * 0.0022;
            }
            else if (weight >= 9 && weight <= 15)
            {
                return distance * 0.0024;
            }
            else if (weight >= 16 && weight <= 48)
            {
                return distance * 0.0150;
            }
            else if (weight >= 64 && weight <= 128)
            {
                return distance * 0.0160;
            }
            else
            {
                return weight * 0.0170;
            }
        }
    }
}
