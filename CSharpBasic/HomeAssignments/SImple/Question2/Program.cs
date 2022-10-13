using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        double area,perimeter;
        System.Console.WriteLine("Enter the radius:");
        double radius=double.Parse(Console.ReadLine());
        perimeter=2*3.14*radius;
        area=3.14*(radius*radius);
        System.Console.WriteLine($"Area={area}");
        System.Console.WriteLine($"Perimeter={perimeter}");
    }
}