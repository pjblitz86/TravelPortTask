using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class VATService
    {
        public double VAT { get; set; }

        private CountryService _countryService;
        public VATService()
        {

        }
        public VATService(CountryService countryService)
        {
            _countryService = countryService;
        }

        public double CalculateVAT(Customer customer, Supllier supllier)
        {
            if(supllier.IsVAT_TaxPayer)
            {
                if(customer.IsInEU)
                {
                    if(!customer.IsVAT_TaxPayer && !(customer.Country2DigitCode == supllier.Country2DigitCode))
                    {
                        VAT = GetVAT_Rate(customer.Country2DigitCode);
                    }
                    else if(customer.Country2DigitCode == supllier.Country2DigitCode)
                    {
                        VAT = GetVAT_Rate(customer.Country2DigitCode);
                    }
                    else
                    {
                        VAT = 0;
                    }
                }
                else
                {
                    VAT = 0;
                }
            }
            else
            {
                VAT = 0;
            }
            return VAT;
        }

        private double GetVAT_Rate(string EUCountry2DigitCode)
        {
            switch (EUCountry2DigitCode.ToLower())
            {
                case "lu": return 0.17;
                case "mt": return 0.18;

                case "de": 
                case "ro": return 0.19;

                case "at":
                case "bg":
                case "ee":
                case "fr":
                case "cy":
                case "lv":
                case "sk":
                case "uk": return 0.20;

                case "be":
                case "cz":
                case "lt":
                case "es":
                case "nl": return 0.21;

                case "it": 
                case "si": return 0.22;

                case "pl": 
                case "pt": 
                case "ie": return 0.23;

                case "fi": 
                case "el": return 0.24;

                case "dk":
                case "hr":
                case "se": return 0.25;

                case "hu": return 0.27;
                
                default: return 0;
            }
        }
    }
}
