using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; } // allows OrderDate to be set in different timezones

        ///<summary>
        /// Retrieves one order with the specific id 
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderId)
        {
            // TODO: write logic to retrieve the order with specific Id
            return new Order();
        }

        ///<summary>
        /// Retrieves all orders
        ///</summary>
        ///<returns></returns>
        public List<Order> Retrieve()
        {
            // TODO: write logic to retrieve all the orders
            return new List<Order>();
        }

        ///<summary>
        /// Save the current Order
        ///</summary>
        ///<returns></returns>
        public void Save()
        {
            // TODO: write logic to save the order
        }

        /// <summary>
        /// Validates Order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
