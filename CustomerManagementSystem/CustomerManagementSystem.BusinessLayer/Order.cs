using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class Order : EntityBase
    {
        public Order(): this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; } // allows OrderDate to be set in different timezones

        public List<OrderItem> OrderItems { get; set; }

        public int ShippingAddressId { get; set; }

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
