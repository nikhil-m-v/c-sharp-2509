using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    // Define the OrderStatus enumeration
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public Order(int orderId, OrderStatus status)
        {
            OrderId = orderId;
            Status = status;
        }
        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Order ID: {OrderId}, Status: {Status}");
        }
    }
}
