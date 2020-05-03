using CustomerManagementSystem.BusinessLayer.Enums;
using System;
using System.Collections.Generic;

namespace CustomerManagementSystem.BusinessLayer
{
    public class Customer : EntityBase
    {
        public Customer(): this(0)
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }

        public CustomerType CustomerType { get; set; }

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

        public List<Address> AddressList { get; set; }

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

