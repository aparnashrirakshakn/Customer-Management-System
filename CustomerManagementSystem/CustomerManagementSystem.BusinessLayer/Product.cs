using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem.BusinessLayer
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName { 
            get
            {
                return StringHandler.InsertSpaces(_productName);               
            }

            set
            {
                _productName = value;
            }
        }

        public string ProductDescription { get; set; }

        public double? CurrentPrice { get; set; }

        /// <summary>
        /// Validates Product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
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
