using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double? PurchasePrice { get; set; }


        ///<summary>
        /// Retrieves one orderItem with the specific id 
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderItemId)
        {
            // TODO: write logic to retrieve the orderItem with specific Id
            return new Order();
        }

        ///<summary>
        /// Retrieves all orderItems
        ///</summary>
        ///<returns></returns>
        public List<Order> Retrieve()
        {
            // TODO: write logic to retrieve all the orderItems
            return new List<Order>();
        }

        ///<summary>
        /// Save the current orderItem
        ///</summary>
        ///<returns></returns>
        public void Save()
        {
            // TODO: write logic to save the orderItem
        }

        /// <summary>
        /// Validates orderItem data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0 || PurchasePrice <= 0.0 || PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
