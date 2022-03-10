using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.Models 
{
    public class ProductDisplayModel : INotifyPropertyChanged
    {
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
        private int _quantityInStock;

        public int QuantityInStock
        {
            get { return _quantityInStock; }
            set 
            { 
                _quantityInStock = value; 
                CallPropertyChanged(nameof(QuantityInStock));
            }
        }


        /// <summary>
        /// Indicator that product is taxable
        /// </summary>
        public bool IsTaxable { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void CallPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
