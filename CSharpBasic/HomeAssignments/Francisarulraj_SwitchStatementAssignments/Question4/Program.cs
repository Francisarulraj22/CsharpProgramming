using System;

namespace SwitchStatementAssignment;
        class program
        {
            public static void Main(string[] args)
            {
                System.Console.WriteLine("Here are the options : \n1-Addition. \n2-Substraction. \n3-Multiplication. \n4-Division. \n5-Exit.");
                System.Console.WriteLine("Enter your Choice:");
                int choice=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter fisrt number:");
                int firstNumber=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter second number:");
                int secondNumber=int.Parse(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                    {
                        int addition=firstNumber+secondNumber;
                        System.Console.WriteLine($"The Addtion of {firstNumber} and {secondNumber}");
                        System.Console.WriteLine($"Output is:{addition}");

                        break;
                    }
                    case 2:
                    {
                        int subratcion=firstNumber-secondNumber;
                        System.Console.WriteLine($"The Subraction of {firstNumber} and {secondNumber}");
                        System.Console.WriteLine($"Output is:{subratcion}");
                        break;
                    }
                    case 3:
                    {
                        int multiplication=firstNumber*secondNumber;
                        System.Console.WriteLine($"The Multiplication of {firstNumber} and {secondNumber}");
                        System.Console.WriteLine($"output is:{multiplication}");
                        break;
                    }
                    case 4:
                    {
                        int division=firstNumber/secondNumber;
                        System.Console.WriteLine($"The Division of {firstNumber} and {secondNumber}");
                        System.Console.WriteLine($"Output is:{division}");
                        break;
                    }
                    default :
                    {
                        break;
                    }
                    
                }

            }
        }