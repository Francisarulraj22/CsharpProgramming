using System;

namespace Question9;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input speed in km/hr:");
            int speed=int.Parse(Console.ReadLine());
            Console.WriteLine("Time in seconds:");
            int time=int.Parse(Console.ReadLine());
            double num1=5,num2=18;
            double div=num1/num2;
            double distanceTravelled=speed*time*div;
            
            Console.WriteLine($"Input speed:{speed}km/hr");
            System.Console.WriteLine($"Time:{time}sec");
            Console.WriteLine($"Output{distanceTravelled}Metres");
        }
    }
