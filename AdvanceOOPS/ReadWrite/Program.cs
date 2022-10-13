using System;
namespace HelloWorld;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String myName = Console.ReadLine();
            Console.WriteLine("Enter your Father's name:");
            String myfatherName = Console.ReadLine();
            Console.WriteLine("Your Name:"+myfatherName);
            //concatination
            Console.WriteLine("Your Name :" +myName+ "Your Father's Name:"+myfatherName);
            //PlaceHolder
            Console.WriteLine("Your Name :{0} Your Father's Name: {1}",myName,myfatherName);
            //Interpolation (It's best to save time and memory)
            Console.WriteLine($"Your Name :{myName} Your Father's Name:{myfatherName}");
        }
    }

