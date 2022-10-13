using System;

namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Physics:");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Chemistry:");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Mathematics:");
            int mathematics=int.Parse(Console.ReadLine());
            int sum=physics+mathematics+chemistry;
            double avg=sum/3;
            if(avg>=75)
            {
                System.Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                System.Console.WriteLine("The candidate is Not eligible for admission.");
            }
        }
    }


