using System;
using System.Collections.Generic;
namespace EbBillroll;

class program
{
    public static void Main(string[] args)
    {
        List<EbBillCalculation> EbbilList=new List<EbBillCalculation>();
        System.Console.WriteLine("UserName:");
        string name1=Console.ReadLine();
        System.Console.WriteLine("Phone Number:");
        long phonenumber1=int.Parse(Console.ReadLine());
        string mailid1=Console.ReadLine();
       
        EbBillCalculation ebbill=new EbBillCalculation(name1,phonenumber1,mailid1);
        ebbill.CalculateAmount();
    }
        
    
}