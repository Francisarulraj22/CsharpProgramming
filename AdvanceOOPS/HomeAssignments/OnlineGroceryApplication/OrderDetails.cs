using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryApplication
{
    public class OrderDetails
    {
        //OrderID, BookingID, ProductID, PurchaseCount, PriceOfOrder
        private static int s_orderId=100;

     
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public string BookingID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }
        
        public OrderDetails(string productID,string bookingID, int purchaseCount, double priceOfOrder)
        {
            s_orderId++;
            OrderID ="OID"+s_orderId;
            ProductID = productID;
            BookingID=bookingID;
            PurchaseCount = purchaseCount;
          
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(",");
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderID =values[0];
            ProductID =values[1];
            BookingID= values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOfOrder = double.Parse(values[4]);
        }
        public void ShowOrderDetails()
        {
            
          
          System.Console.WriteLine($"{OrderID}\t{ProductID}\t{BookingID}\t{PurchaseCount}\t{PriceOfOrder}");
     
        }


    }
}