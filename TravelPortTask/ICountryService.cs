using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPortTask
{
    public interface ICountryService
    {
        bool IsCountryInEU(string code, string name);
    }
}
