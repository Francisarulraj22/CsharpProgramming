using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        double usd,eur,cny;
        System.Console.WriteLine("Enter the indian currency amount:");
        double inr=double.Parse(Console.ReadLine());
        usd=inr*1.22;
        eur=inr*1.27;
        cny=inr*8.79;
        System.Console.WriteLine($"Rate:{inr}");
        System.Console.WriteLine($"USD:{usd}");
        System.Console.WriteLine($"EUR:{eur}");
        System.Console.WriteLine($"CNY:{cny}");



    }
}