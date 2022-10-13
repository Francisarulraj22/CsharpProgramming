using System;
namespace Question7;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Starting number:");
        int start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the difference :");
        int difference=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of elements :");
        int limit=int.Parse(Console.ReadLine());
        int series,sum=0;

        for (var i = start; i <=limit+difference; i++)
        {   
            if(i%2==0)
            {
                series=i+1;
                System.Console.WriteLine($"Output series:{series}");
                sum+=series;
            }
        }
        System.Console.WriteLine("Sum of Output:"+sum);


        
    }
        
    
}