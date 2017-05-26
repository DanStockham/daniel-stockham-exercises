using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        private bool hasTrailer;
        private string type;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
            type = "Car";
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public bool HasTrailer
        {
            get
            {
                return hasTrailer;
            }
        }


        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;
            if(HasTrailer)
            {
                toll += 1;
            }

            return toll;
        }
    }
}
