using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public enum OrderStatus { Default, Ordered, Cancelled }
    public class OrderDetails
    {
        private static int s_orderId = 1000;

        public string OrderID { get; set; }

        public string CustomerID { get; set; }

        public string ProductID { get; set; }
        
        public double TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerID, string productID, double  totalPrice, DateTime purchaseDate, int quantity, OrderStatus orderStatus)
        {
            s_orderId++;
            OrderID = $"OID"+s_orderId;
            CustomerID = customerID;
            ProductID = productID;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }
        public OrderDetails(string orderdata)
        {
            string[] orderValue=orderdata.Split(','); 
            s_orderId=int.Parse(orderValue[0].Remove(0,2));
            OrderID = orderValue[0];
            CustomerID = orderValue[1];
            ProductID = orderValue[2];
            TotalPrice = int.Parse(orderValue[3]);
            PurchaseDate =DateTime.ParseExact(orderValue[4],"dd/MM/yyyy",null);
            Quantity =int.Parse(orderValue[5]);
            OrderStatus =Enum.Parse<OrderStatus>(orderValue[6]);
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine($"   Order ID: {OrderID}   Customer ID: {CustomerID}   Product ID: {ProductID}   Total Price: {TotalPrice}   Purchase Date: {PurchaseDate.ToString("dd/MM/yyyy")}   Quantity Purchased: {Quantity}   Order Status: {OrderStatus.ToString()}");
        }
    }
}
