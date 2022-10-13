using System;
namespace OnlineGroceryApplication
{
    public enum BookingStatus{Initiated,Booked,Cancelled}
    public class BookingDetails
    {

        private static int s_bookingid=3000;

        public string BookingID { get; set; }
        public string  CustomerID { get; }
        public double TotalPrice { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails (string customerID, double totalPrice, BookingStatus bookingStatus)
        {
            s_bookingid++;
            BookingID = "BID"+s_bookingid;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            BookingStatus = bookingStatus;
        }
        public BookingDetails (string data)
        {
            string[] values=data.Split(",");
            s_bookingid = int.Parse(values[0].Remove(0,3));
            BookingID = values[0];
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            BookingStatus = Enum.Parse<BookingStatus>(values[3],true);
        }
        
        public  void ShowBookingDetails()
        {
            System.Console.WriteLine($"{BookingID}\t{CustomerID}\t{TotalPrice}\t{BookingStatus}");
        }
        
        // BookingID, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.
    }
}