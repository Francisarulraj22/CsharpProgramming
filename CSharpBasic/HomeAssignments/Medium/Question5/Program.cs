using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the limit:");
        int limit=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Leapyears from to {limit}");
        for (var i = 0; i <= limit; i++)
        {
            if(i%4==0)
            {
                System.Console.WriteLine(i);
            }
        }
    }
        
    
}