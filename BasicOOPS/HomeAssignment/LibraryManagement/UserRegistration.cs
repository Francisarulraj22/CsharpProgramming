using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Gender{Defualt,Male,Female,Others}
    public enum Department{ECE,EEE,CSE}
    public class UserRegistration
    {
        private static int s_userid=3000;
        public string Userregistration { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long Number { get; set; }
      
        public string MailId { get; set; }
        
        public UserRegistration(string name,Gender gender,Department department,long mobilNumber,string mailId)
        {
            s_userid++;
            Userregistration="SF"+s_userid;
            Name=name;
            Gender=gender;
            Department=department;
            Number=mobilNumber;
            MailId=mailId;


        }
    }
}