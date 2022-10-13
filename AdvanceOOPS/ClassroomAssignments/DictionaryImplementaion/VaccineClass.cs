using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication;
    public enum VaccineName{Default,Covidshield,Covaccine}
    public class VaccineClass
    {
            public static int s_vaccineId=1000;

        public string VaccineId{ get; }

        public VaccineName VaccineName { get; set; }
        public int NumberOfDoseAvailablity { get; set; }
        public VaccineClass(VaccineName vaccinename,int numberOfDoseAvailable)
        {
            s_vaccineId++;
            VaccineId="VID"+s_vaccineId;
            VaccineName=vaccinename;
            NumberOfDoseAvailablity=numberOfDoseAvailable;

        }
        public VaccineClass(string Vacdata)
        {
            string[] vacValue=Vacdata.Split(',');
            s_vaccineId=int.Parse(vacValue[0].Remove(0,3));
            VaccineId=vacValue[0];
            VaccineName=Enum.Parse<VaccineName>(vacValue[1],true);
            NumberOfDoseAvailablity=int.Parse(vacValue[2]);
        }
    }
