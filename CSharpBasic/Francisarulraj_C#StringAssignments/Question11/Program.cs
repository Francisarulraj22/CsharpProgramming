
using System;
using System.Collections.Generic;
namespace Question11;
    class program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter the string:");
           string input=Console.ReadLine();
           var after=new HashSet<char>(input);
           System.Console.WriteLine("After removing Duplicate characters:");
           foreach (var removedublicate in after)
           {
            
            System.Console.WriteLine(removedublicate);
           }

                   }
            
    }

    
