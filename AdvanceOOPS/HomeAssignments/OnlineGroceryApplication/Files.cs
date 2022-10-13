using System.IO;

namespace OnlineGroceryApplication
{
    public static class Files
    {
        
        public static void Create()
        {
            if(!Directory.Exists("OnlineGroceryryApplication"))
            {
                Directory.CreateDirectory("OnlineGroceryryApplication");
            }
            else{
                System.Console.WriteLine("Found");
            }

            if(!File.Exists("OnlineGroceryryApplication/CustomerDetails.csv"))
            {
                File.Create("OnlineGroceryryApplication/CustomerDetails.csv");
            }
            else
            {
                System.Console.WriteLine("Found");
            }
            if(!File.Exists("OnlineGroceryryApplication/ProductDetails.csv"))
            {
                File.Create("OnlineGroceryryApplication/ProductDetails.csv");
            }
            else
            {
                System.Console.WriteLine("Found");
            }
            if(!File.Exists("OnlineGroceryryApplication/OrderDetails.csv"))
            {
                File.Create("OnlineGroceryryApplication/OrderDetails.csv");
            }
            else
            {
                System.Console.WriteLine("Found");
            }
            if(!File.Exists("OnlineGroceryryApplication/BookingDetails.csv"))
            {
                File.Create("OnlineGroceryryApplication/BookingDetails.csv");
            }
            else
            {
                System.Console.WriteLine("Found");
            }
        }
        public static void ReadFile()
        {
            string[] array=File.ReadAllLines("OnlineGroceryryApplication/CustomerDetails.csv");
            foreach (var customers in array)
            {
                CustomerDetails tempObject=new CustomerDetails(customers);
                Operations.customerList.Add(tempObject);  
            }
            string[] array1=File.ReadAllLines("OnlineGroceryryApplication/BookingDetails.csv");
            foreach (var bookings in array1)
            {
                BookingDetails tempbookobject=new BookingDetails(bookings);
                Operations.bookingList.Add(tempbookobject);
            }
            string[] array3=File.ReadAllLines("OnlineGroceryryApplication/ProductDetails.csv");
            foreach (var products in array3)
            {
                ProductDetails tempProduct=new ProductDetails(products);
                Operations.productList.Add(tempProduct);
            }
            string[] array4=File.ReadAllLines("OnlineGroceryryApplication/OrderDetails.csv");
            foreach (var orders in array4)
            {
               OrderDetails tempOrder=new OrderDetails(orders);
               Operations.orderList.Add(tempOrder);
            }
           
            
        }
        public static void WriteFile()
        {
            string[] array=new string[Operations.customerList.Count];
            int i=0;
            foreach (CustomerDetails customer in Operations.customerList)
            {
                array[i]=customer.CustomerID+","+customer.Name+","+customer.FatherName+","+customer.WalletBalance+","+customer.Gender+","+customer.MobileNumber+","+customer.DateOfBirth+","+customer.MailID;
                i++;
            }
            File.WriteAllLines("OnlineGroceryryApplication/CustomerDetails.csv",array);

            string[] array1=new string[Operations.bookingList.Count];
            i=0;
            foreach (BookingDetails booking in Operations.bookingList)
            {
                array1[i]=booking.BookingID+","+booking.CustomerID+","+booking.TotalPrice+","+booking.BookingStatus;
                i++;
            }
            File.WriteAllLines("OnlineGroceryryApplication/BookingDetails.csv",array1);

            string[] array2 = new string[Operations.orderList.Count];
            i=0;
            foreach (OrderDetails orders in Operations.orderList)
            {
                array2[i]=orders.OrderID+","+orders.ProductID+","+orders.BookingID+","+orders.PurchaseCount+","+orders.PriceOfOrder;
                i++;
            }
            File.WriteAllLines("OnlineGroceryryApplication/OrderDetails.csv",array2);
            
            string[] array3 = new string[Operations.orderList.Count];
            i=0;
             foreach (ProductDetails products in Operations.productList)
            {
                array3[i]=products.ProductID+","+products.ProductName+","+products.QuantityAvailable+","+products.QuantityAvailable;
                i++;
            }
            File.WriteAllLines("OnlineGroceryryApplication/ProductDetails.csv",array3);

            
        }
    }
}