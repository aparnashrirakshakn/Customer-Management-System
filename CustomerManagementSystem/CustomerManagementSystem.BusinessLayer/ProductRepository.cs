using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class ProductRepository
    {
        ///<summary>
        /// Retrieves one product with the specific id 
        ///</summary>
        ///<returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Wings of Fire";
                product.ProductDescription = "An autobiography of one of the most loved men in India - Dr. A.P.J Abdul Kalam";
                product.CurrentPrice = 25.00;
            }
            
            return product;
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

    }
}
