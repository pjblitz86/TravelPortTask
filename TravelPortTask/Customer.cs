using System;
using TravelPortTask;

namespace TravelPortTask
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Country2DigitCode { get; set; }
        public bool IsJuridical { get; set; }
        public bool IsVAT_TaxPayer { get; set; }
        public bool IsCustomerInEU { get; set; }

        private ICountryService _countryService;
        public Customer(ICountryService countryService)
        {
            _countryService = countryService;
            IsCustomerInEU = _countryService.IsCountryInEU(Country2DigitCode);
        }

        
    }
}
