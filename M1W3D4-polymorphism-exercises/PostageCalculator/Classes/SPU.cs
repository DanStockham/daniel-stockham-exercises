using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Interfaces;

namespace PostageCalculator.Classes
{
    public class SPU : IDeliveryDriver
    {
        private string name;
        private int option;

        public SPU(int option)
        {
            this.option = option;
            if(option == 0)
            {
                name = "SPU (4-day ground)";
            }
            else if(option == 1)
            {
                name = "SPU (2-day business)";
            }
            else
            {
                name = "SPU (next-day)";
            }
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
            double weightInPounds = weight / 16;

            if(option == 0)
            {
                return (weightInPounds * 0.0050) * distance;
            }
            else if(option == 1)
            {
                return (weightInPounds * 0.050) * distance;
            }
            else
            {
                return (weightInPounds * 0.075) * distance;
            }
        }
    }
}
