using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    class Product
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

        ///<summary>
        /// Retrieves one product with the specific id 
        ///</summary>
        ///<returns></returns>
        public Product Retrieve(int productId)
        {
            // TODO: write logic to retrieve the product with specific Id
            return new Product();
        }

        ///<summary>
        /// Retrieves all products
        ///</summary>
        ///<returns></returns>
        public List<Product> Retrieve()
        {
            // TODO: write logic to retrieve all the products
            return new List<Product>();
        }

        ///<summary>
        /// Save the current Product
        ///</summary>
        ///<returns></returns>
        public void Save()
        {
            // TODO: write logic to save the product
        }

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
