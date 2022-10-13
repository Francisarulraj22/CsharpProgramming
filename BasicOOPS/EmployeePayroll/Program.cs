using System;
using System.Collections.Generic;
namespace EmployeePayroll;
class program
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();
        System.Console.WriteLine("Enter employee Name:");
        string employeeName=Console.ReadLine();
        
        System.Console.WriteLine("Role:");
        string employeeRole=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Gender:");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Work Location:");
        WorkLocation worklocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter Team Name:");
        string teamname=Console.ReadLine();

        
        System.Console.WriteLine("Enter the Date of Joining:");
        DateTime dateOfJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        


        EmployeeDetails employees=new EmployeeDetails(employeeName,employeeRole,gender1,worklocation,teamname,dateOfJoining);
        employees.NumberofLeaveTaken();
        employees.CalculateSalary();





    }
        
    
}