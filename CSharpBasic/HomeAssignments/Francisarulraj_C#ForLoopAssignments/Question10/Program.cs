using System;
namespace Question10;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("No of Input number:");
        int value=int.Parse(Console.ReadLine());
        for(int i=0;i<=value;++i)
        {
     
            if(value==2)
            {
            System.Console.WriteLine("prime number:"+value);
            break;
            }
            else if(value==1)
            {
                System.Console.WriteLine("Neither prime nor composite:"+value);
                break;
            }
            else if((value%value==0) && (value%2!=0))
            {
                System.Console.WriteLine("Prime number:"+value);
                break;

            }
            else
            {
                System.Console.WriteLine("Not prime number:"+value);
                break;
            }
            
        }
    }
}
