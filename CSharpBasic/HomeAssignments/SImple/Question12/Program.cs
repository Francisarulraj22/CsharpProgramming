using System;
namespace Question12;
class program
{
    public static void Main(string[] args)
    {
        int sum=0,square;
        for (var i = 0; i < 100; i++)
        {
            if(i%2!=0)
            {
                square=i*i;
                sum+=square;
               
            }
            
        }
        System.Console.WriteLine("Sum of Square Odd Values from 1 to 90: "+sum);

        
    }
}