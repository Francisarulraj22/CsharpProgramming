using System;
namespace CharacterLinearSearch;
class program
{
   public static void Main(string[] args)
   {
    char[] chars=new char[]{'a','b','c','d','e','f','g','h','i','j','k','l','a','e'};
    
    System.Console.WriteLine("Enter character You Want to search:");
    char character=char.Parse(Console.ReadLine().ToLower());
    int flag=0;
    for (var i = 0; i < chars.Length; i++)
    {
        if(chars[i]==character)
        {
            System.Console.WriteLine($"Search completed!--{character} index-{i}"); 
            flag=1;
        }    
   }
    if(flag!=1)
    {
         System.Console.WriteLine("not found");
    }
   
 
   
} 
}