using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number elements in array:");
            int size=int.Parse(Console.ReadLine());
            int[] number=new int[size];
            int [] evenArray=new int[size];
            int[] oddArray=new int[size];
            for(int i=0;i<size;i++)
                {  
                System.Console.WriteLine("Enter the number:"); 
                number[i] =int.Parse(Console.ReadLine()); 
                
                System.Console.WriteLine($"Element-{i}:");
                }
                int even=number[0];
                int odd=number[0];
                
                
                for(int i=0;i<size;i++)
                {  
                    
                if(number[i]%2==0)
                    {
                        evenArray[i]=number[i];
                        System.Console.WriteLine($"The Even elements are:");
                        System.Console.WriteLine(evenArray[i]);
                        
                    } 
                    else 
                    {
                        oddArray[i]=number[i];
                        System.Console.WriteLine($"The Odd elements are:");
                        System.Console.WriteLine(oddArray[i]);
                        
                    } 
            
                }
                    
         }
            
    }

    
