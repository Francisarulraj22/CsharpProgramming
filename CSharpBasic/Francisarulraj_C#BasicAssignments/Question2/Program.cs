using System;

namespace Question2;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            Int32 number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            Int32 number2=int.Parse(Console.ReadLine());
            //add
            int addition=number1+number2;
            //sub
            int subract=number1-number2;
            //mul
            int multiplication= number1*number2;
            //div
            float modulodivision=number1%number2;
            Console.WriteLine($"{number1}+{number2}={addition}");
            Console.WriteLine($"{number1}-{number2}={subract}");
            Console.WriteLine($"{number1}*{number2}={multiplication}");
            Console.WriteLine($"{number1}%{number2}={modulodivision}");
        }
    }