using System;
namespace CharacterBinarySearch;
class program
{
   public static void Main(string[] args)
   {
    int[] numbers=new int[]{1,9,3,12,9,6,7,8,150,9,11,28,99,121};
    Array.Sort(numbers);
    
    System.Console.WriteLine("Enter Number You Want to search:");
    int number=int.Parse(Console.ReadLine().ToLower());
    int begining=0,ending=numbers.Length-1,middle;
    int flag=0;
    while(begining<=ending)
    {
        
        middle=(begining+ending)/2;
        if(number==numbers[middle])
        {
            System.Console.WriteLine($"Search Completed-{number} index-{middle}");
            flag=1;
            break;
        }
        else
        {
            if(number<numbers[middle])
            {
                ending=middle-1;
                
            }
            else
            {
                begining=middle+1;
            }
        }
    }
    if(flag!=1)
    {
        System.Console.WriteLine("Not found");
    }
    }
} 

