using System;
namespace Question8;
    class program
    {
        public static void Main(string[] args)
        {
            
         
            for(int i=1;i<=4;i++)
            {
                
                for(int j=0;j<=4-i;j++)
                {
                    System.Console.Write("  ");  
                }
                for(int k=1;k<=2*i-1;k++)
                {
                        
                     System.Console.Write((i-1)+k);
                                       
                   
                    System.Console.Write(" ");

                }
                System.Console.WriteLine("");

            }
        }
    }