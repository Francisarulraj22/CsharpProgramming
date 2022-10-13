using System;
namespace Question5;
class program
{
   public static void Main(string[] args)
   {
    System.Console.WriteLine("Enter the number:");
    int number=int.Parse(Console.ReadLine());
    prime();
    void prime()
    {
      if(number==1)
      {
         System.Console.WriteLine("1 is Neither prime nor composite");

      }
      else if(number==2)
      System.Console.WriteLine("2 is Even prime number");
      else if(number%number==0 && (number/1)==number)
      {
         System.Console.WriteLine($"{number} is Prime number");
      }

    }
   } 


}