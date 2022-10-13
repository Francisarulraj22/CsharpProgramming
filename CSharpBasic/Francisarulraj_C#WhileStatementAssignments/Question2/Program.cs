using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Count-");
        int count=int.Parse(Console.ReadLine());
        int number=0;
        int sum=0;
        while(number<count)
        {
            System.Console.WriteLine("Enter number:");
            int value=int.Parse(Console.ReadLine());
            int square=value*value;
            sum=square+sum;
            number++;    
        }
        System.Console.WriteLine($"Sum of Square:{sum}");
    }
}