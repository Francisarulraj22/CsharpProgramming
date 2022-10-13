using System;
namespace Question3;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number elements to be stored in array:");
            int size=int.Parse(Console.ReadLine());
            int[] number=new int[size];
             int temp=0;
            for(size=0;size<number.Length;size++)
                {  
                System.Console.WriteLine("Enter the number:"); 
                number[size] =int.Parse(Console.ReadLine()); 
                System.Console.WriteLine($"Element-{size}:"); 
                temp+=number[size];

                }
                System.Console.WriteLine("Sum of all elements in array"+temp);
        }

    }