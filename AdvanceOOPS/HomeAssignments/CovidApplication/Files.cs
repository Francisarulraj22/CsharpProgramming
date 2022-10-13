using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CovidApplication
{
    public class Files
    {

        public static void Create()
        {
            if(!Directory.Exists("CovidApplication"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("CovidApplication");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("CovidApplication/BeneficiaryClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("CovidApplication/BeneficiaryClass.csv");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("CovidApplication/VaccineClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("CovidApplication/VaccineClass.csv");
            }
            else{System.Console.WriteLine("Found");}

            if(!File.Exists("CovidApplication/VaccinationClass.csv"))
            {
                System.Console.WriteLine("Creating File...");
                File.Create("CovidApplication/VaccinationClass.csv");
            }
            else{System.Console.WriteLine("Found");}
        }
        public static void ReadFile()
        {
            //ReadFile For ReadFile


            string[] Person=File.ReadAllLines("CovidApplication/BeneficiaryClass.csv");
            
            foreach (var data in Person)
            {
                BeneficiaryClass PersonObject=new BeneficiaryClass(data);
                Operations.BeneficiariesList.Add(PersonObject);    
            }

            string[] vaccine=File.ReadAllLines("CovidApplication/VaccineClass.csv");

            foreach (var item in vaccine)
            {
                VaccineClass vaccineObject=new VaccineClass(item);
                Operations.VaccinesList.Add(vaccineObject);
            }

            //ReadFile For VaccinationClass

            string[] vaccination=File.ReadAllLines("CovidApplication/VaccinationClass.csv");

            foreach (var Vitem in vaccination)
            {
                VaccinationClass vaccinationObject=new VaccinationClass(Vitem);
                Operations.VaccinationsList.Add(vaccinationObject);
            }
            
        }
        public static void WriteFile()
        {
            //Write For BeneficiaryClass

            string[] DetailObject=new string[Operations.BeneficiariesList.Count];
           
            for (var i=0;i<Operations.BeneficiariesList.Count;i++)
            {
                DetailObject[i]=Operations.BeneficiariesList[i].RegisterNumber+","+Operations.BeneficiariesList[i].Name+","+Operations.BeneficiariesList[i].GenderSelect+","+Operations.BeneficiariesList[i].MobileNumber+","+Operations.BeneficiariesList[i].City+","+Operations.BeneficiariesList[i].Age;

            }
            File.WriteAllLines("CovidApplication/BeneficiaryClass.csv",DetailObject);

            //Write For VaccineClass

            string[] VDetailObject=new string[Operations.VaccinesList.Count];
            
            for (var i = 0; i < Operations.VaccinesList.Count; i++)
            {
                VDetailObject[i]=Operations.VaccinesList[i].VaccineId+","+Operations.VaccinesList[i].VaccineName+","+Operations.VaccinesList[i].NumberOfDoseAvailablity;
            }
            File.WriteAllLines("CovidApplication/VaccineClass.csv",VDetailObject);

            //Write For VaccinationClass

            string[] VaDetailObject=new string[Operations.VaccinationsList.Count];
           
            for (var i = 0; i < Operations.VaccinationsList.Count; i++)
            {
                VaDetailObject[i]=Operations.VaccinationsList[i].VaccinationId+","+Operations.VaccinationsList[i].VaccineId+","+Operations.VaccinationsList[i].RegisterNumber+","+Operations.VaccinationsList[i].DoseNumber+","+Operations.VaccinationsList[i].VaccinationDate.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("CovidApplication/VaccinationClass.csv",VaDetailObject);
        }


        
    }
}