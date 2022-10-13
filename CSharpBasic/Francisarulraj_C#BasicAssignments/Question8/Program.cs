using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the value in meters:");
            double meters=double.Parse(Console.ReadLine());
            double cm=meters*100;
            double inch=39.3*meters;
            double foot=12*meters;
            double mile=0.0006213715277778*meters;
            System.Console.WriteLine("Cm="+cm);
            System.Console.WriteLine("Inch="+inch);
            System.Console.WriteLine("Foot="+foot);
            System.Console.WriteLine("Mile="+mile);
            
        }
    }
