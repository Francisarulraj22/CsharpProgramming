
using System;
namespace Question;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your date and time dd/MM/yyyy hh:mm:ss format");
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss", null);
              System.Console.WriteLine("Year"+dateTime.Year);
              System.Console.WriteLine("month:"+dateTime.Month);
              System.Console.WriteLine("day:"+dateTime.ToString("dd"));
              System.Console.WriteLine("hour:"+dateTime.ToString("hh"));
              System.Console.WriteLine("minute:"+dateTime.ToString("hh"));
              System.Console.WriteLine("second:"+dateTime.ToString("mm"));
              System.Console.WriteLine("millisecond"+dateTime.ToString("ss"));
           
        }
            
    }

    
