using System;
namespace Question;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the factorial Number:");
            int number=int.Parse(Console.ReadLine());
            int i,sum=0;
            number=0;

            for(i=number;number>=0;i--)
            {
            if(number==1)
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(number*(number-1));
                sum+=number;
            }
            }
            System.Console.WriteLine(sum);
        }
    }
