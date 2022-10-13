using System;
using System.Collections.Generic;


namespace CollegeAdmissionApplication;
    public static class Operations
    {
        public static List<StudentDetails>StudentList=new List<StudentDetails>();
        public static List<AdmissionDetail>AdmissionList=new List<AdmissionDetail>();
        public static List<DepartmentDetails>DepartmentList=new List<DepartmentDetails>();
        public static Dictionary<string,object>dict=new Dictionary<string, object>();
        static StudentDetails currentStudent=null;
        static DepartmentDetails currentdepartment=null;
        static AdmissionDetail currentadmission=null;
      
        public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Option\n1.Student Registration\n2.Student Login\n3.Check Department wise seat availability\n4.Exit");
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
                    System.Console.WriteLine("Seat Availablity");
                    foreach (DepartmentDetails department in DepartmentList)
                        {
                            System.Console.WriteLine($"DepartmentId: {department.DepartmentId}  Department Name: {department.Departments}  Seat Availability: {department.NumberOfSeats}");
                        }
                    break;
                   
                case 4:
                
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
        
        System.Console.WriteLine("Enter your Physics Mark:");
        int physics=int.Parse(Console.ReadLine());
        
       
        
        System.Console.WriteLine("Enter your Chemistry Mark:");
        int chemistry2=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Mathematics Mark:");
        int maths2=int.Parse(Console.ReadLine());

        StudentDetails student=new StudentDetails(name2,fatherName2,dateofBirth2,gender2,physics,chemistry2,maths2);
        dict.Add(student.RegisterNumber,student);
        System.Console.WriteLine($"Student Added Succesfully and StudentID-{student.RegisterNumber}");

       }
       public static void Login()
        {
          System.Console.WriteLine("Enter Your RegisterNumber:");
          string registerNumber=Console.ReadLine().ToUpper();
         
            if(dict.ContainsKey(registerNumber))     
            {
            System.Console.WriteLine("Login Succesfull!!!");
            SubMenu();
            }
          }    

        public static void ShowDetails()
        {
        foreach (KeyValuePair<string,object> item in dict)
        {
            if(dict.ContainsKey(item.Key))
            {
                System.Console.WriteLine(item.Key,item.Value);
            }
        }

        }
        
        public static void SubMenu()
                    {
                        
                        string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu\n1.Check Eligibility\n2.Show Details\n3.Take Admission\n4.Cancel Admission\n5.Admission Details\n6.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                { 
                                    case 1:
                                        System.Console.WriteLine("Check Eligibility");
                                        if(currentStudent.CheckEligibility(75.00))
                                        System.Console.WriteLine("Student is Eligible");
                                        else
                                        System.Console.WriteLine("Student is not Eligible");
                                        break;
                                    case 2:
                            
                                        System.Console.WriteLine("Show Detail");
                                        ShowDetails();
                                        break;
                                        
                                    case 3:
                                    
                                        System.Console.WriteLine("Take Admission");
                                        TakeAdmission(currentStudent);
                                        break;
                                    case 4:
                                        System.Console.WriteLine("Cancel Admission");
                                        CancelAdmission(currentStudent);
                                        break;
                                    case 5:   
                                        System.Console.WriteLine("Admission Details");
                                        AdmissionDetails(currentStudent);

                                        break;
                                    case 6:
                                       
                                        System.Console.WriteLine("Exit Submenu");
                                        choice="no";
                                        break;
                                        
                                    default:
                                        break;
                                    
                                }
                            }while(choice=="yes");                  
                        }
                    public static void SetSampleData()
                    {
                           
                            
                            StudentList.Add(new StudentDetails("Ravichandran E","Ettapparajan",new DateTime(1999,11,11),Gender.Male,95,95,95));
                            StudentList.Add(new StudentDetails("Baskaran  S","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95));                            
                    }
                   public static void ShowAvailablity()
                   {
                    ShowDetails();
                   }
                    public static void DefaultDepartmentDetails()
                    {
                    DepartmentList.Add(new DepartmentDetails("DID1001","CSE",28));
                    DepartmentList.Add(new DepartmentDetails("DID1002","MECH",28));
                    DepartmentList.Add(new DepartmentDetails("DID1001","ECE",30));
                    DepartmentList.Add(new DepartmentDetails("DID1001","EEE",30));
                    DepartmentList.Add(new DepartmentDetails("DID1001","CIVIL",30));
                    
                    }
                     public static void DefaultAdmissionDetails()
                    {
                    AdmissionList.Add(new AdmissionDetail("SF1001","DID101",new DateTime(11/05/2022),AdmissionStatus.Admitted)); 
                    AdmissionList.Add(new AdmissionDetail("SF1002","DID102",new DateTime(11/05/2022),AdmissionStatus.Admitted));
                    
                    }
                    public static void TakeAdmission(StudentDetails student)
                    {
                        
                    
                        foreach (DepartmentDetails department in DepartmentList)
                        {
                            System.Console.WriteLine($"DepartmentId: {department.DepartmentId}  Department Name: {department.Departments}  Seat Availability: {department.NumberOfSeats}");
                        }
                        System.Console.WriteLine("Please Choose Department Id:");
                        string departmentId=Console.ReadLine();
                        
                        bool DepartmentIdPresent = false;
                    
                       foreach (DepartmentDetails department in DepartmentList)
                        {
                            if(department.DepartmentId==departmentId)
                        {
                            DepartmentIdPresent = true;
                            currentdepartment=department;
                            break;
                        }       
                    }
                   
                    if(DepartmentIdPresent)
                    {
                        if(student.CheckEligibility(75))
                        {
                            bool admissionconfirm = false;
                            foreach (AdmissionDetail admission in AdmissionList)
                            {
                                if(student.RegisterNumber==admission.StudentID)
                                {
                                    admissionconfirm=true;
                                }
                            }
                            if(admissionconfirm)
                            {
                                currentdepartment.NumberOfSeats-=1;
                                AdmissionDetail admission=new AdmissionDetail(student.RegisterNumber,departmentId,DateTime.Now, AdmissionStatus.Admitted);
                                AdmissionList.Add(admission);
                                System.Console.WriteLine($"Admission successffully completed");
                                System.Console.WriteLine($"YourAdmission ID-  {admission.AdmissionID}");
                            }
                            else
                            {
                                System.Console.WriteLine("You Previously admitted");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("You're not Eligible");
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Department Id id Not present");
                    }
}
            public static void CancelAdmission(StudentDetails student)
            {
                foreach (AdmissionDetail admission in AdmissionList)
                {
                   if(admission.StudentID==student.RegisterNumber)
                   {
                    System.Console.WriteLine($"AdmissionId- {admission.AdmissionID} Department Id- {admission.DepartmentId} AdmissionDate- {admission.AdmissionDate.ToString("dd/MM/yyyy")} AdmissionStatus- {admission.AdmissionStatus}");
                   currentadmission=admission;
                   }
                }
                if(currentadmission!=null)
                {
                    currentadmission.AdmissionStatus =AdmissionStatus.Canceled;
                    foreach (DepartmentDetails department in DepartmentList)
                    {
                        if(department.DepartmentId==currentadmission.DepartmentId)
                        {
                            department.NumberOfSeats+=1;
                            break;
                        }
                    }
                    System.Console.WriteLine("Seat cancelled Succesfully");
                }
                else
                {
                    System.Console.WriteLine("No Admission Found");
                }

            }
            public static void AdmissionDetails(StudentDetails student)
            {
                foreach (AdmissionDetail admission in AdmissionList)
                {
                    System.Console.WriteLine($"AdmissionId-{admission.AdmissionID}  StudentId-{admission.StudentID} DepartmentId-  {admission.DepartmentId} Admissiondate- {admission.AdmissionDate} AdmissionStatus- {admission.AdmissionStatus}");
                }
            }
}

