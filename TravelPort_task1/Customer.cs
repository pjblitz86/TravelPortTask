using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort_task1
{
    abstract class Customer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public bool isVATPayer { get; set; }
        public bool isLocationInEU { get; set; }
        public bool livesInSameEUCountry { get; set; }

    }

    class IndClient: Customer
    {

    }

    class JurClient: Customer
    {

    }
}
