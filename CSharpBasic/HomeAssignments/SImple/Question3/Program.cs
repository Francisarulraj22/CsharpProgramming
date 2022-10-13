using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        double fahrenheit,celcius,div;
        System.Console.WriteLine("Enter Celcius:");
        celcius=double.Parse(Console.ReadLine());
        div=9/5;
        fahrenheit=celcius*div+32;
        System.Console.WriteLine($"Fahrenheit:{fahrenheit} F");
        
    }
}