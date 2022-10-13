using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter One Number:");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Another one Number:");
        int number2=int.Parse(Console.ReadLine());
        Swap();
        System.Console.WriteLine($"Now the 1st number is : {number1} , and the 2nd number is : {number2}");
        void Swap()
        {
            int temp=number1;
            number1=number2;
            number2=temp;
        }

    }
}
