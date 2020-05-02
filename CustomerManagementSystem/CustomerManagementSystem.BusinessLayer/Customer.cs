using System;

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
    }

}

