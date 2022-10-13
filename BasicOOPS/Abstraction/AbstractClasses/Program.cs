using System;
namespace AbstractClasses;
class program
{
    public static void Main(string[] args)
    {
        Syncfusion sync=new Syncfusion();
        sync.Name="\nDeveloper\n";
        sync.Salary(28);
        TCS tcs=new TCS();
        tcs.Name="\nTesting\n";
        tcs.Salary(28);
        
    }
}