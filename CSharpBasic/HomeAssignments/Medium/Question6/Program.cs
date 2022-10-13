using System;
namespace Question6;
class program
{
    public static void Main(string[] args)
    {
        int[,] array1=new int[3,3]{{1,2,3},{2,2,3},{3,2,1}};
        int[,] array2=new int[3,3]{{1,2,3},{2,2,3},{3,2,1}};
        int[,] array3=new int[3,3];
        for (var i = 0; i <=2; i++)
        {
            for (var j = 0; j <=2; j++)
            {
               
                array3[i,j]=array1[i,j]+array2[i,j];
            
            }
        }
            System.Console.WriteLine("Sum of Matrices:");
            
            for (var i = 0; i <=2; i++)
            {
                System.Console.Write("\n");
            for (var j = 0; j <=2; j++)
            {
             System.Console.WriteLine(array3[i,j]+ " ");
                
            }     
    }
    
}}
