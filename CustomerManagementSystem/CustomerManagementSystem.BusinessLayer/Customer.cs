using System;
using System.Collections.Generic;

namespace CustomerManagementSystem.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }

        private string _lastName;

        public string LastName
        {
            get 
            {
                return _lastName;
            }

            set 
            {
                _lastName = value;
            }
        }

        public string FirstName { get; set; } 
        
        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }
       
        public string Email { get; set; }

        public static int InstanceCount { get; set; }

        ///<summary>
        /// Retrieves one customer with the specific id 
        ///</summary>
        ///<returns></returns>
        public Customer Retrieve(int customerId)
        {
            // TODO: write logic to retrieve the customer with the specific id
            return new Customer();
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

        /// <summary>
        /// Validates Customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }

            return isValid;
        }


    }

}

