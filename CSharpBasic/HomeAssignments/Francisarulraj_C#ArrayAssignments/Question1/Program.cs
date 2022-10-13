using System;
namespace ArrayAssignment1;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Size of an Array:");
            int size=int.Parse(Console.ReadLine());
            string[] number=new string[size];
            System.Console.WriteLine("Enter the numbers:"); 
            for(size=0;size<number.Length;size++)
                {
                  
                 number[size]=Console.ReadLine();   
                }

                foreach(string numbercollection in number)
                {
                     System.Console.WriteLine($"element-{numbercollection}"); 
                }
        


        }
    }
