using System;
namespace Question7;
    class program
    {
        public static void Main(string[] args)
        {
            int [,] array1= {{1,2,3}, {4,5,6}, {7,8,9}}; 
            for (var i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                System.Console.WriteLine(array1[i , j]);
                }
            System.Console.WriteLine();
            }
        }
            
    }

    
