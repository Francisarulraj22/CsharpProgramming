using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class program
{
    public static void Main(string[] args)


    {
        System.Console.WriteLine("DO you Want to Register: Yes or No");
        string condition=Console.ReadLine().ToLower();
        List<StudentDetails> studentList= new List<StudentDetails>();
        while(condition=="yes")
        {
        System.Console.WriteLine("Read Data....");
        
        StudentDetails student2=new StudentDetails();//object creation
        System.Console.WriteLine("Enter Your Name:");
        string name2=Console.ReadLine();

        System.Console.WriteLine("Enter Father Name: ");
        string fatherName2=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        DateTime dateofBirth2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter Your gender:");
        string gender2=Console.ReadLine();
        
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
        
        studentList.Add(student2);
       
       
       
       
       
       
       
       
        //  StudentDetails student1=new StudentDetails();//object creation
        // System.Console.WriteLine("Enter Your Name:");
        // string name=Console.ReadLine();
        // student1.Name=name;                                       //property creation using local variable
        // System.Console.WriteLine("Enter Father Name: ");
        // student1.FatherName=Console.ReadLine();         //property and variable assign in single line 
        // System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        // student1.DateofBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        // System.Console.WriteLine("Enter Your gender:");
        // student1.Gender=Console.ReadLine();
        // System.Console.WriteLine("Enter your phone number:");
        // student1.Phonenumber=long.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter your Mail Id:");
        // student1.MailId=Console.ReadLine();
        // System.Console.WriteLine("Enter your Physics Mark:");
        // student1.Physics=int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter your Chemistry Mark:");
        // student1.Chemistry=int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Enter your Mathematics Mark:");
        // student1.Mathematics =int.Parse(Console.ReadLine());
        // studentList.Add(student1);
        // System.Console.WriteLine("<<<Admitted>>>");
        // System.Console.WriteLine("DO you Want to Register: Yes or No");
        // condition=Console.ReadLine().ToLower();
        }
        foreach (StudentDetails student in studentList )
        {
             System.Console.WriteLine("StudentDetails:");
             System.Console.WriteLine($"Name:{student.Name}\nFather's Name:{student.FatherName}\nDOB:{student.DateofBirth}\nGender:{student.Gender}\nPhoneNumber:{student.Phonenumber}\nMail ID:{student.MailId}\nPhysics Marks:{student.Physics}\nChemistry Marks:{student.Mathematics}\nMaths Marks:{student.Mathematics}"); 
        }
        
      /** 

        //student2
        StudentDetails student2=new StudentDetails();//object creation
        System.Console.WriteLine("Enter Your Name:");
        student2.Name=Console.ReadLine();   
        System.Console.WriteLine("Enter Father Name: ");                                    
        student2.FatherName=Console.ReadLine();         //property and variable assign in single line 
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        student2.DateofBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Your gender:");
        student2.Gender=Console.ReadLine();
        System.Console.WriteLine("Enter your phone number:");
        student2.Phonenumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mail Id:");
        student2.MailId=Console.ReadLine();
        System.Console.WriteLine("Enter your Physics Mark:");
        student2.Physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry Mark:");
        student2.Chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mathematics Mark:");
        student2.Mathematics =int.Parse(Console.ReadLine());
        studentList.Add(student2);


        //student3

        StudentDetails student3=new StudentDetails();//object creation
        System.Console.WriteLine("Enter Your Name:");
        student3.Name=Console.ReadLine();      
        System.Console.WriteLine("Enter Father Name: ");                                 
        student3.FatherName=Console.ReadLine();         //property and variable assign in single line 
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        student3.DateofBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Your gender:");
        student3.Gender=Console.ReadLine();
        System.Console.WriteLine("Enter your phone number:");
        student3.Phonenumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mail Id:");
        student3.MailId=Console.ReadLine();
        System.Console.WriteLine("Enter your Physics Mark:");
        student3.Physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry Mark:");
        student3.Chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mathematics Mark:");
        student3.Mathematics =int.Parse(Console.ReadLine());
        studentList.Add(student3);*/
      


       /** 
        //Student2

        System.Console.WriteLine("Enter Your Name:");
        string name1=Console.ReadLine();
        System.Console.WriteLine("Enter Father Name: ");
        string fatherName1=Console.ReadLine();
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        DateTime dateofBirth1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Your gender:");
        string gender1=Console.ReadLine();
        System.Console.WriteLine("Enter your phone number:");
        long phoneNumber1=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mail Id:");
        string mailId1=Console.ReadLine();
        System.Console.WriteLine("Enter your Physics Mark:");
        int physics1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry Mark:");
        int chemistry1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Mathematics Mark:");
        int maths1=int.Parse(Console.ReadLine());
        

        //Student3

        System.Console.WriteLine("Enter Your Name:");
        string name2=Console.ReadLine();
        System.Console.WriteLine("Enter Father Name: ");
        string fatherName2=Console.ReadLine();
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        DateTime dateofBirth2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Your gender:");
        string gender2=Console.ReadLine();
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
        System.Console.WriteLine($"Name:{student1.Name}\nFather's Name:{student1.FatherName}\nDOB:{student1.DateofBirth}\nGender:{student1.Gender}\nPhoneNumber:{student1.Phonenumber}\nMail ID:{student1.MailId}\nPhysics Marks:{student1.Physics}\nChemistry Marks:{student1.Mathematics};"); 
        System.Console.WriteLine($"Name:{student3.Name}\nFather's Name:{student3.FatherName}\nDOB:{student3.DateofBirth}\nGender:{student3.Gender}\nPhoneNumber:{student3.Phonenumber}\nMail ID:{student3.MailId}\nPhysics Marks:{student3.Physics}\nChemistry Marks:{student3.Mathematics} ;");
        System.Console.WriteLine($"Name:{student2.Name}\nFather's Name:{student2.FatherName}\nDOB:{student2.DateofBirth}\nGender:{student2.Gender}\nPhoneNumber:{student2.Phonenumber}\nMail ID:{student2.MailId}\nPhysics Marks:{student2.Physics}\nChemistry Marks:{student2.Mathematics};");

     /**  
        //Details output1

      
        //Details output2
        System.Console.WriteLine("Your Name is :"+name1);
        System.Console.WriteLine("Your Father's Name is:"+fatherName1);
        System.Console.WriteLine("Your Date of Birth is:"+dateofBirth1);
        System.Console.WriteLine("Your Gender is:"+gender1);
        System.Console.WriteLine("your Mail Id is:"+mailId1);
        System.Console.WriteLine("Your Number is:"+phoneNumber1);
        System.Console.WriteLine("your Physics Mark is:"+physics1);
        System.Console.WriteLine("Your Chemistry Mark is:"+chemistry1);
        System.Console.WriteLine("Your Mathematics Mark is:"+maths1);

       
        //Details output3

        System.Console.WriteLine("Your Name is :"+name2);
        System.Console.WriteLine("Your Father's Name is:"+fatherName2);
        System.Console.WriteLine("Your Date of Birth is:"+dateofBirth2);
        System.Console.WriteLine("Your Gender is:"+gender2);
        System.Console.WriteLine("your Mail Id is:"+mailId2);
        System.Console.WriteLine("Your Number is:"+phoneNumber2);
        System.Console.WriteLine("your Physics Mark is:"+physics2);
        System.Console.WriteLine("Your Chemistry Mark is:"+chemistry2);
        System.Console.WriteLine("Your Mathematics Mark is:"+maths2);
**/


    }
        
    
}