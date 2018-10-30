using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public class Supllier
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public double VAT_Tax { get; set; }
        public bool IsSupllierInEU { get; set; }

        private ICountryService _countryService;

        public Supllier(ICountryService countryService)
        {
            _countryService = countryService;
            IsSupllierInEU = _countryService.IsCountryInEU("lt", "lietuva");
        }
    }
}
