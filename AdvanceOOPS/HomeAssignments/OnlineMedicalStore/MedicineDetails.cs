using System;
namespace OnlineMedicalStore
{
    public class MedicineDetails 
    {
        private static int s_medicineid=100;
        public string MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpire { get; set; }
        public MedicineDetails(string medicineName, int availableCount, double price, DateTime dateOfExpire)
        {
            s_medicineid++;
            MedicineId="MID"+s_medicineid;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpire = dateOfExpire;
        }
    }
}