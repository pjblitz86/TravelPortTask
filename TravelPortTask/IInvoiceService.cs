using System;

namespace TravelPortTask
{
    public interface IInvoiceService
    {
        Invoice GetInvoice(Customer customer, Supllier supllier, double amount, VATService vatService);
    }
}
