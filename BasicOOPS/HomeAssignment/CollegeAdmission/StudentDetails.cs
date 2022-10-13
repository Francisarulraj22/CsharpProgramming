using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
    //    private string _name="Arun";//field_declaration
        //public string Name { get(return _name); set(_name=value); }//property
        public string Name { get; set; }//Auto property
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }
        public int Physics { get; set; }
        public int  Mathematics { get; set; }
        public int  Chemistry { get; set; }
        
        public StudentDetails()     //Default constructor
        {
                Name="Your Name";               //To omit null values avoid from crashing application
                FatherName="Your Father Name";
                MailId="Your Mail Id";
                Gender="Your Gender";
        }
        //parameterize constructor
        public StudentDetails(string name,string fatherName ,DateTime datofBirth,string gender,long PhoneNumber,string mailId,int physics,int chemistry,int maths )
        {
            Name=name;
            FatherName=fatherName;
            DateofBirth=datofBirth;
            Gender=gender;
            Phonenumber=PhoneNumber;
            MailId=mailId;
            Chemistry=chemistry;
            Mathematics=maths;

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}