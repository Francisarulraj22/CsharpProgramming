using System;

namespace Question5;
        class program
        {
            public static void Main(string[] args)
            {
                
                System.Console.WriteLine("Enter Favourite Team:");
                string teamName=Console.ReadLine();
                
                switch(teamName)
                {
                    case "India":
                    {
                        System.Console.WriteLine($"1.Gambir");
                        System.Console.WriteLine($"2.Aswin");
                        System.Console.WriteLine($"3.Dhoni");
                        System.Console.WriteLine($"4.Jadeja");

                        break;
                    }
                    case "Pakistan":
                    {
                        System.Console.WriteLine($"1.Afridi");
                        System.Console.WriteLine($"2.Babar Asam");
                        System.Console.WriteLine($"3.Sahid khan ");
                        System.Console.WriteLine($"4.Aktar");
                        break;
                    }
                    case "Bangladesh":
                    {
                        System.Console.WriteLine($"1.Tamim Iqbal");
                        System.Console.WriteLine($"2.Mushfiqur rahim");
                        System.Console.WriteLine($"3.litton Das");
                        System.Console.WriteLine($"4.Sahib Alhasan");
                        break;
                    }
                    default :
                    {
                        break;
                    }
                    
                }

            }
        }