using System;

namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter password:");
            string password=Console.ReadLine();
            string defaultPassword="HiTeam";
            if(password==defaultPassword)
            {
                System.Console.WriteLine("Right password");
            }
            else 
            {
                System.Console.WriteLine("Wrong password");
            }
        }
    }


