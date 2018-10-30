using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Invoice: IInvoiceService
    {
        public Invoice invoice;
        private Customer _customer;
        private Supllier _supllier;
        private double _amount;

        public Invoice()
        {
            
        }

        public Invoice GetInvoice(Supllier supllier, Customer customer, double amount)
        {
            _supllier = supllier;
            _customer = customer;
            _amount = amount;
            return invoice;
        }
    }
}
