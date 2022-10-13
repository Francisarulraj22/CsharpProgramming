
using System;
namespace Question5;
    class program
    {
        public static void Main(string[] args)
        {
        DateTime day=new DateTime(2000,12,31);
        for(int i=0;i<=20;i++)
        {
            DateTime printyear=day.AddYears(i);
            
            if(DateTime.IsLeapYear(printyear.Year))
            {
                System.Console.WriteLine($"{printyear}: day {printyear.DayOfYear} of {printyear.Year} (Leap Year)");
            }
            else
            {
            System.Console.WriteLine($"{printyear}: day {printyear.DayOfYear} of {printyear.Year}");
            }
}
        }
            
    }

    
