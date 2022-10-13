
using System;

namespace Question12;
    class program
    {
        public static void Main(string[] args)
        {   
            string input="3 4 8 9 0 2 1";
            System.Console.WriteLine($"Original number of string:{input}");

            var output=input.Split(' ').Select(int.Parse).ToArray();
            var maximum=output.Max();
            var minimum=output.Min();
            System.Console.WriteLine($"Maximum:{maximum} and Minimum:{minimum}");
       }

    }
