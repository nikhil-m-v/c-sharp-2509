using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    class Product
    {
        public string name;
        public int price;
        public int discount;

        public Product(string productName)
        {
            name = productName;
            price = 0;
            discount = 0;
        }

        public Product(string productName, int productPrice)
        {
            name = productName;
            price = productPrice;
            discount = 0;
        }

        public Product(string productName, int productPrice, int productDiscount)
        {
            name = productName;
            price = productPrice;
            discount = productDiscount;
        }

        public void CalculateFinalPrice()
        {
            int finalPrice = price - discount;
            Console.WriteLine($"Product: {name}, Price: {price}, Discount: {discount}, Final Price: {finalPrice}");
        }
    }
}
