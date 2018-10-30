using System;

namespace TravelPortTask
{
    public interface IInvoiceService
    {
        Invoice GetInvoice(Supllier supllier, Customer customer, double amount);
    }
}
