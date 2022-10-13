using System;
namespace Question4;

class program
    {
        public static void Main(string[] args)
        {
            bool check;
            int number;
            do{
                   
                 System.Console.WriteLine("Enter Number:");
                 
                check=int.TryParse(Console.ReadLine(),out number);
                 
            }while(check==false);
            System.Console.WriteLine(number); 
        }
    }
