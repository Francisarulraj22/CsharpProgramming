using System;
namespace Question5;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the salary:");
            int salary=int.Parse(Console.ReadLine());
            double percentage10=salary/10;
            double tax5Percentage=percentage10/2;
            double annualSalary=salary+percentage10+percentage10-tax5Percentage;
            System.Console.WriteLine($"Annual Income:{annualSalary}");


        }
    }