using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        int n=0,remainder,temp=n,sum=0;
        System.Console.WriteLine("Enter the limit: ");
        int limit=int.Parse(Console.ReadLine());
        while(n<=limit)
        {
            remainder=n%10;
            n=n/10;
            sum=remainder+n;
            
        if(temp==sum)
        System.Console.WriteLine("Prime");
        else
        System.Console.WriteLine("Not prime");
        n++;
       
        }
        
    }
        
    
}
