using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Department{Default,CSE,MECH,ECE,EEE}
    public class StudentDetails : PersonalDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; set; }
        public Department Department{ get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }// property declaration only
        public int Maths { get; set; }
        public int Chemistry { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        //Constractor using Inheritance
        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phonenumber,Department department,string year):base(aid,name,fatherName,gender,phonenumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;

        }
        public void ShowStudent()
        {
            System.Console.WriteLine("StudentID:"+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department"+Department+"Year:"+Year);
        }
        public void GetMark(int physics,int maths,int chemistry)
        {
            Physics=physics;
            Maths=maths;
            Chemistry=chemistry;

        }
        public void Calculate()
        {
            Total=Maths+Chemistry+Physics;
            System.Console.WriteLine("Total:"+Total);
            Average=(double)Total/3.0;
            System.Console.WriteLine("Average:"+Average);
        }
        public void ShowMark()
        {
            System.Console.WriteLine("Physics:"+Physics);
            System.Console.WriteLine("Maths:"+Maths);
            System.Console.WriteLine("Chemistry:"+Chemistry);
        }



    }
}