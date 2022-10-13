
using System;
namespace Question6;
    class program
    {
        public static void Main(string[] args)
        {

           System.Console.WriteLine("Enter the string:");
           string str=Console.ReadLine();
            int alphabets=0, digits=0,specialchar=0;
            for (int i = 0; i < str.Length-1; i++)
            {
            if(str[i]>='a'&&str[i]<='z'||str[i]>='A'&&str[i]<='Z')
            {
                alphabets+=1;
            }  
            else if(str[i]>='0'&&str[i]<='9')
            {
                digits+=1;
            }   
            else
            {
                specialchar+=1;
            }  
            }
            System.Console.WriteLine($"Alphabets in string:{alphabets}");
            System.Console.WriteLine($"Digits in string:{digits}");
            System.Console.WriteLine($"Special characters in string:{specialchar}");
        }
            
    }

    

