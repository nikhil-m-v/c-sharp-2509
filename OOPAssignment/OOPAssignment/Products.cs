using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Products
    {
        private string productName { get; set; }
        private int productStock;
        private int productPrice;
        public Products(string Name, int Stock, int Price)
        {
            productName = Name;
            productStock = Stock;
            productPrice = Price;
        }

        public int Price
        {
            get { return productPrice; }
            set
            {
                if (value >= 0)
                {
                    productPrice = value;
                }
                else
                {
                    Console.WriteLine("Error: Price cannot be set to a negative value.");
                }
            }
        }

        public int Stock
        {
            get { return productStock; }
            set
            {
                if (value >= 0)
                {
                    productStock = value;
                }
                else
                {
                    Console.WriteLine("Error: Stock cannot be set to a negative value.");
                }
            }
        }
        public override string ToString()
        {
            return $"Product: {productName}, Stock: {productStock}, Price: {productPrice}";
        }
        public void PlaceOrder(int quantity)
        {
            if (quantity > 0 && productStock >= quantity)
            {
                productStock -= quantity;
                Console.WriteLine($"Order successful for {quantity} {productName}. Remaining stock: {productStock}");
            }
            else
            {
                Console.WriteLine("Order failed: Not enough stock or invalid quantity.");
            }
        }
    }
}
