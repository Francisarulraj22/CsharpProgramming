using System;
namespace SelectionSort;
class program
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[]{18,19,1,5,7,3,20};
        int tempvalue=0,j,minimum,minimumIndex;
        for (var i = 0; i < numbers.Length; i++)
        {
            minimum=numbers[i];
            minimumIndex=i;

            for (j = i; j < numbers.Length; j++)
            {
                if(numbers[j]<minimum)
                {
                    minimum=numbers[j];
                    minimumIndex=j;
                }

            }

            if(minimum<numbers[i])
            {
               tempvalue=numbers[i];
               numbers[i]=numbers[minimumIndex];
               numbers[minimumIndex]=tempvalue;

                
            }   
        } 
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }  
    }    
}