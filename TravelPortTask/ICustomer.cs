using System;

namespace TravelPortTask
{
    public interface ICustomer
    {
        bool isSupllierVATPayer { get; set; }
        double calculateCustomerTaxVAT(bool isEU, bool isVAT, bool inSameCountry, string euCountry2LetterCode);
    }
}
