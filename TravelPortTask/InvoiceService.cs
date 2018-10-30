using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class InvoiceService: IInvoiceService
    {
        public Invoice invoice;
        private VATService _vatService;
        public Invoice GetInvoice(Customer customer, Supllier supllier, double amount, VATService vatService)
        {
            _vatService = vatService;

            invoice = new Invoice()
            {
                VAT = _vatService.CalculateVAT(customer, supllier),
                Amount = amount,
                customer = customer,
                supllier = supllier
            };
            return invoice;
        }
    }
}
