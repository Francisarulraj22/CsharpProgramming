
using System;
namespace Delegate1;
    public delegate int Calculator(int n);
    class program
    {
     
     static double Sum(int a, int b)
     {
        return a+b;
     }
     static double Subract(int a, int b)
     {
        return a-b;
     }
     public static double Calculator(Func<int,int,double> operation,int x,int y)
     {
        return operation(x,y);     
     }
     public static void Main(string[] args)
     {
        System.Console.WriteLine(Calculator(Sum,89,90));
        System.Console.WriteLine(Calculator(Subract,98,8));
        
     }
            
    }

    
