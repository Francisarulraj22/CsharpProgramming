using System;

namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("number1:");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("number2:");
            int number2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("number3:");
            int number3=int.Parse(Console.ReadLine());

            if(number1>number2)
            {
                System.Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if(number2<number3)
            {
                System.Console.WriteLine("The 3rd Number is the greatest among three");
            }
            else
            {
                System.Console.WriteLine("The 2nd Number is the greatest among three");
            }
        }
    }
