using System;
namespace Question9;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number:");
        int number=int.Parse(Console.ReadLine());
        int sum=0,temp;
        
        for(temp=number;number!=0;number=number/10)
        {
        int remainder=number%10;
        sum=sum+(remainder*remainder*remainder);
        }
        if(sum==temp)
        {
            System.Console.WriteLine(+sum+" is an Armstrong");
        }
        else
        {
            System.Console.WriteLine(+sum+" is not Armstrong");
        }

    }
}
