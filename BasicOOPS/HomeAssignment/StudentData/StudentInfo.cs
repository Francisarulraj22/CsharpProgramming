using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string Name { get; set; }
        public  static int RegisterNumber;
        static StudentInfo()                                //default constructor

        {
            Name="FrancisArulraj  A";
            RegisterNumber=3129;


        }
        public static void Display()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(RegisterNumber);
            StudentInfo.RegisterNumber=6548;
            System.Console.WriteLine(RegisterNumber);
        }
        
        
        
    }
}