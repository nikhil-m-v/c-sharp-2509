using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Items
    {
        private string itemName {  get; set; }
        private int itemStock {  get; set; }
        private int itemPrice;
        public Items(string Name, int Stock, int iPrice) 
        {
            itemName = Name;
            itemStock = Stock;
            Price = iPrice;
        }

        public int Price
        {
            get { return itemPrice; }
            set
            {
                if (value >= 0)
                {
                    itemPrice = value;
                }
                else
                {
                    Console.WriteLine("Error: Price cannot be set to a negative value.");
                }
            }
        }

        public int Stock
        {
            get { return itemStock; }
            set
            {
                if (value >= 0)
                {
                    itemStock = value;
                }
                else
                {
                    Console.WriteLine("Error: Stock cannot be set to a negative value.");
                }
            }
        }

        public override string ToString()
        {
            return $"Item: {itemName}, Stock: {itemStock}, Price: {itemPrice}";
        }
        public class Inventory 
        {
            private List<Items> items = new List<Items>();
            public void AddItem(Items item)
            {
                items.Add(item);
                Console.WriteLine($"Added : {item}");
            }
            public void RemoveItem(Items item)
            {
                if (items.Remove(item))
                {
                    Console.WriteLine($"\nRemoved: {item}");
                }
                else
                {
                    Console.WriteLine("\nItem not found.");
                }
            }
            public void UpdateItem(Items item, int newStock, int newPrice)
            {
                item.Stock = newStock;
                item.Price = newPrice;
                Console.WriteLine($"\nUpdated: {item}");
            }

            public void DisplayInventory()
            {
                foreach (var item in items)
                {
                    Console.Write($" {item}");
                }
            }
        }

    }
}
