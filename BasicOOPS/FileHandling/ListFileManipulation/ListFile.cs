using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ListFileManipulation
{
    public enum Gender{Default,Male,Female}
    public class ListFile
    {
       
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }

        public static void Main(string[] args)
        {
         List<ListFile> Slist=new List<ListFile>();
         Slist.Add(new ListFile(){Name="ARUN",FatherName="ALEXANDER",Gender=Gender.Male,DOB=new DateTime(2000,11,22)});
         Slist.Add(new ListFile(){Name="arun",FatherName="alexander",Gender=Gender.Male,DOB=new DateTime(2000,11,22)});
         Slist.Add(new ListFile(){Name="student",FatherName="father",Gender=Gender.Male,DOB=new DateTime(2003,01,11)});  
         Insert(Slist);
         display();
        
        }
        static void Insert(List<ListFile> Slist)
        {
            StreamWriter write=null;
            if(!File.Exists("Data.csv"))
            {
                System.Console.WriteLine("File Doesn't Exist.Creating new CSV File");
                File.Create("Data.csv");
                System.Console.WriteLine("File Created");
            }
            else{System.Console.WriteLine("File Found");}

            write=new StreamWriter(File.OpenWrite("Data.csv"));
            foreach (var detail in Slist)
            {
                write.WriteLine(detail.Name+","+detail.FatherName+","+detail.Gender+","+detail.DOB.ToString("dd/MM/yyyy"));
            }
        write.Close();
        }
        static void display()
        {
            StreamReader reader=null;
            List<ListFile>show=new List<ListFile>();
            if(File.Exists("Data.csv"))
            {
                reader=new StreamReader(File.OpenRead("Data.csv"));
                while(!reader.EndOfStream)
                {
                    var line=reader.ReadLine();
                    var values=line.Split(',');
                    if(values[0]!="")
                    {
                        show.Add(new ListFile(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Not found");
            }
            reader.Close();
            foreach (var c in show)
            {
                System.Console.WriteLine($"\t Your Name : {c.Name} \t Your FatherName : {c.FatherName} \t Gender is : {c.Gender} \t Date Of birth : {c.DOB.ToString("dd/MM/yyyy")}");        
            } 
        }
        static void Update()
        {
            
        }


    }
}