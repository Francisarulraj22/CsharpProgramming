using System;

namespace Question4;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius:");
            int radius=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            int height=int.Parse(Console.ReadLine());
            //Volume of Cylinder
            //3.14* r2 h
            int radius2=radius*radius;
            double pi = 3.14;
            double volume=pi*radius2*height;
            Console.WriteLine($"Volume={volume}");

        }
    }