using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.Library.Models
{
    public class ProductModel
    {
        /// <summary>
        /// The unique identifier for a given product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The product description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The retail price of the product before tax
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// The quantity in stock
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// Indicator that product is taxable
        /// </summary>
        public bool IsTaxable { get; set; }
    }
}
