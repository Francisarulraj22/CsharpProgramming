
using System;
namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
           string input="w3resources.com";
           char[] array=input.ToCharArray();
           
            for (var i = 0; i < input.Length; i++)
            {
                System.Console.WriteLine(" "+array[i]);
            }
        }
            
    }

    
