using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        [TestCase("NRC", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase("C", ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase("NR", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00")]
        [TestCase("N", ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase("R", ExpectedResult = "Customer record: 1,000,000.00")]


        public string CustomerToStringMethodTest(string format)
        {
            Customer customer = new Customer("Jeffrey Richter", 14255550100, 1000000);
            CultureInfo ci = new CultureInfo("en-US");
            return customer.ToString(format, ci);
        }

        [Test]
        [TestCase("CRN", ExpectedResult = "Customer record: +1 (425) 555-0100, 1,000,000.00, Jeffrey Richter")]
        [TestCase("NRCByRow", ExpectedResult = "Customer record:\nJeffrey Richter,\n1,000,000.00,\n+1 (425) 555-0100")]


        public string ExtendedCustomerToStringMethodTest(string format)
        {
            Customer customer = new Customer("Jeffrey Richter", 14255550100, 1000000);
            CultureInfo ci = new CultureInfo("en-US");
            return customer.ExtendetToString(format, ci);

        }

    }
}
