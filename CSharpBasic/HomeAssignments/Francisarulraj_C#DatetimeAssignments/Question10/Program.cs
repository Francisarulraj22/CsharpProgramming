
using System;
namespace Question10;
    class program
    {
        public static void Main(string[] args)
        {
        DateTime today=DateTime.Now;
        DateTime tomorrow=today.AddDays(1);
        DateTime yesterday=today.AddDays(-1);
        System.Console.WriteLine("Yesderday:"+yesterday.ToShortDateString());
        System.Console.WriteLine("Tomorrow:"+tomorrow.ToShortDateString());

        
}
        }
            


    
