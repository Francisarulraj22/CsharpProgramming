
using System;
namespace Question7;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your First date dd/MM/yyyy format");
            DateTime datetime1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine(" Enter your Second dd/MM/yyyy format");
           DateTime datetime2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
           var compare=DateTime.Compare(datetime1,datetime2);
           if(compare<0)
           {
            System.Console.WriteLine($"{datetime1} is earlier than {datetime2}");
           }
           else if(compare==0)
           {
            System.Console.WriteLine($"{datetime1} is same day as {datetime2}");
           }
           else
           {
            System.Console.WriteLine($"{datetime1} is later than  {datetime2}");
           }

        }
    }
            
    

    
