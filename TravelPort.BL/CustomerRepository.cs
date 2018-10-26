using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPort.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            // instance of the Customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            // code that retrieves Customer

            // temporary hard code for populating customer, later with nsubstitute
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

        public bool Save(Customer customer)
        {
            // code that saves defined customer
            return true;
        }
    }
}
