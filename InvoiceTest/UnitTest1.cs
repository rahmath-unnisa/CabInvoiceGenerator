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
    }
}