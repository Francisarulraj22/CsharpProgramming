using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public enum Branch{Default,Tambaram,Chetpet,AnnaNagar}
    public class AccountInfo:PersonalInfo 
    {
        private static int s_registernumber=1000;
        public string RegisterNumber { get; set; }
        public string IFSCCode{ get; set; }
        public Branch Branch { get; set; }
        public int Balance { get; set; } 
        public AccountInfo(string name,string fatherName ,DateTime datofBirth,Gender gender,long PhoneNumber,string mailId,string ifscCode,Branch branch,int balance ):base( name, fatherName , datofBirth, gender, PhoneNumber, mailId)
        {
            s_registernumber++;
            RegisterNumber="AID"+s_registernumber;
            IFSCCode=ifscCode;
            Branch=branch;
            Balance=balance;
        }
        public void Deposit()
        {
            System.Console.WriteLine("Enter the amount you want to deposit:");
            int amount=int.Parse(Console.ReadLine());
            Balance=amount;
        }
        public void ShowAccountInfo()
        {
            
            System.Console.WriteLine($"AccountNumber:{RegisterNumber}\nIFSCCode:{IFSCCode}\nBranch:{Branch}\nBalance:Rs.{Balance}");
            ShowDetail();
        }
    }
}