using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        int sum=0,average=0;
        System.Console.WriteLine("No of Input Terms:");
        int terms=int.Parse(Console.ReadLine());
        for(int i=1;i<=terms;i++)
        {
        int number=int.Parse(Console.ReadLine());
        sum=sum+number;
        
        }
        average=sum/terms;
        System.Console.WriteLine("Sum:"+sum);
        System.Console.WriteLine("Average:"+average);
    }
}