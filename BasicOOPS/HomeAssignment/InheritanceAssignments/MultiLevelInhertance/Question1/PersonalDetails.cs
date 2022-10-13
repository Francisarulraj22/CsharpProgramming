using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender{Male,Female,Others}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string  FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }
        
        public PersonalDetails(string name,string fatherName,Gender gender,long phonenumber)
        {
          
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phonenumber;
            
        }
        // public PersonalDetails(string name,string fatherName,Gender gender,long phonenumber)
        // {
            
   
        //     Name=name;
        //     FatherName=fatherName;
        //     Gender=gender;
        //     PhoneNumber=phonenumber;
            
        // }
        public void ShowDetails()
        {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("PhoneNumber:"+PhoneNumber);
        }
       
    }
}

	




