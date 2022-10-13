using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the table you want to calculate:");
        int number=int.Parse(Console.ReadLine());
        
        for(int i=1;i<=16;i++)
        {
        System.Console.WriteLine($"{number}X{i}={number*i}");
        }

    }
}