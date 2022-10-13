using System;
namespace Question1;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number:");
        int value1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        int value2=int.Parse(Console.ReadLine());
        Addition(value1,value2);
        Subraction(value1,value2);
        Multplication(value1,value2);
        Division(value1,value2);

            void Addition(int value1, int value2)
            {
              int addition=value1+value2;
              System.Console.WriteLine("Addition="+addition);
            }
            void Subraction(int value1, int value2)
            {
              int subraction=value1-value2;
             System.Console.WriteLine("Subration="+subraction);
            }
            void Multplication(int value1, int value2)
            {
              int multiplication=value1*value2;
              System.Console.WriteLine("Muliplication="+multiplication);
            }
            void Division(int value1, int value2)
            {
              int division=value1/value2;
              System.Console.WriteLine("Division="+division);
            }

    }
}
