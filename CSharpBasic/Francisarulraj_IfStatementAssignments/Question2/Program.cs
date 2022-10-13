using System;

namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your age:");
            int age=int.Parse(Console.ReadLine());
            if(age>=18)
            {
                System.Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                System.Console.WriteLine("Not Eligible for casting your vote.");
            }
        }
    }
