
using System.IO;

namespace CollegeAdmissionApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetail.csv");
            }

        }
        public static void ReadFile()
        {
            string[] student=File.ReadAllLines("College/StudentDetails.csv");
            foreach (var data in student)
            {
                StudentDetails student1=new StudentDetails(data);
                Operations.StudentList.Add(student1);
            }
        }
        public static void WriteToFiles()
        {
            string[] studentDetails=new string[Operations.StudentList.Count];
            for (var i = 0; i < Operations.StudentList.Count; i++)
            {
                studentDetails[i]=Operations.StudentList[i].RegisterNumber+","+Operations.StudentList[i].Name+","+Operations.StudentList[i].FatherName+","+Operations.StudentList[i].DateofBirth+","+Operations.StudentList[i].Gender+","+Operations.StudentList[i].Chemistry+","+Operations.StudentList[i].Mathematics+","+Operations.StudentList[i].Physics;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
        }
    }
}