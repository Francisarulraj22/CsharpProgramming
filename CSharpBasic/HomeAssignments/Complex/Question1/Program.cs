using System;
namespace Question1;
class program
{
    public static void Main(string[] args)
    {
        int r1=2,r2=3,c1=3,c2=2;
        int[,] array1=new int[2,3]{{1,2,3},{4,5,6}};
        int[,] array2=new int[3,2]{{7,8},{9,10},{11,12}};
        int[,] array3=new int[3,3];
         System.Console.WriteLine("first matrix");
        for (var i = 0; i < r1; i++)
        {
            for (var j = 0; j < c1; j++)
            {
                System.Console.WriteLine("\n"+array1[i,j]);
                
            }
        }
        System.Console.WriteLine("Second matrix");
         for (var i = 0; i < r2; i++)
        {
            for (var j = 0; j < c2; j++)
            {
                System.Console.WriteLine("\n"+array2[i,j]);   
            }
    }
    //multiplication
    System.Console.WriteLine("Result matrix:");
    for (var k = 0; k < 3; k++)
    {
       for (var i = 0; i < r2; i++)
        {
            for (var j = 0; j < c2; j++)
            {
                array3[i,j]=array1[i,j]+array1[i,k]*array2[j,k];
                System.Console.WriteLine("\n "+array3[i,j]);   
            }
    }
        
    
}}}