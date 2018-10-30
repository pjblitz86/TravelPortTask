using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class VATCalculator
    {
        public double VAT { get; set; }


        private double CalculateVAT(Customer customer, Supllier supllier)
        {


            // implementation
            return VAT;
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

        private double GetVAT_Rate(string euCountry2LetterCode)
        {
            switch (euCountry2LetterCode.ToLower())
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
