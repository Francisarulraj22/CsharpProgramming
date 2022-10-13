using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByNumberofArg
{
    public class Program
    {
        static void Display(int number)
        {
            System.Console.WriteLine("Arguments : "+number);
        }
        static void Display(int number1,int number2)
        {
            System.Console.WriteLine("Arguments : "+number1+" And "+number2);
        }

        static void Main(string[] args)
        {
           Display(100);
           Display(90,30);
           System.Console.WriteLine();
        }
    }
}