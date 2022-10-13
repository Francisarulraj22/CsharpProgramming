using System;
namespace PartialClass;
class program
{
    public static void Main(string[] args)
    {
        StudentDetails student=new StudentDetails("Francisarulraj","Alexander",new DateTime(2000,11,22),Gender.Male,860960778,"asdashgh@gmail.com",99,98,98);
        student.ShowDetails();
        student.CheckEligibility(75);
        
    }
}
