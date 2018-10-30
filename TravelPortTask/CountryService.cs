using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPortTask
{
    public class CountryService: ICountryService
    {
        string[] EUCountryCodes = {"lu", "mt", "de", "ro", "at", "bg", "ee", "fr", "cy", "lv", "sk", "uk", "be", "cz", "lt",
                                    "es", "nl", "it", "si", "pl", "pt", "ie", "fi", "el", "dk", "hr", "se", "hu" };

        public bool IsCountryInEU(string code)
        {
            if (EUCountryCodes.Contains(code.ToLower())) return true;
            else return false;
        }


        
    }
}
