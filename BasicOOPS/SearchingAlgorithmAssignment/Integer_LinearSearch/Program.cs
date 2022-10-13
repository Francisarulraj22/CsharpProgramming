
using System;
namespace IntegerLinearSearch;
    class program
    {
        public static void Main(string[] args)
        {
           int[] array=new int[]{1,2,3,4,5,6,7,8,10,13,43,99};
           System.Console.WriteLine("Enter the number you want to search:");
           int number=int.Parse(Console.ReadLine());
           int flag=0;
           for(int start=0;start<array.Length;start++)
           {
                if(array[start]==number)
                {
                    System.Console.WriteLine($"Search completed! Number present -{number} index-{start}");
                    flag=1;
                }
           }
           
           if(flag!=1)
           {
           System.Console.WriteLine("Not present");
           }

        }
            
    }

    
