using System;
namespace StringLinearSearch;
class program
{
   public static void Main(string[] args)
   {
    string[] strings=new string[]{"cup","bottle","angle","charger","mobile"};
    
    System.Console.WriteLine("Enter String You Want to search:");
    string str=Console.ReadLine().ToLower();
    int flag=0;
    for (var i = 0; i < strings.Length; i++)
    {
        if(strings[i]==str)
        {
            System.Console.WriteLine($"Search completed!--{str} index-{i}"); 
            flag=1;
        }    
   }
    if(flag!=1)
    {
         System.Console.WriteLine("String Not found");
    }
   
 
   
} 
}