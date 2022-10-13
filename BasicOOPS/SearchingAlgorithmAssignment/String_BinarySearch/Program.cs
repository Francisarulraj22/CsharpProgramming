using System;
namespace CharacterBinarySearch;
class program
{
   public static void Main(string[] args)
   {
    string[] str=new string[]{"SF3001","SF3002","SF3003","SF3004","SF3005","SF3006","SF3007","SF3008","SF3009","SF3010"};  
    System.Console.WriteLine("Enter String You Want to search:");
    string idsearch=Console.ReadLine();
    int begining=0,ending=str.Length-1,middle;
    int flag=0;
    while(begining<=ending)
    {
        
        middle=(begining+ending)/2;
        if(idsearch==str[middle])
        {
            System.Console.WriteLine($"Search Completed-{idsearch} index-{middle}");
            flag=1; 
            break; 
        }
        else
        {
            if(string.Compare(idsearch,str[middle])<1)
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

