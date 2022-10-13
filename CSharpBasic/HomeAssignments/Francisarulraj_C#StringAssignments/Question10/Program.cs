
using System;
namespace Question10;
    class program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter a username:");
           string input=Console.ReadLine();
           System.Console.WriteLine("Enter password:");
           string input1=Console.ReadLine();
           if(input=="user" &&input1=="pass")
           {
                System.Console.WriteLine("Password entered successfully!");
           }
           else
           {
             System.Console.WriteLine("Incorrect password");
           }
           
        }
            
    }

    
