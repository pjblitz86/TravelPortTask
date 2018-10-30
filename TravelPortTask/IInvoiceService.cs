using System;

namespace TravelPortTask
{
    public interface IInvoiceService
    {
        InvoiceService GetInvoice(Supllier supllier, Customer customer, double amount);
    }
}
