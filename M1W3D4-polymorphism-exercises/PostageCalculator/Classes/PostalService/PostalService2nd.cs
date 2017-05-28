using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Interfaces;

namespace PostageCalculator.Classes
{
    public class PostalService2nd : IDeliveryDriver
    {
        private string name;

        public PostalService2nd()
        {
            name = "Postal Service (2nd class)";
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
                return distance * 0.0035;
            }
            else if (weight >= 3 && weight <= 8)
            {
                return distance * 0.0040;
            }
            else if (weight >= 9 && weight <= 15)
            {
                return distance * 0.0047;
            }
            else if (weight >= 16 && weight <= 48)
            {
                return distance * 0.0195;
            }
            else if (weight >= 64 && weight <= 128)
            {
                return distance * 0.0450;
            }
            else
            {
                return weight * 0.0500;
            }
        }
    }
}
