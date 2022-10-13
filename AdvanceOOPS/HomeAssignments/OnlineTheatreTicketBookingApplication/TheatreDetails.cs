

namespace OnlineTheatreTicketBookingApplication
{
    /// <summary>
    /// TheatreDetails class have the properties and constructors of this class
    /// </summary>
    public class TheatreDetails
    {
        //  Properties:
        //  TheatreID(Auto Increment – TID301)
        // 	heatreName
        // 	TheatreLocation
        private static int s_theatreid=300;
        public string TheatreID { get; set; }
        public string  TheatreName { get; set; }
        public string TheatreLocation { get; set; }

        public TheatreDetails(string theatreID, string theatreName, string theatreLocation)
        {
            s_theatreid++;
            TheatreID = "TID"+s_theatreid;
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;
        }
        public TheatreDetails(string data)
        {
            string[] values=data.Split(",");
            s_theatreid=int.Parse(values[0].Remove(0,3));
            TheatreID = values[0];
            TheatreName = values[1];
            TheatreLocation = values[2];
        }
    }
}