using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByType
{
    public class Program
    {
        static void Display(int number)
        {
            System.Console.WriteLine("Int Type : "+number);
        }
        static void Display(string name)        //different Data Types ByTypePolymorphism
        {
            System.Console.WriteLine("String type : "+name);
        }

        static void Main(string[] args)
        {
           Display(100);
           Display("Francisarulraj");
           System.Console.WriteLine();
        }
    }
}