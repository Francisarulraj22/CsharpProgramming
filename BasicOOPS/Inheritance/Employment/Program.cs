using System;
namespace Employment;
class program
{

    public static void Main(string[] args)
    {
        
        string Name="Francis";
        string FatherName="Alexander";
        Gender Gender=Gender.Male;
        long PhoneNumber=7869878867;
        PersonalDetails detail=new PersonalDetails(Name,FatherName,Gender,PhoneNumber);
        detail.ShowDetails();

    }
     
}