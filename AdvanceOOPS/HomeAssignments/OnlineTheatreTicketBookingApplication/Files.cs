using System.IO;

namespace OnlineTheatreTicketBookingApplication
{
    public class Files
    {
        public static void CreateFile()
        {
            if(!Directory.Exists("OnlineTheatreTicketBookingApplication"))
            {
                Directory.CreateDirectory("OnlineTheatreTicketBookingApplication");
            }
            else
            {
                System.Console.WriteLine("Found Directory");
            }
            if(!File.Exists("OnlineTheatreTicketBookingApplication/UserDetails.csv"))
            {
                File.Create("OnlineTheatreTicketBookingApplication/UserDetails.csv");
            }
            else
            {
                System.Console.WriteLine("File Found");
            }
            if(!File.Exists("OnlineTheatreTicketBookingApplication/BookingDetails.csv"))
            {
                File.Create("OnlineTheatreTicketBookingApplication/BookingDetails.csv");
            }
            else
            {
                System.Console.WriteLine("File Found");
            }
            if(!File.Exists("OnlineTheatreTicketBookingApplication/MovieDetails.csv"))
            {
                File.Create("OnlineTheatreTicketBookingApplication/MovieDetails.csv");
            }
            else
            {
                System.Console.WriteLine("File Found");
            }
            if(!File.Exists("OnlineTheatreTicketBookingApplication/ScreeningDetails.csv"))
            {
                File.Create("OnlineTheatreTicketBookingApplication/ScreeningDetails.csv");
            }
            else
            {
                System.Console.WriteLine("File Found");
            }
            if(!File.Exists("OnlineTheatreTicketBookingApplication/TheatreDetails.csv"))
            {
                File.Create("OnlineTheatreTicketBookingApplication/TheatreDetails.csv");
            }
            else
            {
                System.Console.WriteLine("File Found");
            }
        }
        /// <summary>
        /// Read File For All Lists
        /// </summary>
        /// <returns></returns>
        public static void ReadFile()
        {
            string[] Array=File.ReadAllLines("OnlineTheatreTicketBookingApplication/UserDetails.csv");
            foreach (var users in Array)
            {
                    UserDetails userObject=new UserDetails(users);
                    Operations.userList.Add(userObject);   
            }

            string[] Array1=File.ReadAllLines("OnlineTheatreTicketBookingApplication/BookingDetails.csv");
            foreach (var bookings in Array1)
            {
                    BookingDetails bookingObject=new BookingDetails(bookings);
                    Operations.bookingList.Add(bookingObject);   
            }

            string[] Array2=File.ReadAllLines("OnlineTheatreTicketBookingApplication/MovieDetails.csv");
            foreach (var movies in Array2)
            {
                    MovieDetails movieObject=new MovieDetails(movies);
                    Operations.moviesList.Add(movieObject);   
            }

            string[] Array3=File.ReadAllLines("OnlineTheatreTicketBookingApplication/ScreeningDetails.csv");
            foreach (var screens in Array3)
            {
                    ScreeningDetails screenObject=new ScreeningDetails(screens);
                    Operations.screenList.Add(screenObject);   
            }
        
            string[] Array4=File.ReadAllLines("OnlineTheatreTicketBookingApplication/TheatreDetails.csv");
            foreach (var theatres in Array4)
            {
                    TheatreDetails TheatreObject=new TheatreDetails(theatres);
                    Operations.TheatresList.Add(TheatreObject);   
            }
        }
        public static void WriteFile()
        {
            string[] array=new string[Operations.userList.Count];
            int i=0;
            foreach (UserDetails users in Operations.userList)
            {
               array[i]=users.UsedID+","+users.Name+","+users.Age+","+users.PhoneNumber+","+users.WalletBalance; 
               i++;
          
            }  File.WriteAllLines("OnlineTheatreTicketBookingApplication/UserDetails.csv",array);
            
            string[] array1=new string[Operations.bookingList.Count];
            i=0;
            foreach (BookingDetails bookings in Operations.bookingList)
            {
               array1[i]=bookings.BookingID+","+bookings.UserID+","+bookings.MovieID+","+bookings.TheatreID+","+bookings.SeatCount+","+bookings.TotalAmount+","+bookings.BookingStatus;
               i++; 
            //    BID7001,UID1001,MID501,TID301,1,200,Booked
          
            }  File.WriteAllLines("OnlineTheatreTicketBookingApplication/BookingDetails.csv",array1);


            string[] array3=new string[Operations.moviesList.Count];
            i=0;
            foreach (MovieDetails movies in Operations.moviesList)
            {
               array3[i]=movies.MovieID+","+movies.MovieName+","+movies.Language; 
               i++;
           
            }  File.WriteAllLines("OnlineTheatreTicketBookingApplication/MovieDetails.csv",array3);


            string[] array4=new string[Operations.userList.Count];
            i=0;
            foreach (ScreeningDetails screens in Operations.screenList)
            {
               array4[i]=screens.MovieID+","+screens.TheatreID+","+screens.TicketPrice+","+screens.NoOfSeatsAvailable; 
          
            }  File.WriteAllLines("OnlineTheatreTicketBookingApplication/ScreeningDetails.csv",array4);

            string[] array5=new string[Operations.TheatresList.Count];
            i=0;
            foreach (TheatreDetails theatres in Operations.TheatresList)
            {
               array5[i]=theatres.TheatreID+","+theatres.TheatreID+","+theatres.TheatreName+","+theatres.TheatreLocation; 
           
            }  File.WriteAllLines("OnlineTheatreTicketBookingApplication/TheatreDetails.csv",array5);
        }
      
        }
}
