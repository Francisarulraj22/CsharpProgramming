using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBookingApplication
{
    /// <summary>
    /// MovieDetails Detail class have the properties and constructors of this class
    /// </summary>
    public class MovieDetails
    {
        
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }
        public MovieDetails(string movieID, string movieName, string language)
        {
            MovieID = movieID;
            MovieName = movieName;
            Language = language;
        }
        public MovieDetails(string data)
        {
            string[] values=data.Split(",");
            MovieID = values[0];
            MovieName = values[1];
            Language = values[2];
        }


        
    }
}