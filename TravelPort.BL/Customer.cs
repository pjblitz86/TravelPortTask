using System;
using System.Collections.Generic;

namespace TravelPort.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {
            
        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public List<Address> AddressList { get; set; }
        public string Contact { get; set; }
        public bool isVATPayer { get; set; }
        public bool isLocationInEU { get; set; }
        public bool livesInSameEUCountry { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(Contact))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
