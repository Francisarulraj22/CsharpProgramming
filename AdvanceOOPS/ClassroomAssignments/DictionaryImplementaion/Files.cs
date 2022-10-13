using System;
using System.Collections.Generic;
using System.IO;

namespace CovidApplication
{
    class Files
    {
        public static Dictionary<string,BeneficiaryClass>Bdict=new Dictionary<string, BeneficiaryClass>();
        public  static Dictionary<string,VaccineClass>Vdict=new Dictionary<string, VaccineClass>();
        public static Dictionary<string,VaccinationClass>VacDict=new Dictionary<string, VaccinationClass>();

        public static void Create()
        {
            if(!Directory.Exists("MyDictionary"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MyDictionary");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("MyDictionary/BeneficiaryClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MyDictionary/BeneficiaryClass.csv");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("MyDictionary/VaccineClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MyDictionary/VaccineClass.csv");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("MyDictionary/VaccinationClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("MyDictionary/VaccinationClass.csv");
            }
            else{System.Console.WriteLine("Found");}
        }
        public static void ReadFile()
        {
            //ReadFile For ReadFile
            string[] Benificiary =new string[program.Bdict.Count];
            int i=0;
            foreach(var user in Bdict)
            {
                Benificiary[i]=user.Value.RegisterNumber+","+user.Value.Name+","+user.Value.GenderSelect+","+user.Value.MobileNumber+","+user.Value.City+","+user.Value.Age;
                i++;
            }
            File.WriteAllLines("MyDictionary/BeneficiaryClass.csv",Benificiary);
            // using (StreamReader sr= new StreamReader("MyDictionary/BeneficiaryClass.csv"))
            // {
            //     string line;
            //     while((line=sr.ReadLine())!=null)
            //     {
            //         string[] keyvalue=line.Split(',');

            //         if(keyvalue.Length==2)
            //         {
            //             read.Add(keyvalue[0],keyvalue[1]);
            //         }
            //     }
            // }
            
        //     Dictionary<string,object>Vaccineread=new Dictionary<string, object>();
        //     using (StreamReader sr= new StreamReader("MyDictionary/VaccineClass.csv"))
        //     {
        //         string line;
        //         while((line=sr.ReadLine())!=null)
        //         {
        //             string[] keyvalue=line.Split(',');

        //             if(keyvalue.Length==2)
        //             {
        //                 Vaccineread.Add(keyvalue[0],keyvalue[1]);
        //             }
        //         }
        //     }
        //     //ReadFile For VaccinationClass
        //     Dictionary<string,object>Vaccinationread=new Dictionary<string, object>();
        //     using (StreamReader sr= new StreamReader("MyDictionary/VaccinationClass.csv"))
        //     {
        //         string line;
        //         while((line=sr.ReadLine())!=null)
        //         {
        //             string[] keyvalue=line.Split(',');
        //             if(keyvalue.Length==2)
        //             {
                   
        //             Vaccinationread.Add(keyvalue[0],keyvalue[1]);
        //             }
               
        //         }
        //     }
        // }
        public static void WriteFile()
        {
            //Write For BeneficiaryClass

            string[] DetailObject=new string[program.Bdict.Count];
            int i=0
            foreach(var temp in Bdict)
            {
                DetailObject[i]=temp.Value.RegisterNumber+temp.Value.Name+temp.Value.Age+temp.Value.GenderSelect+temp.Value.MobileNumber+temp.Value.City;
                i++;
            }
            File.WriteAllLines("CovidApplication/BeneficiaryClass.csv",DetailObject);

        //     //Write For VaccineClass

        //     string[] VDetailObject=new string[program.Vdict.Count];
            
        //     for (var i = 0; i < program.Vdict.Count; i++)
        //     {
        //         VDetailObject[i]=Vdict.ElementAt(i).Value.VaccineId+","+Vdict.ElementAt(i).Value.VaccineName+","+Vdict.ElementAt(i).Value.NumberOfDoseAvailablity;
        //     }
        //     File.WriteAllLines("CovidApplication/VaccineClass.csv",VDetailObject);

        //     //Write For VaccinationClass

        //     string[] VaDetailObject=new string[program.VacDict.Count];
           
        //     for (var i = 0; i < program.VacDict.Count; i++)
        //     {
        //         VaDetailObject[i]=VacDict.ElementAt(i).Value.VaccinationId+","+VacDict.ElementAt(i).Value.VaccineId+","+VacDict.ElementAt(i).Value.RegisterNumber+","+VacDict.ElementAt(i).Value.DoseNumber+","+VacDict.ElementAt(i).Value.VaccinationDate.ToString("dd/MM/yyyy");
        //     }
        //     File.WriteAllLines("CovidApplication/VaccinationClass.csv",VaDetailObject);
        // }     
    }
}