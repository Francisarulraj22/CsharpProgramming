using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class TeacherDetails : PersonalDetails
    {
        private static int s_teacherId=3000;

       //Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string  subjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfjoining { get; set; }
        public TeacherDetails(string name,string fatherName,Gender gender,long phonenumber,string teacherID, string department, string subjectTeaching, string qualification, int yearOfExperience, DateTime dateOfjoining):base(name,fatherName,gender,phonenumber)
        {
            s_teacherId++;
            TeacherID="TID"+s_teacherId;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfjoining = dateOfjoining;
        }

        // Method: Show

        public void ShowDetail()
        {
            System.Console.WriteLine($"TeacherID: {TeacherID}\nDepartment: {Department}\n SubjectTeaching: {SubjectTeaching}\n YearOfExperience:{YearOfExperience}\n DateOfjoining: {DateOfjoining}");
            ShowDetails();
        }



        
    }
}