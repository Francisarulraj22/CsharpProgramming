using System;
namespace Question1;

class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Number:");
            int number;
            string condition; 
            do{    
                 
                number=int.Parse(Console.ReadLine());
                if(number%2==0)
                {
                    System.Console.WriteLine("Given number is Even");
                }
                else
                {
                    System.Console.WriteLine("Given number is Odd");
                }
                System.Console.WriteLine("--You want to continue---\nYes/No");
                condition=Console.ReadLine().ToLower();    
            }while(condition=="yes");
        }
    }