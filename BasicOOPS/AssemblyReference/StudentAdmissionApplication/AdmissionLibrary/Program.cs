using System;
using System.Collections.Generic;
namespace AdmissionLibrary;
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
        
        //object creation
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
         System.Console.WriteLine("DO you Want to Register: Yes or No");
        condition=Console.ReadLine().ToLower();
       
       
       
       
       
       
       
       
       
        }
        foreach (StudentDetails student in studentList )
        {
             System.Console.WriteLine("StudentDetails:");
             System.Console.WriteLine($"Register number:{student.RegisterNumber}\nName:{student.Name}\nFather's Name:{student.FatherName}\nDOB:{student.DateofBirth}\nGender:{student.Gender}\nPhoneNumber:{student.Phonenumber}\nMail ID:{student.MailId}\nPhysics Marks:{student.Physics}\nChemistry Marks:{student.Mathematics}\nMaths Marks:{student.Mathematics}"); 
             bool eligible=student.CheckEligibility(75.00);
             if(eligible)
             System.Console.WriteLine("You're Eligible");
             else
             System.Console.WriteLine("You're not Eligible");
       }
        

    }
        
    
}