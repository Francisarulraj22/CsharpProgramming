
using System;
namespace Question;
    class program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter the string:");
           string input=Console.ReadLine();
           System.Console.WriteLine("Enter the Sub string:");
           string input1=Console.ReadLine();
           if(input.Contains(input1))
           {
                System.Console.WriteLine("The substring exists in the string");
           }
           else
           {
             System.Console.WriteLine("The substring Not exists in the string");
           }
           
        }
            
    }

    
