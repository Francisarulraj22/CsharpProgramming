using System;
namespace OnlineMedicalStore
{
    public enum OrderStatus{Purchased,Cancelled}
    public class OrderDetails 
    {

        private static int s_orderid=2000;
        public string OrderId { get; set; }
        public int MedicineCount  { get; set; }
        public double ToatalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; }
        public string MedicineId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderDetails(string userId,string orderId,string medicineId, int medicineCount, double toatalPrice, DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderid++;
            OrderId = "OID"+s_orderid;
            UserId=userId;
            MedicineId=medicineId;
            MedicineCount = medicineCount;
            ToatalPrice = toatalPrice;
            OrderDate = orderDate;
            OrderStatus=orderStatus;
        }

    }
}