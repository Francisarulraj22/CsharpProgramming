using System;

namespace Question;
        class program
        {
            public static void Main(string[] args)
            {
                System.Console.WriteLine("Enter your Choice:");
                char choice=char.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 'E':
                    {
                       
                        System.Console.WriteLine("Excellent");
                        break;
                    }
                    case 'V':
                    {
                        
                        System.Console.WriteLine("Very Good");
                        break;
                    }
                    case 'G':
                    {
                       
                        System.Console.WriteLine("Good");
                        break;
                    }
                    case 'A':
                    {
                        
                        System.Console.WriteLine("Average");
                        break;
                    }
                    case 'F':
                    {
                        
                        System.Console.WriteLine("Fail");
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Operation Invalid");
                        break;
                    }
                    
                }

            }
        }