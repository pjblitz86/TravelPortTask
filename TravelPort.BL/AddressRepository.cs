using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            // instance of the Address class
            Address address = new Address(addressId);

            // code that retrieves Address from Customer

            // temporary hard code for populating address
            if (addressId == 1)
            {
                address.StreetLine1 = "Street1";
                address.StreetLine2 = "Street2";
                address.City = "citytest";
                address.State = "statetest";
                address.Country = "CountryTest";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves Address from Customer

            // temporary hard code to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "testStreet01",
                StreetLine2 = "testStreet02",
                City = "TestCity01",
                State = "TestState01",
                Country = "TestCountry01",
                PostalCode = "444"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "testStreet03",
                StreetLine2 = "testStreet04",
                City = "TestCity02",
                State = "TestState02",
                Country = "TestCountry02",
                PostalCode = "333"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save()
        {
            // code that saves defined address
            return true;
        }
    }
}
