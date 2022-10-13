using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your First date dd/MM/yyyy format");
            DateTime datetime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime future=datetime.AddYears(1);
            DateTime past=datetime.AddYears(-1);
            System.Console.WriteLine($"{datetime} is earlier than {future}");
         
            System.Console.WriteLine($"{datetime} is later than  {past}");
           

        }
    }
            
    

    
