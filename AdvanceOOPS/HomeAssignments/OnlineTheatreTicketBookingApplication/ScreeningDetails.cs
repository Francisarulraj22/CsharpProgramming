

namespace OnlineTheatreTicketBookingApplication
{
    /// <summary>
    /// ScreeningDetails class have the properties and constructors of this class
    /// </summary>
    public class ScreeningDetails
    {
    
        public  string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int NoOfSeatsAvailable { get; set; }
        public double TicketPrice { get; set; }

        public ScreeningDetails(string movieID, string theatreID, int noOfSeatsAvailable, double ticketPrice)
        {
            MovieID = movieID;
            TheatreID = theatreID;
            NoOfSeatsAvailable = noOfSeatsAvailable;
            TicketPrice = ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string[] values=data.Split(",");
            MovieID =values[0];
            TheatreID = values[1];
            TicketPrice = double.Parse(values[2]);
    
            NoOfSeatsAvailable =int.Parse(values[3]);
        }
    }
}