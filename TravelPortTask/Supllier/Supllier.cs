using System;

namespace TravelPortTask
{
    public class Supllier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool isVATPayer { get; set; }

        public double calculateCustomerTaxVAT(bool isEU, bool isVAT, bool inSameCountry)
        {
            double taxVAT;
            
            if(isEU)
            {
                if(isVAT)
                {
                    if(inSameCountry)
                    {
                        taxVAT = 0.21; // LTU
                    }
                    else
                    {
                        taxVAT = getEUCountrySpecificVAT("Poland");
                    }
                } else
                {
                    taxVAT = 0;
                }
            }
            else
            {
                taxVAT = 0;
            }

            return taxVAT;
        }

        public double getEUCountrySpecificVAT(string EUCountry)
        {
            if (EUCountry.ToLower() == "lithuania")
            {
                return 0.21;
            }
            else return 0.10;
        }
    }
}
