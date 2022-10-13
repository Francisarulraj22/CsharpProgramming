using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class program
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
        StudentDetails student=new StudentDetails("Francis","Alexander",Gender.Male,96968676,Department.CSE,"Final");
        student.ShowStudent();
        System.Console.WriteLine();
        System.Console.WriteLine("<<<<<<<<<<<<<<< HSCDetails >>>>>>>>>>>>\n");
        
        HSCDetails hSC=new HSCDetails("Francis","Alexander",Gender.Male,96968679,Department.CSE,"Final");
        
        hSC.GetMark(99,90,88);
        hSC.Calculate();
        hSC.ShowMarksheet();
        System.Console.WriteLine();
      }  
    }
}