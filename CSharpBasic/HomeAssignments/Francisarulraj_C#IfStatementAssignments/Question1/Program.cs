using System;

namespace Question1;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number:");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                System.Console.WriteLine($"{number} is an Even integer ");
            }
            else
            {
                System.Console.WriteLine($"{number} is an Odd integer ");
            }
        }
    }