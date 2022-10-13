using System;
namespace Question1;
class program
{
  public static void Main(string[] args)
  {
    float salary,afterdeduct;
    System.Console.WriteLine("Enter basic salary of Employee:");
    int basesalary=int.Parse(Console.ReadLine());
    if(basesalary<=10000)
    {
        salary=12*(basesalary+(basesalary/20)+(basesalary/80));
        afterdeduct=salary/7;
        System.Console.WriteLine("Annual Gross salary"+salary);
        System.Console.WriteLine("Take Home Salary:"+afterdeduct);
    }
    else if(basesalary<=20000)
    {
        salary=12*(basesalary+(basesalary/25)+(basesalary/90));
        afterdeduct=salary/7;
        System.Console.WriteLine("Annual Gross salary"+salary);
        System.Console.WriteLine("Take Home Salary:"+afterdeduct);
    }
    else if(basesalary>20000)
    {
        salary=12*(basesalary+(basesalary/30)+(basesalary/95));
        afterdeduct=salary/7;
        System.Console.WriteLine("Annual Gross salary");
        System.Console.WriteLine("Take Home Salary:"+afterdeduct);
    }
  }  
}
