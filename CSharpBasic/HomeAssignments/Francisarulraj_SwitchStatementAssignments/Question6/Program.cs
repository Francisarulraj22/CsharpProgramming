using System;

namespace Question6;
        class program
        {
            public static void Main(string[] args)
            {
                
                System.Console.WriteLine("Radius of circle:");
                double radius=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Choice::");
                int choice=int.Parse(Console.ReadLine());
                
                
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine($"The Area of Circle:{3.14*radius}");
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine($"The perimeter of Circle:{2*radius}");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine($"The Circumference of Circle:{2*3.14*radius}");
                        break;
                    }
                    default :
                    {
                        break;
                    }
                    
                }

            }
        }