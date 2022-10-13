using System;

namespace Question6;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Price:");
            int price=int.Parse(Console.ReadLine());
            double totalAmount=price+(price*0.18);
            Console.WriteLine($"Price-{price}");
            Console.WriteLine($"Total:{totalAmount}");
        }
    }
