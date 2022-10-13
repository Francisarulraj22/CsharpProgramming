using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmploymentDetails : StudentDetails
    {
        private static int s_employeeid=1000;
        public string EmployeeID { get; set; }
        public DateTime RegistrationDate { get; set; }

        public EmploymentDetails(string studentID ,string aid,string name,string fatherName,Gender gender,long phonenumber,Department department,DateTime registrationDate):base(studentID ,aid,name,fatherName,gender,phonenumber, department)
        {
            s_employeeid++;
            EmployeeID="EID"+s_employeeid;
            RegistrationDate=DateTime.Today;
  
        }
        public void ShowEmploymentDetail()
        {
            System.Console.WriteLine("EmployementID:"+EmployeeID);
            ShowStudent();
            System.Console.WriteLine("RegistrationDate:"+RegistrationDate.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Renewel Date:"+RegistrationDate.AddYears(1).ToString("dd/MM/yyyy"));
        }
    }
}