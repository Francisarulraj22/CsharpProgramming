
using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
           string input="This is w3resources.com";
            int count=0;
            for (var i = 0; i < input.Length-1; i++)
            {
            if(input[i]==' ')
            {
                count++;
            }       
            }
            count++;
            System.Console.WriteLine($"Total words in string:{count}");
        }
            
    }

    

