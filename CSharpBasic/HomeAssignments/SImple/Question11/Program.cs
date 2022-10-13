using System;
namespace Question11;
class  program
{
    public static void Main(string[] args)
    {
        int xpowery=0;
        System.Console.WriteLine("Enter x value:");
        int x=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter y value:");
        int y=int.Parse(Console.ReadLine());
        for (int i = 0; i < y; i++)
        {
            xpowery=x*x;
        }
        System.Console.WriteLine("XpowerY="+xpowery);
        
    }
}