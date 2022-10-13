using System;
namespace Question3;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Number of terms:");
            int n=int.Parse(Console.ReadLine());
            int i=0;
            int f1=0;
            int f2=1;
            int f3=0;
            System.Console.WriteLine($"Here is the fibonacci series of {n}");
            System.Console.WriteLine(+f1+"\n"+f2+"");
            while(i<=n)
            {
                
                f3=f1+f2;
                System.Console.WriteLine($"{f3} ");
                f1=f2;
                f2=f3;
                i++;

            }
        }
    }