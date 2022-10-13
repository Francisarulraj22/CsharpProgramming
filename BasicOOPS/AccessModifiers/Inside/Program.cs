using System;
namespace Inside;
class program
{
    public static void Main(string[] args)
    {
        First first=new First();
        System.Console.WriteLine(first.Number); 
        System.Console.WriteLine(first.PrivateOutPut);
        System.Console.WriteLine(first.Number2);
        Second second=new Second();
        System.Console.WriteLine(second.ProtectedOutput);
        System.Console.WriteLine(first.Number5Output);

    }
        
    
}