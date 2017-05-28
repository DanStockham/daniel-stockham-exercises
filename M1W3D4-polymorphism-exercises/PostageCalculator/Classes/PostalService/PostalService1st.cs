using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Interfaces;

namespace PostageCalculator.Classes
{
    public class PostalService1st : IDeliveryDriver
    {
        private string name;

        public PostalService1st()
        {
            name = "Postal Service (1st class)";
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
            if(weight >= 0 && weight <= 2)
            {
                return distance * 0.035;
            }
            else if(weight >= 3 && weight <= 8)
            {
                return distance * 0.040;
            }
            else if(weight >= 9 && weight <= 15)
            {
                return distance * 0.047;
            }
            else if(weight >= 16 && weight <= 48)
            {
                return distance * 0.195;
            }
            else if(weight >= 64 && weight <= 128)
            {
                return distance * 0.450;
            }
            else
            {
                return weight * 0.500;
            }
            
        }

    }
}
