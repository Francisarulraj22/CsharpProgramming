using System;
using System.Collections.Generic;
namespace OnlineMedicalStore;
public class program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operation.Mainmenu();
        Files.WriteToFiles();
    }
  
    
}
