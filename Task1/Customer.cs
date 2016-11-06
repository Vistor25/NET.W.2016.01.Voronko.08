using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Customer:IFormattable
    {
        private string name;
        private long contactPhone;
        private decimal revenue;

        public string Name
        {
            get;
        }

        public long ContactPhone
        {
            get;set;
        }

        public decimal Revenue
        {
            get;set;
        }

        public Customer()
        {

        }

        public Customer(string name, long contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;

        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format) { 
                case"NRC":
                    return $"Customer record: {Name}, {Revenue.ToString("#,#.00", formatProvider)}, {ContactPhone:+# (###) ###-####}";
                case "C":
                    return $"Customer record: {ContactPhone:+# (###) ###-####}";
                case "NR":
                    return $"Customer record: {Name}, {Revenue.ToString("#,#.00", formatProvider)}";
                case "N":
                    return $"Customer record: {Name}";
                case "R":
                    return $"Customer record: {Revenue.ToString("#,#.00", formatProvider)}";
                default:
                    return $"Customer record: {Name}, {Revenue.ToString("#,#.00", formatProvider)}, {ContactPhone:+# (###) ###-####}";

            }
        }
    }
}
