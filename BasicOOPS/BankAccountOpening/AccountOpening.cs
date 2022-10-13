using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening
{
    public enum Gender { Default,Male,Female,Transgender};
    public enum AccountType{ Default,SB,FD,RD};
    public class AccountOpening
    {
        private static int s_accountNumber=1007576000;
        public int AccountNumber {get;}
         public string Name { get; set; }
         public string FatherName { get; set; }
         public Gender Gender{ get; set; }
         public DateTime Dob { get; set; }
         public AccountType AccountType { get; set; }
         private double AccountBalance {get; set;}

         public AccountOpening(string name,string fathername,Gender gender,DateTime dob,AccountType accounttype)
         {
            s_accountNumber++;
            AccountNumber=s_accountNumber;
            Name=name;
            FatherName=fathername;
            Gender=gender;
            Dob=dob;
            AccountType=accounttype;
            
         }
         public void BankDeposit()
         {
            System.Console.WriteLine("Enter Amount Rs:");
            double amount=double.Parse(Console.ReadLine());
            if(amount>0)
            {
                AccountBalance=AccountBalance+amount;
                System.Console.WriteLine("Deposit successfully!!!");
            }
            else
            {
                System.Console.WriteLine("Deposit Unsuccessfull!!! try again!!!");
            }
            
         }
         public void Withdraw()
         {
            System.Console.WriteLine("Enter Amount Rs:");
            double amount=double.Parse(Console.ReadLine());
            if(amount>0&&amount<AccountBalance)
            {
                AccountBalance=AccountBalance-amount;
                System.Console.WriteLine("Withdraw Successfull!!!");
            }
            else
            System.Console.WriteLine("Insufficient balance!!!");
         }
         public void ShowBalance ()
         {
            System.Console.WriteLine("Your Balance Rs:"+AccountBalance);
         }

        
        
         
         
         
         
    }
}