using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening
{
    public class Operations
    {
        static AccountOpening currentaccount=null;
        static List<AccountOpening> AccountList=new List<AccountOpening>();
        
           public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                Console.WriteLine("Select Option\n1.Registration\n2.Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
            switch (option)
               {
                case 1:
                
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                
                case 2:
                
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                   
                case 3:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
                default:
                
                    break;
                
                }
                
            }while(choice=="yes");

        }
        public static void Registration()
        {
             System.Console.WriteLine("Enter your Name:");
                string name1=Console.ReadLine();
                
                System.Console.WriteLine("Enter your Father's Name:");
                string fatherName=Console.ReadLine();
                
                System.Console.WriteLine("Enter your Gender:");
                Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
                
                System.Console.WriteLine("Enter your DateofBirth:");
                DateTime dateofBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                
                System.Console.WriteLine("Enter your Account Type:");
                AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);
                
                
                AccountOpening account=new AccountOpening(name1,fatherName,gender1,dateofBirth,accountType);
                // account.BankDeposit();
                // account.Withdraw();
                // account.ShowBalance();
                AccountList.Add(account);
                System.Console.WriteLine("Account number:"+account.AccountNumber);

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter Your RegisterNumber:");
            long AccountNumber=int.Parse(Console.ReadLine());
          foreach (AccountOpening accounts in AccountList)
          {
            if(accounts.AccountNumber==AccountNumber)     
            {
            System.Console.WriteLine("Login Succesfull!!!");
            currentaccount=accounts;
            SubMenu();
            }
          }    
        }
         public static void SubMenu()
                    {
                        
                        string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu\n1.Bank Deposit\n2.Withdraw\n3.Show Balance\n4.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                    
                                        System.Console.WriteLine("Bank Deposit:");
                                        currentaccount.BankDeposit();
                                        break;
                                    
                                    case 2:
                                    
                                        System.Console.WriteLine("Withdraw");
                                        currentaccount.Withdraw();
                                        break;
                                     
                                    case 3:
                                    
                                        System.Console.WriteLine("Show Balance:");
                                        currentaccount.ShowBalance();
                                        break;
                                     
                                    case 4:
                                    
                                        System.Console.WriteLine("Exit Submenu");
                                        choice="no";
                                        break;
                                    
                                    default:
                                    
                                        break;
                                    
                                }
                            }while(choice=="yes");


    }
}}