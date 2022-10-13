
using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {

           System.Console.WriteLine("Enter the string:");
           string str=Console.ReadLine();
           char[] array=str.ToCharArray(0,str.Length);
           System.Console.WriteLine("Enter the position to start extraction:");
            int position=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the length of substring:");
            int length=int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine(array[position+i-1]);
                
           }
           }
            
    }

    

