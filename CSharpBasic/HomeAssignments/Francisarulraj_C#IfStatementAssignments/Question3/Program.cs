using System;
namespace Question3;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Year:");
            int year=int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                System.Console.WriteLine($"{year} is an Leap year");
            }
            else
            {
                System.Console.WriteLine($"{year} is Not Leap year .");
            }
        }
    }