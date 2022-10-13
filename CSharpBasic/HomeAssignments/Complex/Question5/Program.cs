using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string input=Console.ReadLine();
        char[] str=input.ToCharArray();
        char[] original=str;
        for (var i = str.Length-1; i>=0; i--)
        {

            System.Console.WriteLine(str[i]); 
            
            
        }
         if(original==str)
            {
            System.Console.WriteLine("It is polindrome");
            }
            else if(str!=original)
            System.Console.WriteLine(" it is not polindrome");
          
        
    }

        
    
}