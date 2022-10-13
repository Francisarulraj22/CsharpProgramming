using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankOperation;
public class Operations
{
    public static void MainMenu()
    {
        List<AccountOpening> AccountList=new List<AccountOpening>();
        System.Console.WriteLine("Do you Want to create Account.....\n Yes or No");
        string choice=Console.ReadLine().ToLower();
        
        while(choice=="yes")
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
                account.BankDeposit();
                account.Withdraw();
                account.ShowBalance();
                System.Console.WriteLine("Read Data....\n Admitted.....");
                AccountList.Add(account);
                System.Console.WriteLine("Do you Want to create Account.....\n Yes or No");
                choice=Console.ReadLine().ToLower();
                

        }
        foreach (var accountholders in AccountList)
        {
            System.Console.WriteLine("<<<<<<<<<<  Account Details  >>>>>>>>\n");
            System.Console.WriteLine($"   Account Number: {accountholders.AccountNumber}\n   Name: {accountholders.Name}\n   Father's Name: {accountholders.FatherName}\n   Gender: {accountholders.Gender}\n   Date of Birth: {accountholders.Dob}\n   Account Type: {accountholders.AccountType}\n ");
        }

       
    }
}