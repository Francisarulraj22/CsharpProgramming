
using System;
using System.Linq;
namespace Question13;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input:");
            string input=Console.ReadLine();
            int number=0;
            foreach (var value in input)
            {
                 if (value>='0'&&value<='9')
            {
                int i=value-'0';
                number+=i;
                
            }
            }
            System.Console.WriteLine(number);
             
        }
            
    }

    
