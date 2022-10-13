using System;
namespace ArrayAssignment2;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Size of an Array:");
            int size=int.Parse(Console.ReadLine());
            string[] number=new string[size];
            System.Console.WriteLine("Enter the number:"); 
            for(size=0;size<number.Length;size++)
                {  
                 number[size] =Console.ReadLine();   
                }
            System.Console.WriteLine("The values store into the array are:");   
            for(size=0;size<number.Length;size++)
            {
                System.Console.WriteLine($"{size}");
            }  
            System.Console.WriteLine("The values store into the array in reverse are :");
             for(size=number.Length-1;size>=0;size--)
            {
                System.Console.WriteLine($"{size}");
            } 
             // 


        }
    }