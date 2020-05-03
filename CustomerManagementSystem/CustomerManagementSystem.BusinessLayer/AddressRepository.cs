using CustomerManagementSystem.BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.AddressType = AddressType.Home;
                address.StreetLine1 = "Dream Street";
                address.StreetLine2 = "Happiness Ave";
                address.City = "Hope City";
                address.Country = "Merryland";
                address.PostalCode = "1234";
            }

            return address;

        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address1 = new Address(1)
            {
                AddressType = AddressType.Home,
                StreetLine1 = "Street 1",
                StreetLine2 = "Substreet 10",
                City = "Hope City",
                Country = "MerryLand",
                PostalCode = "1234"
            };
            addressList.Add(address1);

            Address address2 = new Address(2)
            {
                AddressType = AddressType.Work,
                StreetLine1 = "Street 9",
                StreetLine2 = "Substreet 14",
                City = "Hope City",
                Country = "MerryLand",
                PostalCode = "4321"
            };
            addressList.Add(address2);

            return addressList;

        } 
        
    }
}
