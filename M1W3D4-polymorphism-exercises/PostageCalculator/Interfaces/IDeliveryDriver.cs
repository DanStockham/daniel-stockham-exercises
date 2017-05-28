using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Interfaces
{
    public interface IDeliveryDriver
    {
        double CalculateRate(int distance, double weight);
        string Name { get; }
    }
}
