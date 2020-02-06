using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBIZ
{
    public class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }
        List<Customer> ll = new List<Customer>();
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
           public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "ssmith@greenenergy.com";
                customer.FirstName = "Susan";
                customer.LastName = "Smith";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            ll.Add(customer);
            return true;
        }
    }
}