using System;
namespace BubbleSort;
class program
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[]{18,19,1,5,7,3,20};
        int tempvalue=0;
        for (var i = 0; i < numbers.Length-1; i++)
        {
            for (var j = 0; j < numbers.Length-1; j++)
            {
                if(numbers[j]>numbers[j+1])
                {
                    tempvalue=numbers[j];
                    numbers[j]=numbers[j+1];
                    numbers[j+1]=tempvalue;
                    
                 
                }      
            }    
        } 
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }
         
        
    }
}