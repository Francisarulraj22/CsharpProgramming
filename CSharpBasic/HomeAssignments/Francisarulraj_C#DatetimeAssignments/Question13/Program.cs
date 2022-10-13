
using System;
namespace Question13;
    class program
    {
        public static void Main(string[] args)
        {
            
        System.Console.WriteLine("Enter month:");
        int month=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter year:");
        int year=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter day:");
        int day=Convert.ToInt32(Console.ReadLine());
        DateTime date=new DateTime(year,month,day);
        System.Console.WriteLine("The formated Date is:"+date.ToString("dd/MM/yyyy"));
        DateTime lastweek=new DateTime(date.Year,date.Month,1);
        if(diff<0)
        {
            diff+=7;
        }
        else{
            
        }
        }
    }
            


    
