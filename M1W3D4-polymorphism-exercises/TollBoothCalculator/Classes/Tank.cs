using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        private string type;

        public Tank()
        {
            type = "Tank";
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public double CalculateToll(int distance)
        {
            return 0;
        }
    }
}
