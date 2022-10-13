using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll{
    public class Operation
    {
        static EmployeeDetails currentemployee=null; 
        static List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();
        public static void Mainmenu()
        {

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
                EmployeeList.Add(employees);
                System.Console.WriteLine(employees.EmployeeId);

        }
        public static void Login()
        {
         
          System.Console.WriteLine("Enter Your EmployeeId:");
          string Employeeid=Console.ReadLine().ToUpper();
          foreach (EmployeeDetails employee in EmployeeList)
          {
            if(employee.EmployeeId==Employeeid)     
            {
            System.Console.WriteLine("Login Succesfull!!!");
            currentemployee=employee;

            SubMenu();
            }
        } 
        public static void SubMenu()
                    {
                        
                        string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu\n1.Show Details\n2.\n3.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                    
                                        System.Console.WriteLine("Show Detail");
                                       
                                        break;
                                    
                                    case 2:
                                    
                
                                        break;
                                        
                                    case 3:
                                    
                                        System.Console.WriteLine("Exit Submenu");
                                        choice="no";
                                        break;
                                    
                                    default:
                                    
                                        break;
                                    
                                }
                            }while(choice=="yes");                  
                        
                    }          


        // public static void 
        // {

        // }
        
        

    }
}}