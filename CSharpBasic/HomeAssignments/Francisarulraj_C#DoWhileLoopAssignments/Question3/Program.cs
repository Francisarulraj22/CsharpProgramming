using System;
namespace Question3;

class program
    {
        public static void Main(string[] args)
        {
            int f1=0,f2=1,f3=0;
            int temp=0;
            
            System.Console.WriteLine("Enter Number:");
            int number=int.Parse(Console.ReadLine());;
            System.Console.WriteLine($"fibonacci series upto {number} terms"); 
            System.Console.WriteLine($"Fibonacci series:");
            System.Console.WriteLine($"{0}\n{1}");
            do{    
                f3=f1+f2;
                f1=f2;
                f2=f3;
                System.Console.WriteLine(f3);
                temp++;
                       
            }while(temp<=number);

        }
    }