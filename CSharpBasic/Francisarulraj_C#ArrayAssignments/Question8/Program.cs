using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter The Size of Matrix:");
            int size=int.Parse(Console.ReadLine());
            
            int [,] array1= new int[size,size];
            int [,] array2= new int[size,size];
            int [,] array3= new int[size,size];
            int row,column,row1,column1;
            System.Console.WriteLine("Rows:");
            row=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Columns:");
            column=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Rows:");
            row1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Columns:");
            column1=int.Parse(Console.ReadLine());

            if(row!=column1)
            {
                System.Console.WriteLine("mulpication not posiible");

            }
            else
            {
                System.Console.WriteLine("Enter first matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= column1; j++)
                {
                array1[i,j]=int.Parse(Console.ReadLine());
            
                }
            }
            System.Console.WriteLine("Enter second  matrix:");
            for (int i = 0; i <= row1; i++)
            {
                for (int j = 0; j < column1; j++)
                {
                array2[i,j]=int.Parse(Console.ReadLine());
            
                }
            }
            System.Console.WriteLine("FIRST MATRIX:\n");
            for (var i = 0; i <= row; i++)
            {
                Console.Write("\n");
                for (var j = 0; j <=column; j++)
                {
                    Console.Write("\t"+array1[i,j]);
                }
                
            }
            System.Console.WriteLine("SECOND MATRIX:\n");
            for (var i = 0; i <= row1; i++)
            {
                Console.Write("\n");
                for (var j = 0; j <=column1; j++)
                {
                    Console.Write("\t"+array2[i,j]);
                }
                
            }
            }

            System.Console.WriteLine("The Multiplication of matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= column1; j++)
                {
                array3[i,j]=0;
                }
            }
                for (int i = 0; i < row; i++)
                {
                    for (var j = 0; j < column1; j++)
                    {
                     int sum=0;
                      for (var k = 0; k < column ; k++)
                      {
                        sum=sum+array1[i,k]*array2[k,j];
                        array3[i,j]=sum;
                        
                      }   
                    }
                    System.Console.WriteLine("Multiplication of two matrix is:");
                    for ( i = 0; i < row; i++)
                    {
                        System.Console.WriteLine("\n");
                        for (var j = 0; j < column1; j++)
                        {
                            System.Console.WriteLine(array3[i,j]);
                        }
                    }
                }
                System.Console.WriteLine("\n\n");
            }
            
        }
            
    