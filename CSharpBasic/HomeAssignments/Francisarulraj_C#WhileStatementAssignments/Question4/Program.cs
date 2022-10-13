using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number:");
        int number=int.Parse(Console.ReadLine());
        bool check=int.TryParse(Console.ReadLine(),out number);
        while(number<=5&&number>=1)
        {
        check=int.TryParse(Console.ReadLine(),out number);
        if(check)
        {
            System.Console.WriteLine("Valid Input");
        }
        else
        {
            System.Console.WriteLine("Invalid input Enter again");
        }
        number++;


        }
    }
}