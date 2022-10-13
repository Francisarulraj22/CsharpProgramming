using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class EmployeeInfo
    {
        //Class EmployeeInfo: Inherits SalaryInfo
        
    public enum Gender { Default,Male,Female,Transgender};
    public class PersonalInfo
    {
        private static int s_employeeId=1000;
        public  string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }

        public PersonalInfo(string name,string fatherName ,DateTime datofBirth,Gender gender,long phoneNumber,string mailId)
        {
            s_employeeId++;
            EmployeeID="EID"+s_employeeId;
            Name=name;
            FatherName=fatherName;
            DateofBirth=datofBirth;
            Gender=gender;
            Phonenumber=phoneNumber;
            MailId=mailId;
        }     
        public void ShowDetail()
        {  
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("DateofBirth:"+DateofBirth.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("PhoneNumber:"+Phonenumber);
            System.Console.WriteLine("Mail Id:"+MailId);
        }
    }
}
        
    }
// Properties: EmployeeID,Name,FatherName,Gender,Mobile,DOB, Branch, List<Attendance>,
// Method: Log Attendance, UpdateDetails, ShowDetails.
