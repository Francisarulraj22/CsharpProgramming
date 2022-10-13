
using System;
namespace Question11;
    class program
    {
        public static void Main(string[] args)
        {
            
        System.Console.WriteLine("Enter month:");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter year:");
        int year=int.Parse(Console.ReadLine());
        int daysinmonth=System.DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("The number of days in month:"+daysinmonth);
        }
    }
            


    
