using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string productName, double price, int quantity)
        {
            Product newProduct = new Product(productName, price, quantity);
            products.Add(newProduct);
            Console.WriteLine($"Product '{productName}' added with price {price} and quantity {quantity}.");
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (Product product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }

            return totalPrice;
        }

        public class Product
        {
            public string Name { get; private set; }
            public double Price { get; private set; }
            public int Quantity { get; private set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
    }
}

