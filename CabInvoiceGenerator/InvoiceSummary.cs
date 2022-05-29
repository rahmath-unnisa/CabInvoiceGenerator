using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
       
        public int totalNumberOfRides;
        public double totalFair;
        public double averageFair;
       
        public InvoiceSummary(int totalNumberOfRides, double totalFair)
        {
            this.totalNumberOfRides = totalNumberOfRides;
            this.totalFair = totalFair;
            this.averageFair = this.totalFair / this.totalNumberOfRides;
        }
      
    }
}
    
