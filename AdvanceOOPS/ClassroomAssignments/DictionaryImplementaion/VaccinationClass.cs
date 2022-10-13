using System;
namespace CovidApplication;

    public enum DoseNumber{Default,One,Two,Three}

    public class VaccinationClass
    {
        public static int s_vaccinationId=1000;
        public string RegisterNumber { get;}
        public string VaccineId{ get; }

        public string VaccinationId{ get; set; }
        public DoseNumber DoseNumber { get; set; }
        public DateTime VaccinationDate { get; set; }
        public VaccinationClass(string vaccineId,string registerNumber,DoseNumber doseNumber,DateTime vaccinationDate)
        {
            s_vaccinationId++;
            RegisterNumber=registerNumber;
            VaccineId=vaccineId;
            VaccinationId="VID"+s_vaccinationId;
            DoseNumber=doseNumber;
            VaccinationDate=vaccinationDate;
        }
        public VaccinationClass(string Vdata)
        {
            string[] Vvalue=Vdata.Split(',');
            s_vaccinationId=int.Parse(Vvalue[0].Remove(0,3));
            RegisterNumber=Vvalue[1];
            VaccineId=Vvalue[2];
            VaccinationId=Vvalue[0];
            DoseNumber=Enum.Parse<DoseNumber>(Vvalue[3],true);
            VaccinationDate=DateTime.ParseExact(Vvalue[4],"dd/MM/yyyy",null);
        }
        


    }
