using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Supllier
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Country2DigitCode { get; set; }
        public bool IsVAT_TaxPayer { get; set; }
        public bool IsSupllierInEU { get; set; }

        private ICountryService _countryService;
        public Supllier(ICountryService countryService)
        {
            _countryService = countryService;
            IsSupllierInEU = _countryService.IsCountryInEU(Country2DigitCode);
        }
    }
}
