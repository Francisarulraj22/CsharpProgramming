using System;
namespace Question14;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        for (var i = 0; i <= number ; i++)
        {
           for (var j = 0; j < i; j++)
           {
             System.Console.Write(i);
           }
           System.Console.Write("\n");
        }
}
}