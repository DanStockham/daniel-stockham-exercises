using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        private int numberOfAxles;
        private string type;

        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
            type = "Truck";
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public int NumberOfAxles
        {
            get
            {
                return numberOfAxles;
            }
        } 

        public double CalculateToll(int distance)
        {
            double milageRate = 0.0;
            double toll = 0.0;

            switch(NumberOfAxles)
            {
                case 4:
                    milageRate = 0.040;
                    break;
                case 6:
                    milageRate = 0.045;
                    break;
                default:
                    milageRate = 0.048;
                    break;
            }

            toll = milageRate * distance;
            return toll;
        }


    }
}
