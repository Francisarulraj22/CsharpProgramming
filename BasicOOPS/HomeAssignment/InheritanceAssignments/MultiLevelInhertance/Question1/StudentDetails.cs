using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Department{Default,CSE,MECH,ECE,EEE}
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department{ get; set; }
        public string AcademicYear { get; set; }
        

        //Constractor using Inheritance
        public StudentDetails(string name,string fatherName,Gender gender,long phonenumber,Department department,string academicyear):base(name,fatherName,gender,phonenumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            AcademicYear=academicyear;

        }
    
        public void ShowStudent()
        {
            System.Console.WriteLine("StudentID:"+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department"+Department+"Year:"+AcademicYear);
        }
       

    }
}