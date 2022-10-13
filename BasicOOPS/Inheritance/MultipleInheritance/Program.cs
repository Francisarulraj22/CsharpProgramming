using System;
namespace MultipleInheritance;
class program
{

    public static void Main(string[] args)
    {
        
        string Name="Francisarulraj";
        string FatherName="Alexander";
        Gender Gender=Gender.Male;
        long PhoneNumber=7869878867;
        PersonalDetails detail=new PersonalDetails(Name,FatherName,Gender,PhoneNumber);
        detail.ShowDetails();
        System.Console.WriteLine();
        StudentDetails student=new StudentDetails("788766","Francis","Alexander",Gender.Male,96968676,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,99);
        student.ShowMark();
        student.Calculate();
        System.Console.WriteLine();
        CustomerDetails customer=new CustomerDetails("788766","Francis","Alexander",Gender.Male,96968679);
        customer.ShowDetail();



    }
     
}