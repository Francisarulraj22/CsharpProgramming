
using System;
namespace Question1;
    class program
    {
        public static void Main(string[] args)
        {
            //Parent class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< PersonalInfo >>>>>>>>>>>>>");
            PersonalInfo person=new PersonalInfo("Arun","Alexander",new DateTime(2000,11,22),Gender.Male,986879587,"asdfg@gmail.com");
            person.ShowDetail();

            System.Console.WriteLine("\n");

            //Child class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< StudentInfo >>>>>>>>>>>>>");
            StudentInfo student=new StudentInfo("Arun","Alexander",new DateTime(2000,11,22),Gender.Male,986879587,"asdfg@gmail.com"," ",Branch.CSE,"FinalYear");
            student.ShowInfo();

        }
            
    }

    
