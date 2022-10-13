using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Branch{Default,CSE,EEE,ECE,MECH}
    public class StudentInfo:PersonalInfo
    {
        //Propeties: RegisterNumber, Standard, Branch, AcadamicYear
        private static int s_registernumber=1000;
        public string RegisterNumber { get; set; }
        public string Standard{ get; set; }
        public Branch Branch { get; set; }
        public string AcademicYear { get; set; }

        public StudentInfo(string name,string fatherName ,DateTime datofBirth,Gender gender,long PhoneNumber,string mailId,string standard,Branch branch,string academicYear):base( name, fatherName , datofBirth, gender, PhoneNumber, mailId)
        {
            s_registernumber++;
            RegisterNumber="SID"+s_registernumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
        //Method: GetInfo, ShowInfo
        public void ShowInfo()
        {
            ShowDetail();
            System.Console.WriteLine($"RegisterNumber:{RegisterNumber}\nStandard:{Standard}\nBranch:{Branch}\nAcademicYear:{AcademicYear}");
        }

    }
}