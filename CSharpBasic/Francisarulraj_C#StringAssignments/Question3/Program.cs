
using System;
namespace Question3;
    class program
    {
        public static void Main(string[] args)
        {
           string input="w3resources.com";
           char[] array=input.ToCharArray();
           Array.Reverse(array);
            for (var i = 0; i < input.Length; i++)
            {
                System.Console.WriteLine(" "+array[i]);
            }
        }
            
    }

    
