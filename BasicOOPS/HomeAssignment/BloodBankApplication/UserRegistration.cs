using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}

    public class UserRegisteration
    {
        private static int s_donorId=1000;
        public string DonorId { get; set; }
        public string DonorName { get; set; }
        public BloodGroup BloodGroup{ get; set; }
        public long PhoneNumber { get; set; }
        public int Age  { get; set; }
        public DateTime LastDonation { get; set; }

        public UserRegisteration(string donorid,BloodGroup bloodGroup,long phonenumber,int age,DateTime lastDonation)
        {
            s_donorId++;
            DonorId="UID"+s_donorId;
            BloodGroup=bloodGroup;
            Age=age;
            LastDonation=lastDonation;
        }


    }
}