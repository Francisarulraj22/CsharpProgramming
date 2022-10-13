using System;

    namespace Question5;
        class program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter Chemistry Mark:");
                int chemistry=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Physics Mark:");
                int physics=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Maths Mark:");
                int maths=int.Parse(Console.ReadLine());
                int sum= chemistry+physics+maths;
                int average=sum/3;
                int percentage=sum/3;
                Console.WriteLine("Physics:"+physics);
                Console.WriteLine("Chemistry:"+chemistry);
                Console.WriteLine("Maths:"+maths);
                Console.WriteLine("Sum:"+sum);
                Console.WriteLine("Percentage:"+percentage+"%");


            }
        }
