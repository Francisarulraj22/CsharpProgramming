using System;
namespace Question8;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Speed:");
        double speed=double.Parse(Console.ReadLine());
        if(speed<10)
        {
            System.Console.WriteLine("Slow");

        }
        else if(speed<50&&speed>=10)
        {
            System.Console.WriteLine("Average");
        }
        else if(speed<150&&speed>=50)
        {
            System.Console.WriteLine("fast");
        }
         else if(speed<1000&&speed>=150)
        {
            System.Console.WriteLine("Ultra fast");
        }
         else if(speed>=1000)
        {
            System.Console.WriteLine("Extremely fast");
        }
    }
}