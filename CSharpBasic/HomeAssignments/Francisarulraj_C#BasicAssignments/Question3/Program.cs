using System;

namespace Question3;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Celsius:");
            Int32 celsius=int.Parse(Console.ReadLine());
            float number1= 9 ,number2=5;
            float divide=number1/number2;
            float fahrenheit=(celsius*divide)+32;
            int kelvin=celsius+273;
            Console.WriteLine($"Kelvin={kelvin}");
            Console.WriteLine($"Fahrenheit={fahrenheit}");

        }
    }