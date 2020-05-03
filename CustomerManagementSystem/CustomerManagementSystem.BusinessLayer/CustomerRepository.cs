using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class CustomerRepository
    {
        ///<summary>
        /// Retrieves one customer with the specific id 
        ///</summary>
        ///<returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.FirstName = "Aparna";
                customer.LastName = "Shriraksha";
                customer.Email = "myvalidemail@email.me";
            }

            return customer;
        }

        ///<summary>
        /// Retrieves all customers
        ///</summary>
        ///<returns></returns>
        public List<Customer> Retrieve()
        {
            // TODO: write logic to retrieve the customer with the specific id
            return new List<Customer>();
        }

        ///<summary>
        /// Save the current Customer
        ///</summary>
        ///<returns></returns>
        public void Save()
        {
            // TODO: write logic to save the customer
        }

    }
}
