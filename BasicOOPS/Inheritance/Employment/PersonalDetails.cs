using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment
{
    public enum Gender{Male,Female,Others}
    public class PersonalDetails
    {
        private static int s_aId=10000;
        public string AID{get; set;}
        public string Name { get; set; }
        public string  FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }
        
        public PersonalDetails(string name,string fatherName,Gender gender,long phonenumber)
        {
            s_aId++;
            AID="AID"+s_aId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phonenumber;
            
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("ID:"+AID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("PhoneNumber:"+PhoneNumber);
        }
       
    }
}

// One class

// Personal details.cs

// Properties
//     1.AID(auto increment)
// 	2. Name
// 	3. Father name
// 	4. Gender enum
// 	5. Phone
// Constructor:

// Show Details method();
// One object:
	
	




