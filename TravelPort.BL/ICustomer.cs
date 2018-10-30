using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Contact { get; set; }

        bool isVATPayer { get; set; }
        bool livesInEU { get; set; }
        bool livesInEUSameCountry { get; set; }

    }
}
