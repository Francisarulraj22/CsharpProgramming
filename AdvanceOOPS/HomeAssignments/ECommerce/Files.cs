using System.IO;

namespace ECommerce
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Ecommerce"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Ecommerce");
            }
            if(!File.Exists("Ecommerce/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Ecommerce/CustomerDetails.csv");
            }
            if(!File.Exists("Ecommerce/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Ecommerce/ProductDetails.csv");
            }
            if(!File.Exists("Ecommerce/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Ecommerce/OrderDetails.csv");
            }

        }
        public static void ReadFile()
        {
            string[] customer=File.ReadAllLines("Ecommerce/CustomerDetails.csv");
            foreach (var data in customer)
            {
                CustomerDetails customer1 =new CustomerDetails(data);
                Program.CustomerList.Add(customer1);
            }
            string[] order=File.ReadAllLines("Ecommerce/OrderDetails.csv");
            foreach (var data in order)
            {
                CustomerDetails orderproduct =new CustomerDetails(data);
                Program.OrderList.Add();
                
            }

        }
        public static void WriteToFiles()
        {
            string[] CustomerDetails=new string[Program.CustomerList.Count];
            for (var i = 0; i < Program.CustomerList.Count; i++)
            {
                CustomerDetails[i]=Program.CustomerList[i].CustomerID+","+Program.CustomerList[i].Name+","+Program.CustomerList[i].City+","+Program.CustomerList[i].Mobile+","+Program.CustomerList[i].WalletBalance+","+Program.CustomerList[i].Mail;
            }
            File.WriteAllLines("Ecommerce/CustomerDetails.csv",CustomerDetails);
        }
        public static void UpdateFile()
        {
            string[] CustomerDetails=new string
        }
    


        
    }
}