using System;
namespace OnlineGroceryApplication
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        //: CustomerID, WalletBalance

        private static int s_customerid=1000;

        public  string CustomerID { get;  }
        public double WalletBalance { get; set; }
 
        public CustomerDetails(string name, string fatherName,double WalletBalance, Gender gender, long mobileNumber, DateTime dateOfBirth, string mailID):base( name, fatherName, gender, mobileNumber, dateOfBirth, mailID)
        {
            s_customerid++;
            CustomerID ="CID"+s_customerid;    
        }
        public CustomerDetails(string data)
        {
            string[] values=data.Split(",");
            s_customerid=int.Parse(values[0].Remove(0,3));
            CustomerID =values[0];
            Name=values[1];
            FatherName=values[2];
            WalletBalance=double.Parse(values[3]);
            Gender=Enum.Parse<Gender>(values[4],true);
            MobileNumber=long.Parse(values[5]);
            DateOfBirth=DateTime.Parse(values[6]);
           
            MailID=values[7];
                
        }
        

       
        public void ShowCustomerDetails()
        {
         
            System.Console.WriteLine($"{CustomerID}\t{WalletBalance}\t{Name}\t{FatherName}\t{Gender}\t{MobileNumber}\t{DateOfBirth.ToString("dd/MM/yyyy")}\t{MailID}");
                
        }
        public void WalletRecharge()
        {
                System.Console.WriteLine("Enter The Amount To Recharge:");
                double Amount=double.Parse(Console.ReadLine());
                 
                WalletBalance+=Amount;
                System.Console.WriteLine("Wallet Recharged"+WalletBalance);
        }

        
    }
}