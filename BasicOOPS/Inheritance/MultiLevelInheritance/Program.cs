using System;
namespace MultiLevelInheritance;
class program
{

    public static void Main(string[] args)
    {
        System.Console.WriteLine("<<<<<<<<<<<<<<< PersonalDetails >>>>>>>>>>>>\n");
        string Name="Francisarulraj";
        string FatherName="Alexander";
        Gender Gender=Gender.Male;
        long PhoneNumber=7869878867;
        PersonalDetails detail=new PersonalDetails(Name,FatherName,Gender,PhoneNumber);
        detail.ShowDetails();
        System.Console.WriteLine();
        System.Console.WriteLine("<<<<<<<<<<<<<<< StudentDetails >>>>>>>>>>>>\n");
        StudentDetails student=new StudentDetails("AID8766","Francis","Alexander",Gender.Male,96968676,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,99);
        student.ShowMark();
        student.Calculate();
        System.Console.WriteLine();
        System.Console.WriteLine("<<<<<<<<<<<<<<< CustomerDetails >>>>>>>>>>>>\n");
        CustomerDetails customer=new CustomerDetails("AID8766","Francis","Alexander",Gender.Male,96968679);
        customer.ShowDetail();
        System.Console.WriteLine();
        System.Console.WriteLine("<<<<<<<<<<<<<<< EmploymentDetails >>>>>>>>>>>>\n");
        EmploymentDetails employee=new EmploymentDetails("SID1004","AID1004","Francis","Alexander",Gender.Male,96968679,Department.CSE,new DateTime());
        employee.ShowEmploymentDetail();
        System.Console.WriteLine();


    }
     
}