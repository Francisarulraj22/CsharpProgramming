
using System;
namespace Question7;
    class program
    {
        public static void Main(string[] args)
        {
                       System.Console.WriteLine("Enter the string:");
           string str=Console.ReadLine();
            int vowels=0, consonants=0;
            for (int i = 0; i < str.Length-1; i++)
            {
            if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
            {
                vowels+=1;
            }  
            else
            {
                consonants+=1;
            }  
            }
            System.Console.WriteLine($"vowels in string:{vowels}");
            System.Console.WriteLine($"Consonants in string:{consonants}");
        }
           
        }
            
    

    

