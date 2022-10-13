
using System;
namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your date and time dd/MM/yyyy hh:mm:ss format");
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss", null);
            System.Console.WriteLine(dateTime.ToShortDateString());
            System.Console.WriteLine(dateTime.ToLongDateString());
            System.Console.WriteLine(dateTime.ToLongTimeString());
            System.Console.WriteLine(dateTime.ToShortDateString());
            System.Console.WriteLine(dateTime.ToLongTimeString());
            
        }
            
    }

    
