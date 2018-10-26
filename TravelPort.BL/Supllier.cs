using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class Supllier
    {
        public Supllier()
        {

        }
        public Supllier(int supplierId)
        {
            this.SupplierId = supplierId;
        }
        public int SupplierId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string Address { get; set; }
        public string Contact { get; set; }
        public bool isVATPayer { get; set; }
        

        public bool Save()
        {
            // code that saves defined customer
            return true;
        }

        public Customer Retrieve(int supllierId)
        {
            // code that retrieves defined customer
            return new Customer(supllierId);
        }

        public List<Supllier> Retrieve()
        {
            // code that returns all customers
            return new List<Supllier>();
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
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
