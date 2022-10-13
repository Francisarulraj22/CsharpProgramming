
using System;
namespace Question11;
    class program
    {
        public static void Main(string[] args)
        {
        DateTime today=DateTime.Now;
        System.Console.WriteLine("The date of Today"+today.ToShortDateString());
        System.Console.WriteLine("The twelve months are:");    
            for (var i = 0; i <12; i++)
            {
            DateTime month=today.AddMonths(i);
            System.Console.WriteLine(month.ToString("MMMM"));
            }
        }
    }
            


    
