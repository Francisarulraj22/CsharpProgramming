using System;
namespace Question1;
    
    class program
    {
        public static void Main(string[] args)
        {
            string name=Console.ReadLine();
            Console.WriteLine("Hello:"+name);
            Console.WriteLine("Hello:{0}",name);
            Console.WriteLine($"Hello:{name}");
        }

    }