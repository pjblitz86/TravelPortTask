using System;
using TravelPortTask;

namespace TravelPortTask
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool isSupllierVATPayer { get; set; }

        public double calculateCustomerTaxVAT(bool isEU, bool isVAT, bool inSameCountryAsSupllier, string euCountry2LetterCode)
        {
            double taxVAT;

            if(isSupllierVATPayer)
            {
                if(isEU)
                {
                    if (!isVAT && !inSameCountryAsSupllier)
                    {
                        taxVAT = getVAT_Rate(euCountry2LetterCode);
                    }
                    else if (inSameCountryAsSupllier)
                    {
                        taxVAT = 0.21; // Supllier is in LT
                    }
                    else
                    {
                        taxVAT = 0;
                    }
                }
                else
                {
                    taxVAT = 0;
                }
            } else
            {
                taxVAT = 0;
            }

            return taxVAT;
        }

        private double getVAT_Rate(string euCountry2LetterCode)
        {
            switch(euCountry2LetterCode.ToLower())
            {
                case "at": return 0.20;
                case "be": return 0.21;
                case "bg": return 0.20;
                case "cz": return 0.21;
                case "dk": return 0.25;
                case "de": return 0.19;
                case "ee": return 0.20;
                case "ie": return 0.23;
                case "el": return 0.24;
                case "es": return 0.21;
                case "fr": return 0.20;
                case "hr": return 0.25;
                case "it": return 0.22;
                case "cy": return 0.20;
                case "lv": return 0.20;
                case "lt": return 0.21;
                case "lu": return 0.17;
                case "hu": return 0.27;
                case "mt": return 0.18;
                case "nl": return 0.21;
                case "pl": return 0.23;
                case "pt": return 0.23;
                case "ro": return 0.19;
                case "si": return 0.22;
                case "sk": return 0.20;
                case "fi": return 0.24;
                case "se": return 0.25;
                case "uk": return 0.20;
                default: return 0;
            }
        }
    }
}
