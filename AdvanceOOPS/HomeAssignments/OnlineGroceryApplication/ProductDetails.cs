using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryApplication
{
    public class ProductDetails
    {
        private static int s_productid=100;

        
        public string ProductID { get; set; }
        public string ProductName  { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName, int quantityAvailable, double pricePerQuantity)
        {
            s_productid++;
            ProductID ="PID"+s_productid;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
        public ProductDetails(string datas)
        {
            string[] values = datas.Split(",");
            s_productid= int.Parse(values[0].Remove(0,3));
            ProductID = values[0];
            ProductName = values[1];
            QuantityAvailable = int.Parse(values[2]);
            PricePerQuantity = double.Parse(values[3]);
        }
        

        
    }//ProductID, ProductName, QuantityAvailable, PricePerQuantity
}