using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double? CurrentPrice { get; set; }

        /// <summary>
        /// Validates Product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
