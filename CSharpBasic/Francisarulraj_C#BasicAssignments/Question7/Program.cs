using System;

    namespace Question7;
        class program
        {
            public static void Main(string[] args)
            {
              Console.WriteLine("a=");
              int a=int.Parse(Console.ReadLine());
              Console.WriteLine("b=");
              int b=int.Parse(Console.ReadLine());
              int squareA=a*a;
              int squareB=b*b;
              int sumAb=a+b;
              int righSide=sumAb*sumAb;
              int leftSide=squareA+(2*a*b)+squareB;
              if (leftSide==righSide)
              {
              System.Console.WriteLine($"output:{leftSide}");
              }



              
                
                
            }
        }