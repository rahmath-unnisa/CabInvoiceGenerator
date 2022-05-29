using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        const int MIN_FAIR = 5;
        const int FAIR_PER_KM = 10;
        const int FAIR_PER_MIN = 1;
        public double CalculateFair(int distance, int time)
        {
            double calculatefair = distance * FAIR_PER_KM + time * FAIR_PER_MIN;
            return Math.Max(calculatefair, MIN_FAIR);

        }
        public double MultipleRides(Ride[] rides)
        {
            double result = 0;
            foreach (var data in rides)
            {
                result += CalculateFair((int)data.distance, data.time);
            }
            return result / rides.Length;
        }

    }
}
