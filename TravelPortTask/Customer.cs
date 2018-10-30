using System;
using TravelPortTask;

namespace TravelPortTask
{
    public class Customer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public double VAT_Tax { get; set; }
        public bool IsCustomerInEU { get; set; }

        private ICountryService _countryService;

        public Customer(ICountryService countryService)
        {
            _countryService = countryService;
            IsCustomerInEU = _countryService.IsCountryInEU("lt", "lietuva");
        }

        //public double calculateCustomerTaxVAT(bool isEU, bool isVAT, bool inSameCountryAsSupllier, string euCountry2LetterCode)
        //{
        //    double taxVAT;

        //    if(isSupllierVATPayer)
        //    {
        //        if(isEU)
        //        {
        //            if (!isVAT && !inSameCountryAsSupllier)
        //            {
        //                taxVAT = getVAT_Rate(euCountry2LetterCode);
        //            }
        //            else if (inSameCountryAsSupllier)
        //            {
        //                taxVAT = 0.21; // Supllier is in LT
        //            }
        //            else
        //            {
        //                taxVAT = 0;
        //            }
        //        }
        //        else
        //        {
        //            taxVAT = 0;
        //        }
        //    } else
        //    {
        //        taxVAT = 0;
        //    }

        //    return taxVAT;
        //}
    }
}
