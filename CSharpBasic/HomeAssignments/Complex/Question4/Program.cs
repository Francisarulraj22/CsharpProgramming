using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the name:");
        string name=Console.ReadLine();
        char[] array=name.ToCharArray();
        string[] store;
        for (var i = 0; i < ; i++)
        {
            if(i<=array.Length)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    array[i].CompareTo(array[j]);
                    if(array[i]==array[j])
                    {
                        array.Array.Clear(1);
                    }
                   

                }
                
                    System.Console.WriteLine(array);

            }
        }
        
    }
        
    
}