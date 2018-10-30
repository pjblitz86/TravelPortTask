using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Supllier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Country2DigitCode { get; set; }
        public bool IsVAT_TaxPayer { get; set; }
        public bool IsInEU { get; set; }

        private ICountryService _countryService;
        public Supllier()
        {

        }
        public Supllier(ICountryService countryService)
        {
            _countryService = countryService;
            IsInEU = _countryService.IsCountryInEU(Country2DigitCode);
        }
    }
}
