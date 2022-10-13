using System;

namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Month:");
            string month=Console.ReadLine();
            string december="December";
            string january="January";
            string february="February";
            string march="March";
            string april="April";
            string may="May";
            string june="June";
            string july="July";
            string august="August";
            string september="September";
            string october="October";
            string november="November";
            if(december==month||january==month||february==month)
            {
                System.Console.WriteLine("Winter");
            }
            else if( september==month||october==month||november==month)
            {
                System.Console.WriteLine("Rainfall");
            }
            else if( june==month||july==month||august==month)
            {
                System.Console.WriteLine("Summmer");
            }
            else if( march==month||april==month||may==month)
            {
                System.Console.WriteLine("Spring");
            }
        }
    }


