using System;
namespace Question13;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        int multiplication;
        for (var i = 0; i <=20 ; i++)
        {
           multiplication=number*i;
           System.Console.WriteLine($"{number} * {i} = {multiplication}");
        }
    }    
}