using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillroll;

    public class EbBillCalculation
    {
        private static int s_meterId=1001;
        public string Meterid { get; set; }
        
        
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailId { get; set; }
        

        public EbBillCalculation(string username,long phonenumber,string mailid)
        {
            MailId="EB"+s_meterId;
            UserName=username;
            PhoneNumber=phonenumber;
            MailId=mailid;
        }
        public void CalculateAmount()
        {
            System.Console.WriteLine("Enter Total unit Used:");
            int unit=int.Parse(System.Console.ReadLine());
            if(unit<100)
            {
               
                System.Console.WriteLine($"unit Consumed:{unit}");
                System.Console.WriteLine("100 Units Free of Cost");
            }
           
            
            else if(unit>=100&&unit<300)
            {
              
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*3;
                System.Console.WriteLine("Amount Charges @Rs.3:"+totalAmount);
                System.Console.WriteLine("Net Amount  :"+totalAmount);

            }
            else if(unit>=200&&unit<400)
            {
               
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*5;
                System.Console.WriteLine("Amount Charges @Rs.5:"+totalAmount);
                System.Console.WriteLine("Net Amount  :"+totalAmount);

            }
            else if(unit>=600)
            {
            
                double totalAmount=unit*6.00;
                System.Console.WriteLine("Amount Charges @Rs.2.00:"+totalAmount);
                System.Console.WriteLine("Net Amount :"+totalAmount);
        }
        
        
        
        
        
        
        
        
    }
}