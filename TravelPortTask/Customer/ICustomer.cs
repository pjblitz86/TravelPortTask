using System;

namespace TravelPortTask
{
    public interface ICustomer
    {
        double calculateCustomerTaxVAT(bool isEU, bool isVAT, bool inSameCountry);
    }
}
