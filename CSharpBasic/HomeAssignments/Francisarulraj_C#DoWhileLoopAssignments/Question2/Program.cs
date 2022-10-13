using System;
namespace Question2;

class program
    {
        public static void Main(string[] args)
        {
            
            int number,sum=0;
            do{    
                System.Console.WriteLine("Enter Number:");
                number=int.Parse(Console.ReadLine());
                if(number>=0)
                {
                    sum+=number;
                }
            }while(number>=0);
            System.Console.WriteLine("The Sum is "+sum);
        }
    }