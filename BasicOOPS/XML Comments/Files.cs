using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Files
    {
        static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("StudentDetails.csv");
            }
            if(!File.Exists("College/.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("StudentDetails.csv");
            }
        }
    }
}