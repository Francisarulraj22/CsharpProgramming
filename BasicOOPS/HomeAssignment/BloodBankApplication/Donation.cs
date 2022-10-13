using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication;
   
    public class Donation
    {
       
        private static int s_donoationrId=1000;
        public string DonorId { get; }
        public string Donorname { get; set; }
        public long MobileNumber { get; set; }
        public  double Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HemoglobinCount { get; set; }
       
        public Donation(string donorid,string donorname,long mobilenumber,double weight,double bloodPressure,double hemoGlobinCount)
        {

            DonorId=donorid;
            Donorname=donorname;
            MobileNumber=mobilenumber;
            Weight=weight;
            BloodPressure=bloodPressure;
            HemoglobinCount=hemoGlobinCount;
       
        }
    }

    



