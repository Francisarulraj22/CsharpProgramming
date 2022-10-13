using System;
namespace Question15;
class program
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        for (int i = number; i <= number; i++)
        {
            if(i==1)
            System.Console.WriteLine("neither composite or nor prime");
                else if(i%2!=0 && i/i==0 ||i==2)
                {

                    System.Console.WriteLine("It is prime number");
                }
                else if(i%2==0)
                {
                System.Console.WriteLine("It is not prime");
                }
                
            
        }
         
        
    
    }
}