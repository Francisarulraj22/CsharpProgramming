using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        int reminder,sum=0;
        System.Console.WriteLine("Enter the input:");
        int input=int.Parse(Console.ReadLine());
        int tempvalue=input;

        while(input>0)
        {
            reminder=input%10;
            sum=reminder+sum;
            sum=input/10;

        }
        if(tempvalue==sum)
        {
        System.Console.WriteLine("polyndrome");
        }
        else
        System.Console.WriteLine("Not polyndrom");

        }
        
        
    }
        
    
