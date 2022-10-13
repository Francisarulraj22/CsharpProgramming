using System;
namespace Question6;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number elements in array:");
            int size=int.Parse(Console.ReadLine());
            int[] number=new int[size];
            int tempvalue;
            for(int i=0;i<size;i++)
                {  
                System.Console.WriteLine("Enter the number:"); 
                number[i] =int.Parse(Console.ReadLine()); 
                System.Console.WriteLine($"Element-{size}:");
                }
                for(int i=0;i<size;i++)
                {  
                    for (int j = i+1; j < size; j++)
                    {
                         if(number[i]<number[j])
                            {
                                tempvalue=number[i];
                                number[i]=number[j];
                                number[j]=tempvalue;
                            }
                    
                    }
                    
               
                
                }
               System.Console.WriteLine("Sorted in Ascending order:");
               Array.Reverse(number);

                    foreach (int items in number)
                        {
                            System.Console.WriteLine(items);
                        }
         }
            
    }

    
