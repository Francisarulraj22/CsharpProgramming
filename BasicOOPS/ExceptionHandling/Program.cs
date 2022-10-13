
using System;
namespace ExceptionHandling;
    class program
    {
        public static void Main(string[] args)
        {
         
            
           try
           {
            System.Console.WriteLine("Enter input1:");
            int input1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter input2:");
            int input2=int.Parse(Console.ReadLine());
            int output=input1/input2;
           }
           catch (System.DivideByZeroException dividebyzero)
           {
            System.Console.WriteLine("An Exception Occured:{0}",dividebyzero.Message);
            System.Console.WriteLine("An Exception Occured:{0}",dividebyzero.StackTrace);
           }
           catch(System.FormatException inputformat)
           {
            System.Console.WriteLine("An Exception Occured:{0}",inputformat.Message);
            System.Console.WriteLine("An Exception Occured:{0}",inputformat.StackTrace);
           }
           finally
           {
                 System.Console.WriteLine("Completed");
           }
           
           
        }
        
            
    }

    
