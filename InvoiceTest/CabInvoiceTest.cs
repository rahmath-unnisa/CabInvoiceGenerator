using CabInvoiceGenerator;
using NUnit.Framework;

namespace InvoiceTest
{
    public class Tests
    {
       

        [Test]
        public void CalculateFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double value = invoiceGenerator.CalculateFair(12, 10);

            Assert.AreEqual(130, value);
        }
        [Test]

        public void MultipleRides()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] ride = { new Ride(1,2), new Ride(3,4), new Ride(5, 6) };
            double result = invoiceGenerator.MultipleRides(ride);
            Assert.AreEqual(result, 34);

        }
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(2, 3), new Ride(4, 5), new Ride(5, 6) };
            InvoiceSummary result = invoice.MultipleRideSummary(rides);
            Assert.AreEqual(result.totalNumberOfRides, rides.Length);
        }
        [Test]
        public void GivenUserId_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(2, 3), new Ride(4, 5), new Ride(5, 6) };
            invoice.MapUserId("123Manha", rides);
            InvoiceSummary summary = invoice.GetRideInvoiceSummary("123Manha");
            Assert.AreEqual(summary.totalNumberOfRides, 3);
        }
    }
}