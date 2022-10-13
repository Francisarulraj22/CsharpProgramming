using System;
using System.Collections.Generic;
using System.IO;
namespace CovidApplication

{

    public enum Gender{Default,Male,Female,Other}

    public class BeneficiaryClass

    {

        public static int s_registerNumber=1000;

        public string RegisterNumber{get;}

        public string Name{get;set;}

        public Gender GenderSelect{get;set;}

        public long MobileNumber{get;set;}

        public string City{get;set;}

        public int Age{get;set;}



        public BeneficiaryClass(string name,Gender gender,long mobileNumber,string city,int age)

        {

            s_registerNumber++;
            RegisterNumber="BID"+s_registerNumber;
            Name=name;
            GenderSelect=gender;
            MobileNumber=mobileNumber;
            City=city;
            Age=age;

        }
        public BeneficiaryClass(string data)

        {
            string[] dataofperson=data.Split(','); 
            s_registerNumber=int.Parse(dataofperson[0].Remove(0,3));
            RegisterNumber=dataofperson[0];
            Name=dataofperson[1];
            GenderSelect=Enum.Parse<Gender>(dataofperson[2],true);
            MobileNumber=int.Parse(dataofperson[3]);
            City=dataofperson[4];
            Age=int.Parse(dataofperson[5]);

        }  
        // public void ShowMyDetail()
        // {
        //         System.Console.WriteLine("\n");
        //        
        // }
        
    }
}