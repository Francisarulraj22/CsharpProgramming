
using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine(" Enter your date dd/MM/yyyy format");
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            
            System.Console.WriteLine("The day of the week is "+dateTime.DayOfWeek);  
           
        }
            
    }

    
