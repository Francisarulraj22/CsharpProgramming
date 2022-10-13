using System;
using System.Collections.Generic;
namespace CovidApplication;
class program
{


    public static BeneficiaryClass currentBeneficiary=null;
    public static VaccineClass currentVaccine=null;
    public static VaccinationClass currentVaccination=null;
    public static Dictionary<string,BeneficiaryClass>Bdict=new Dictionary<string, BeneficiaryClass>();
    public  static Dictionary<string,VaccineClass>Vdict=new Dictionary<string, VaccineClass>();
    public static Dictionary<string,VaccinationClass>VacDict=new Dictionary<string, VaccinationClass>();
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
    //CovidApplication<string,BeneficiaryClass> person=new CovidApplication<string,BeneficiaryClass>();
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
            string reg=beneficiary.RegisterNumber;
            Bdict.Add(reg,beneficiary);
            
            System.Console.WriteLine($"Your Registration Number-{reg}");    
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number: ");
            string regnumber=Console.ReadLine();
            {
                if(Bdict.ContainsKey(regnumber))
                {

                    System.Console.WriteLine("Login Succesfull!!!!!!");
                    SubMenu();
                
                }
            }
        } 
          public static void GetVaccineInfo()
        {
            foreach (KeyValuePair<string,VaccinationClass> vinfo in VacDict)
            {
               
                System.Console.WriteLine($"{vinfo.Key} va{vinfo.Value.VaccineId}");
            // VID1001,CID101,BID1001,One,07/10/2022
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
                                      
                                        break;
                                    }
                                    case 2:
                                    {
                                       System.Console.WriteLine("<<<<<<<<<<<< Take Vaccine >>>>>>>>>");
                                 
                                       break;
                                    }                                       
                                    case 3 :                                
                                    {    
                                        System.Console.WriteLine("<<<<<<<<<< My Vaccination History >>>>>>>>>>");
                                                                   
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

        // VID1001,CID101,BID1001,One,07/10/2022
    public static void Main(string[] args)
    {   
        
        Files.Create();
        Files.ReadFile();
        program.Mainmenu();
        // Files.WriteFile();
        

    }
        
    
}

