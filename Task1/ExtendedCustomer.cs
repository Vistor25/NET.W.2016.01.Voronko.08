using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public static class ExtendedCustomer
    {
        public static string ExtendetToString(this Customer customer, string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "CRN":
                    return $"Customer record: {customer.ContactPhone:+# (###) ###-####}, {customer.Revenue.ToString("#,#.00", formatProvider)}, {customer.Name}";
                case "NRCByRow":
                    return $"Customer record:\n{customer.Name},\n{customer.Revenue.ToString("#,#.00", formatProvider)},\n{customer.ContactPhone:+# (###) ###-####}";
                default:
                    return "error";
            }
        }
    }
}
