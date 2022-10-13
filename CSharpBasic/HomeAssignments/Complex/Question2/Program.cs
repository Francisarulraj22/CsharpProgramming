using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter n value:");
        double limit=double.Parse(Console.ReadLine());
        for (var i = 0; i < limit; i++)
        {
            float series,npower,nfact=0,two=0;
            npower=i+1;
            for (var j = i; j >0; j--)
            {
              nfact=j*j; 
            }
            for (var k = 0; k < npower; k++)
            {
               two=2*k;
            }
            
            series=nfact+(i*two);
             System.Console.WriteLine("Output:"+series);
        }
      
    }
        
    
}