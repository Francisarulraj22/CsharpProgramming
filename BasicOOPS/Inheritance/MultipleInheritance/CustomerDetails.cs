using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerId=3000;
        public string CustomerID { get; set; }
        public double Balalnce { get; set; }
        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phonenumber):base(aid,name,fatherName,gender,phonenumber)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;
        }
        public void Recharger()
        {
            System.Console.WriteLine("Enter the you Want to Recharge:");
            Balalnce+=double.Parse(Console.ReadLine());

        }
        public void ShowDetail()
        {
            System.Console.WriteLine("CustomerID:"+CustomerID);
            ShowDetails();
            Recharger();
            System.Console.WriteLine("Balance:"+Balalnce);
        }
        
    }
}