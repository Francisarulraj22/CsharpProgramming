using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication
{
    public class Operations
    {
        public static BeneficiaryClass currentBeneficiary=null;
        public static VaccineClass currentVaccine=null;
        public static VaccinationClass currentVaccination=null;

        public static List<BeneficiaryClass>BeneficiariesList=new List<BeneficiaryClass>();
        public static List<VaccineClass>VaccinesList=new List<VaccineClass>();
        public static List<VaccinationClass>VaccinationsList=new List<VaccinationClass>();

        //Main Menu
        public static void Mainmenu()
        {

           string choice="yes";
            do
            {
                Console.WriteLine("Select Option\n1.Beneficiary Registration\n2.Login\n3.Get Vaccine Information\n4.Exit");
                int option=int.Parse(Console.ReadLine());
            switch (option)
               {
                case 1:
                
                    System.Console.WriteLine("Beneficiary Registration");
                    BeneficiaryRegistration();
                    break;
                
                case 2:
                
                    System.Console.WriteLine("Login");
                    Login();
                    
                    break;
                case 3:
                    System.Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<Vaccine Information>>>>>>>>>>>>>>>>>>>>>>");
                    GetVaccineInfo();
                    break;
                   
                case 4:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
                default:
                
                    break;
                
                }
                
        }while(choice=="yes");


        }

        //Registration
        public static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
           
            System.Console.WriteLine("Enter your Age:");
            int age=int.Parse(Console.ReadLine());
           
            System.Console.WriteLine("Enter your Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
           
            System.Console.WriteLine("Enter Your MobileNumber");
            long mobilenumber=long.Parse(Console.ReadLine());
           
            System.Console.WriteLine("Enter Your City:");
            string city=Console.ReadLine();
          
            BeneficiaryClass beneficiary=new BeneficiaryClass(name,gender,mobilenumber,city,age);
            BeneficiariesList.Add(beneficiary);
           
            System.Console.WriteLine($"Your Registration Number-{beneficiary.RegisterNumber}");
            
        }

        //Login
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number: ");
            string regnumber=Console.ReadLine();
            foreach (var tempReg in BeneficiariesList)
            {
                if(regnumber==tempReg.RegisterNumber)
                {
                    System.Console.WriteLine("Login Succesfull!!!!!!");
                    currentBeneficiary=tempReg;
                    SubMenu();
                }
            }
        }

        //Vaccine Information
        public static void GetVaccineInfo()
        {
            foreach (var vaccine in VaccinesList)
            {
                System.Console.WriteLine($"VaccineId: {vaccine.VaccineId}  Vaccine Name: {vaccine.VaccineName}  Dose Availability: {vaccine.NumberOfDoseAvailablity}");
            }

        }
        //Sub menu
        public static void SubMenu()
        {

            string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu\n1.Show My Detail\n2.TakeVaccination\n3.My Vaccination History\n4.Due Date\n5.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                    {
                                        System.Console.WriteLine("<<<<<<<<<<<< Show Detail >>>>>>>>>>>");
                                        MyDetails();
                                        break;
                                    }
                                    case 2:
                                    {
                                       System.Console.WriteLine("<<<<<<<<<<<< Take Vaccine >>>>>>>>>");
                                       TakeVaccination();
                                       break;
                                    }                                       
                                    case 3 :                                
                                    {    
                                        System.Console.WriteLine("<<<<<<<<<< My Vaccination History >>>>>>>>>>");
                                        MyVaccinationHistory();                             
                                        break;
                                    }
                                    case 4:
                                    {
                                        System.Console.WriteLine("<<<<<<< Due Date >>>>>>>");
                                        
                                        break;
                                    }
                                    case 5:  
                                    {
                                       System.Console.WriteLine("<<<<<<<<< Exit >>>>>>>>>");
                                        choice="no";
                                        break;                          
                                    }
                                    default:
                                        break;
                                }
                            }while(choice=="yes");

        }
        //1.Show My Detail
        public static void MyDetails()
        {      
            System.Console.WriteLine($"\nRegister Number: {currentBeneficiary.RegisterNumber},\nName: {currentBeneficiary.Name}\nGender: {currentBeneficiary.GenderSelect}\nMobilNumber: {currentBeneficiary.MobileNumber}\nCity: {currentBeneficiary.City}\nAge: {currentBeneficiary.Age}");
        }
       
        //2.Take Vaccination

        public static void TakeVaccination()
        {
        //Show the list of vaccine available to select a vaccine
        foreach (var vaccinedetails in VaccinesList)
        {
            System.Console.WriteLine($"VaccineId-  {vaccinedetails.VaccineId}    VaccineName-  {vaccinedetails.VaccineName}   No of Dose Available-   {vaccinedetails.NumberOfDoseAvailablity} ");  
        }
        
        
        //Select a vaccine by using vaccine ID
        System.Console.WriteLine("Enter Vaccine ID:");
        string vaccineid=Console.ReadLine();
        
        foreach (var tempvaccineId in VaccinesList)
        {
            if(vaccineid==tempvaccineId.VaccineId)
            System.Console.WriteLine("valid");
        }

        foreach (var tempvaccineId in VaccinesList)
        
        {
           
           if(vaccineid==tempvaccineId.VaccineId) 
           {
            foreach (var tempvacid in VaccinationsList)
            {
            if(currentBeneficiary.RegisterNumber==tempvacid.RegisterNumber)

            {
                 if(currentBeneficiary.Age>14 && tempvacid.DoseNumber==DoseNumber.Default)
              {
                tempvaccineId.NumberOfDoseAvailablity-=1;
                System.Console.WriteLine("Vaccinated 1st Dose");
                tempvacid.VaccinationDate=DateTime.Now;
               }
                if(tempvacid.DoseNumber==DoseNumber.One)
                {

                    System.Console.WriteLine("Dose 1 Completed");
                    tempvaccineId.NumberOfDoseAvailablity-=1;
                    System.Console.WriteLine("Vaccinated 2nd Dose");
                    tempvacid.VaccinationDate=DateTime.Now;

                    
                }
                else if(tempvacid.DoseNumber==DoseNumber.Two &&tempvacid.DoseNumber==DoseNumber.One)
                {

                    System.Console.WriteLine("Dose 2 Completed");
                    tempvaccineId.NumberOfDoseAvailablity-=1;
                    System.Console.WriteLine("Vaccinated 3rd Dose");

                }
                else if(tempvacid.DoseNumber==DoseNumber.Three&&tempvacid.DoseNumber==DoseNumber.Two &&tempvacid.DoseNumber==DoseNumber.One )
                {
                    System.Console.WriteLine("Dose 3 Completed");
                    System.Console.WriteLine("Already Taken....No more Doses");
                }
                else
                {
                    break;
                }
                 
            
            }
            }
             

           }
        }
        }
        //3.My Vaccination History
        public static void MyVaccinationHistory()
        {
            
            foreach (var tempvacid in VaccinationsList)
            {
                if(currentBeneficiary.RegisterNumber==tempvacid.RegisterNumber)
                {                
                   System.Console.WriteLine($"VaccinationId-  {tempvacid.VaccinationId}  BeneficiaryId-  {tempvacid.RegisterNumber}   VaccineId-   {tempvacid.VaccineId}   Dose Number-   {tempvacid.DoseNumber}   Vaccinated Date-   {tempvacid.VaccinationDate}");
                    currentVaccination=tempvacid;
                }
            }
        }
        //4.Next Due Date
        public static void NextDueDate()

        {
            
            foreach (var nextdue in VaccinationsList)
            {

            }


        }

        //Default Values

        public static void DefaultBeneficiary()
        {
            BeneficiariesList.Add(new BeneficiaryClass("Ravichandran",Gender.Male,868678,"Chennai",21));
            BeneficiariesList.Add(new BeneficiaryClass("Baskaran",Gender.Male,755678,"Chennai",22));

            
        }
        public static void DefaultVaccine()
        {

            VaccinesList.Add(new VaccineClass(VaccineName.Covidshield,50));
            VaccinesList.Add(new VaccineClass(VaccineName.Covaccine,50));
        
        }
        
        public static void DefaultVaccination()
        {

            VaccinationsList.Add(new VaccinationClass("CID101","BID1001",DoseNumber.One,new DateTime(2021/11/11)));
            VaccinationsList.Add(new VaccinationClass("CID101","BID1002",DoseNumber.Two,new DateTime(2022/03/11)));
            VaccinationsList.Add(new VaccinationClass("CID103","BID1003",DoseNumber.One,new DateTime(2022/04/04)));    
      
        }

    }
}