using System;
namespace SingleInheritance;
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
        StudentDetails student=new StudentDetails("788766","Francis","Alexander",Gender.Male,96968676,Department.CSE,"Final");
        student.ShowStudent();


    }
     
}