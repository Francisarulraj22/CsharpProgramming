using System;
namespace InsertionSort;
class program
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[]{18,19,1,5,7,3,20,27};
        int tempvalue=0,j,key;
        for (var i = 1; i < numbers.Length-1; i++)
        {
            key=numbers[i];
            j=i-1;
           while(j>=0 && key<numbers[j])
            {   
            tempvalue=numbers[j];
            numbers[j]=numbers[j+1];
            numbers[j+1]=tempvalue; 
            j--;   
            }    
        } 
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }  
    }    
}