using System;
namespace Question9;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your Date dd/MM/yyyy format");
            DateTime datetime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime leapyearafter=datetime.AddYears(1);
            if(DateTime.IsLeapYear(datetime.Year))
            {
            System.Console.WriteLine($"{datetime.Year} is Leap year");
            }
            System.Console.WriteLine($"One year from {datetime} is {leapyearafter}");
           

        }
    }
            
    

    
