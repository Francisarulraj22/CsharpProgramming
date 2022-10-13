using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBookingApplication
{
    public enum BookingStatus{Booked,Cancelled}
        /// <summary>
        /// BookingDetails Class that Contains Properties and Constructors
        /// </summary>
        /// <value></value>
    public class BookingDetails
    {
        private static int s_bookingid=7000;

        // Property of bookingId 
         public string BookingID { get; set; }

        // Property of UserId 
        public string UserID { get; set; }

        // Property of MovieId 
        public string MovieID { get; set; }

        // Property of TheatreID 
        public string TheatreID  { get; set; }

        // Property of SeatCount 
        public int SeatCount { get; set; }

        // Property of Total Amount 
        public double TotalAmount { get; set; }

        // Property of Booking Status  
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string userID,string movieID, string theatreID, int seatCount, double totalAmount, BookingStatus bookingStatus)
        {
            s_bookingid++;
            BookingID = "BID"+s_bookingid;
            UserID=userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
        }
         public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingid=int.Parse(values[0].Remove(0,3));
            BookingID = values[0];
            UserID= values[1];
            MovieID = values[2];
            TheatreID = values[3];
            SeatCount = int.Parse(values[4]);
            TotalAmount = double.Parse(values[5]);
            BookingStatus = Enum.Parse<BookingStatus>(values[6],true);
        }

 
    }
}