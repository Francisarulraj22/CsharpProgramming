
using System;
namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            //Parent class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< PersonalInfo >>>>>>>>>>>>>");
            PersonalInfo person=new PersonalInfo("Arun","Alexander",new DateTime(2000,11,22),Gender.Male,986879587,"asdfg@gmail.com");
            person.ShowDetail();


            //Child class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< AccountInfo >>>>>>>>>>>>>");
            AccountInfo accountHolder=new AccountInfo("Arun","Alexander",new DateTime(2000,11,22),Gender.Male,986879587,"asdfg@gmail.com","HDF0876",Branch.Chetpet,10500);
            accountHolder.ShowAccountInfo();

        }
            
    }
