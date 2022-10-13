using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        int f1=0,f2=1,f3=0;
       System.Console.WriteLine("Enter number of terms to display:");
       int terms=int.Parse(Console.ReadLine());
       System.Console.WriteLine("Here is Fibonacci series:");
       System.Console.WriteLine($"{f1}\n{f2}");
       for (var i = 0; i <terms-2; i++)
       {
        f3=f1+f2;
        f2=f3;
        f1=f2;
        System.Console.WriteLine($"{f3}");
       }

    }
        
    
}