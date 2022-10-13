using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission;

    public static class Operations
    {
        static StudentDetails currentStudent=null;
        static List<StudentDetails> studentList= new List<StudentDetails>();


        public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Option\n1.Registration\n2.Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
            switch (option)
               {
                case 1:
                
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                
                case 2:
                
                    System.Console.WriteLine("Login");
                    Login();
                    
                    break;
                   
                case 3:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
                default:
                
                    break;
                
                }
                
        }while(choice=="yes");

    }

        public static void Registration()
        {
            System.Console.WriteLine("Enter Your Name:");
        string name2=Console.ReadLine();

        System.Console.WriteLine("Enter Father Name: ");
        string fatherName2=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        DateTime dateofBirth2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter Your gender:");
        Gender gender2=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter your phone number:");
        long phoneNumber2=long.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Mail Id:");
        string mailId2=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Physics Mark:");
        int physics2=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Chemistry Mark:");
        int chemistry2=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Mathematics Mark:");
        int maths2=int.Parse(Console.ReadLine());
        StudentDetails student=new StudentDetails(name2,fatherName2,dateofBirth2,gender2,phoneNumber2,mailId2,physics2,chemistry2,maths2);
        studentList.Add(student);
        System.Console.WriteLine(student.RegisterNumber);

       }
       public static void Login()
        {
          System.Console.WriteLine("Enter Your RegisterNumber:");
          string registerNumber=Console.ReadLine().ToUpper();
          foreach (StudentDetails student in studentList)
          {
            if(student.RegisterNumber==registerNumber)     
            {
            System.Console.WriteLine("Login Succesfull!!!");
            currentStudent=student;
            SubMenu();
            }
          }    
        }
        public static void SubMenu()
                    {
                        
                        string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu\n1.Show Details\n2.Check Eligibility\n3.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                    
                                        System.Console.WriteLine("Show Detail");
                                        currentStudent.ShowDetails();
                                        break;
                                    
                                    case 2:
                                    
                                        System.Console.WriteLine("Check Eligibility");
                                        if(currentStudent.CheckEligibility(75.00))
                                        System.Console.WriteLine("You're Eligible");
                                        else
                                        System.Console.WriteLine("You're not Eligible");
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
       
        }
        
