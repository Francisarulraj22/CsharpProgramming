using System;
namespace CharacterBinarySearch;
class program
{
   public static void Main(string[] args)
   {
    char[] characters=new char[]{'a','b','e','d','z','i','c','f'};
    Array.Sort(characters);   
    System.Console.WriteLine("Enter Character You Want to search:");
    char character=char.Parse(Console.ReadLine().ToLower());
    int begining=0,ending=characters.Length,middle;
    int flag=0;
    while(begining<=ending)
    {
        
        middle=(begining+ending)/2;
        if(character==characters[middle])
        {
            System.Console.WriteLine($"Search Completed-{character} index-{middle}");
            flag=1;
            
        }
        else
        {
            if(character<characters[middle])
            {
                ending=middle-1;
                
            }
            else
            {
                begining=middle+1;
            }
        }
    }
    if(flag!=1)
    {
        System.Console.WriteLine("Not found");
    }

    }
} 

