using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender { Default,Male,Female,Transgender};
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }

        public PersonalInfo(string name,string fatherName ,DateTime datofBirth,Gender gender,long phoneNumber,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            DateofBirth=datofBirth;
            Gender=gender;
            Phonenumber=phoneNumber;
            MailId=mailId;
        }     
        public void ShowDetail()
        {   System.Console.WriteLine("\n");
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("DateofBirth:"+DateofBirth.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("PhoneNumber:"+Phonenumber);
            System.Console.WriteLine("Mail Id:"+MailId);
        }
    
    }

}