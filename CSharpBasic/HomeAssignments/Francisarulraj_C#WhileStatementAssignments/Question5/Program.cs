using System;
namespace Question5;
class program
{
   public static void Main(string[] args)
   {
     int number=0;
     System.Console.WriteLine("Enter digit:");
     int digit=int.Parse(Console.ReadLine());
     int sum=0;
     int i=1;
     while(i<=digit)
     {
        System.Console.WriteLine("Enter number:");
         number=int.Parse(Console.ReadLine());
         sum=sum+number;
         i++;
     }
     System.Console.WriteLine($"Sum of digits of {number} is {sum}");

   }
}