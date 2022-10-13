using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public enum WorkLocation{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female}

    public  class EmployeeDetails
    {
        private static int s_employeeId=1001;
        public string EmployeeId { get; set; }
        
        
        public string EmployeeName { get; set; }

         public string Role { get; set; }
         public Gender Gender { get; set; }
         
         
         public WorkLocation WorkLocation { get; set; }
         public string TeamName { get; set; }
         public int NoofWorkingDays{ get; set; }
         
         
         public DateTime DateofJoining { get; set; }

         public EmployeeDetails(string name,string role,Gender gender,WorkLocation worklocation,string teamname,DateTime dateofjoining )
         {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            EmployeeName=name;
            Role=role;
            WorkLocation=worklocation;
            TeamName=teamname;
            NoofWorkingDays=0;
            DateofJoining=dateofjoining;
         }
         public void NumberofLeaveTaken()
         {
            System.Console.WriteLine("Enter the number of Leaves Taken:");
            int leave=int.Parse(Console.ReadLine());
            NoofWorkingDays=22-leave;
            System.Console.WriteLine("Number Of Working Days:"+NoofWorkingDays);
         }
         
         public void CalculateSalary()
         {
            System.Console.WriteLine("Your Salary Details:");
            int salary;
            salary=NoofWorkingDays*500;
            System.Console.WriteLine(salary);

         }
         
         

         
           
        
    }
}
