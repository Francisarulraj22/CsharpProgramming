using System;
using System.IO;

namespace OnlineMedicalStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineMedicalStore"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("OnlineMedicalStore");
            }
            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/UserDetails.csv");
            }
            if(!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/MedicineDetails.csv");
            }
            if(!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("OnlineMedicalStore/OrderDetails.csv");
            }

        }
        public static void ReadFile()
        {
            string[] Userreg=File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach (var data in Userreg)
            {
                UserDetails user1=new UserDetails(data);
                Operation.userList.Add(user1);
            }
            string[] MedArray=File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach (var data in Userreg)
            {
                UserDetails user1=new UserDetails(data);
                Operation.userList.Add(user1);
            }
            string[] Orderarray=File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach (var data in Userreg)
            {
                UserDetails user1=new UserDetails(data);
                Operation.userList.Add(user1);
            }

        }
        public static void WriteToFiles()
        {
            string[] UserDetails=new string[Operation.userList.Count];
            for (var i = 0; i < Operation.userList.Count; i++)
            {
                UserDetails[i]=Operation.userList[i].UserId+Operation.userList[i].Name+Operation.userList[i].Age+Operation.userList[i].City+Operation.userList[i].PhoneNumber+Operation.userList[i].Balance;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",UserDetails);

            string[] MedicineDetails=new string[Operation.medicaldetailList.Count];
            for (var i = 0; i < Operation.medicaldetailList.Count; i++)
            {
                MedicineDetails[i]=Operation.medicaldetailList[i].MedicineId+Operation.medicaldetailList[i].MedicineName+Operation.medicaldetailList[i].AvailableCount+Operation.medicaldetailList[i].Price+Operation.medicaldetailList[i].DateOfExpire;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",MedicineDetails);
        
            string[] OrderDetails=new string[Operation.orderList.Count];
            for (var i = 0; i < Operation.orderList.Count; i++)
            {
                OrderDetails[i]=Operation.orderList[i].OrderId+Operation.orderList[i].MedicineId+Operation.orderList[i].MedicineCount+Operation.orderList[i].ToatalPrice+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",MedicineDetails);
    
        }
    }
}