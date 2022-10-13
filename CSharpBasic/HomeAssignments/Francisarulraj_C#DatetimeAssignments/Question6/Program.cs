using System;
namespace Question6;
    class program
    {
        public static void Main(string[] args)
        {
            DateTime today=DateTime.Now;
            System.Console.WriteLine($"Today Date:{today}");
            DateTime day=today.AddDays(40);
            System.Console.WriteLine($"{day.DayOfWeek}");

        }
    }