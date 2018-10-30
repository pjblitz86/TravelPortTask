using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Invoice
    {
        public Customer customer;
        public Supllier supllier;
        public double VAT { get; set; }
        public double Amount { get; set; }
    }
}
