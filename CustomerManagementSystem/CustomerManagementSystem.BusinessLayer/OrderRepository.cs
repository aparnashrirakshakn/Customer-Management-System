using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class OrderRepository
    {
        ///<summary>
        /// Retrieves one order with the specific id 
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId == 3)
            {
                order.OrderDate = new DateTimeOffset(2007, 5, 1, 9, 0, 0, TimeSpan.Zero); // 05/01/2007 09:00:00 +00:00
            }

            return order;
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

    }
}
