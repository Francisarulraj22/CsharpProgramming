using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class PrincipleDetails
    {   
        //Qualification, YearOfExperience, DateOfJoining
        private static int s_principalid=1500;

      

        public string PricipalID { get; set; }
        public string  Qualification{ get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public PrincipleDetails(string name,string fatherName,Gender gender,long phonenumber,string pricipalID, string qualification, int yearOfExperience, DateTime dateOfJoining):base(name,fatherName,gender,phonenumber)
        {
            PricipalID = pricipalID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public void ShowDetails1()
        {
            
        }
    }
}