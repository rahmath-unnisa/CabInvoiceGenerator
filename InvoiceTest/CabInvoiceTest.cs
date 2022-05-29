using CabInvoiceGenerator;
using NUnit.Framework;

namespace InvoiceTest
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double value = invoiceGenerator.CalculateFair(12, 10);

            Assert.AreEqual(130, value);
        }
        [Test]

        public void MultipleRides()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(1,2), new Ride(3,4), new Ride(5, 6) };
            double result = invoiceGenerator.MultipleRides(rides);
            Assert.AreEqual(result, 34);

        }
    }
}