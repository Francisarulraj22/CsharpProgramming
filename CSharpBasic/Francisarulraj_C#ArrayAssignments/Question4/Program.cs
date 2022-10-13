using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number elements in array:");
            int size=int.Parse(Console.ReadLine());
            int[] number=new int[size];
            for(int i=0;i<size;i++)
                {  
                System.Console.WriteLine("Enter the number:"); 
                number[i] =int.Parse(Console.ReadLine()); 
                System.Console.WriteLine($"Element-{size}:");
                }
                int maximum=number[0];
                int minimum=number[0];
                for(int i=0;i<size;i++)
                {  
                if(number[i]>maximum)
                {
                    maximum=number[i];
                     
                } 
                if(number[i]<minimum)
                {
                    minimum=number[i];
                     
                } 
                
                }
                System.Console.WriteLine("Maximum element is:"+maximum);
                System.Console.WriteLine("Minimum element is:"+minimum);
               
         }
            
    }

    
