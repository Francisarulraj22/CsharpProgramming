using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the value1:");
            int value1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the value2:");
            int value2=int.Parse(Console.ReadLine());
           
            System.Console.WriteLine("a."+(value1>value2));
            System.Console.WriteLine("b."+(value1<value2));
            System.Console.WriteLine("c."+(value1>=value2));
            System.Console.WriteLine("d."+(value1<=value2));
            System.Console.WriteLine("e."+(value1==value2));
            System.Console.WriteLine("f. ="+(value1!=value2));
            System.Console.WriteLine("g."+(value1>=10&&value2>=10));
            System.Console.WriteLine("h."+(value1>=10||value2>=30));
            System.Console.WriteLine("i."+(!(value1>20)));
            String value;
            System.Console.WriteLine(value=value1==15?"j.True":"j.false");
            System.Console.WriteLine("k."+(value1++));
            System.Console.WriteLine("l."+(value1--));   
        }
    }
