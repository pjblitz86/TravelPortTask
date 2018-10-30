using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Invoice
    {
        public int Id { get; set; }
        public double VAT { get; set; }
        public double Amount { get; set; }
        public Customer customer;
        public Supllier supllier;

        
        private InvoiceService _invoiceService;
        private VATService _vatService;
        public Invoice() // default properties
        {

        }

        public Invoice(InvoiceService invoiceService, VATService vatService)
        {
            _invoiceService = invoiceService;
            _vatService = vatService;
            _invoiceService.GetInvoice(customer, supllier, Amount, _vatService);
        }
    }
}
