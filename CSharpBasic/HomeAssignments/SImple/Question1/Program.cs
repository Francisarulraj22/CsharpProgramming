using System;
namespace Question1;
class program
{
   public static void Main(string[] args)
   {
     System.Console.WriteLine("Enter the inches:");
     double inches=double.Parse(Console.ReadLine());
     double centimeters=inches*2.54;
    System.Console.WriteLine($"Inches to Centimeters:{centimeters} cm");

   }
}