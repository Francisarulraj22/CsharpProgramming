using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ProductDetails
    {
        private static int s_productID = 100;

        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public double ShippingDuration { get; set; }
        
        public ProductDetails(string productName, double price, int stock, double shippingDuration)
        {
            s_productID++;
            ProductID = $"PID"+s_productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
            ShippingDuration = shippingDuration;
        }
        public ProductDetails(string productdata)
        {
            string[] productValue=productdata.Split(',');
            ProductID = productValue[0];
            ProductName = productValue[1];
            Price = double.Parse(productValue[2]);
            Stock = int.Parse(productValue[3]);
            ShippingDuration =double.Parse(productValue[4]);
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}   Product Name: {ProductName}   Available Stock: {Stock}   Price per quantity: {Price}   Shipping Duration: {ShippingDuration}");
        }
    }
}
