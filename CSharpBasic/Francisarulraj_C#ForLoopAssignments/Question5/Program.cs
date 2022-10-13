using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number of Terms:");
        int terms=int.Parse(Console.ReadLine());
        int sum=0;
        System.Console.WriteLine("The odd numbers are:");

        //for loop for terms to print odd number
        for(int i=1;i<=(terms*2);i++)
        {
            
            if(i%2!=0)
            {
                System.Console.WriteLine($"{i}");
                sum=sum+i;
            }
            
        }
        System.Console.WriteLine($"The Sum of odd Natural Number upto {terms} terms:{sum}");
        
    }
}