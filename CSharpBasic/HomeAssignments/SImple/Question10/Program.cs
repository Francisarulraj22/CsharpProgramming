using System;
namespace Question10;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the character:");
        char character= char.Parse(Console.ReadLine());
        if(character=='a'||character=='e'||character=='i'||character=='o'||character=='u')
        {
            System.Console.WriteLine("It is Vowel");
        }
        else
        System.Console.WriteLine("It is not a Vowel");
        
    }
}
