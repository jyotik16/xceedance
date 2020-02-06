using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBIZ
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Microsoft Way";
                address.StreetLine2 = "C# Blvd";
                address.City = "Seattle";
                address.State = "Washington";
                address.Country = "United States";
                address.PostalCode = "98052";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Microsoft Way",
                StreetLine2 = "C# Blvd",
                City = "Seattle",
                State = "Washington",
                Country = "United States",
                PostalCode = "98052"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Happy Island",
                City = "Saltwater Shores",
                State = "Washington",
                Country = "United States",
                PostalCode = "98569"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}