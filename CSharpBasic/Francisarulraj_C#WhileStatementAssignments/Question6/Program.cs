using System;
namespace Question6;
class program
{
   public static void Main(string[] args)
   {
    int value=1;
     while(value<=100)
     {
      if(value%2==0)
      {
      System.Console.WriteLine("Even numbers:"+value);
      if(value==2)
      System.Console.WriteLine("prime number:"+value);
      }
     
      else if(value%2!=0)
      {
         System.Console.WriteLine("Odd numbers:"+value);
         if(value==1)
            System.Console.WriteLine("Neither prime nor composite:"+value);
         else if(value%value==0)
         {
            System.Console.WriteLine("Prime number:"+value);

         }
      } 
      value++;
     }
    
   }
}