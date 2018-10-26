using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // instance of the Customer class
            Customer customer = new Customer(customerId);

            // code that retrieves Customer

            // temporary hard code for populating customer
            if(customerId == 1)
            {
                customer.Contact = "test@gmail.com";
                customer.FirstName = "testFirstName";
                customer.LastName = "testLastName";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            // code that returns all customers
            return new List<Customer>();
        }

        public bool Save()
        {
            // code that saves defined customer
            return true;
        }
    }
}
