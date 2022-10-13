using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first String:");
        string nameOne=Console.ReadLine();
        System.Console.WriteLine("Enter Second String:");
        string nameTwo=Console.ReadLine();
        char[] name1=nameOne.ToCharArray();
        char[] name2=nameTwo.ToCharArray();
        int count=0,count1=0;

        for (var i = 0; i < name1.Length; i++)
        {
            for (var j = 0; j < name2.Length; j++)
            {
                if(name1[i]==name2[j])
                {
                    count+=1;
                    
                }
                else
                {
                    count1+=1;     
                }
            }
        }
        if(count==count1)
        System.Console.WriteLine($"nameOne :{nameOne}  and nameTwo :{nameTwo} are Anagrams");
        else
        Console.WriteLine($"nameOne :{nameOne}  and nameTwo :{nameTwo} are Not Anagrams");

       
    }
        
    
}