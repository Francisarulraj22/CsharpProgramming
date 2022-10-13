using System;


namespace OnlineTheatreTicketBookingApplication;

    
    public class Operations
    {
        public static List<UserDetails>userList=new List<UserDetails>();
        public static List<TheatreDetails>TheatresList=new List<TheatreDetails>();
        public static List<MovieDetails>moviesList=new List<MovieDetails>();
        public static List<BookingDetails>bookingList=new List<BookingDetails>();

        public static List<ScreeningDetails>screenList=new List<ScreeningDetails>();
        
        public static UserDetails currentUser; 
        //Main Menu
        /// <summary>
        /// Mainmenu to choose the options
        /// </summary>
        public static void MainMenu()
        {
            string choice="yes";
           do
             {
                System.Console.WriteLine("\n\t<<<---------------- Main Menu ------------------>>>\n\t\t\t1. User Registration \n\t\t\t2. Login \n\t\t\t3. Exit");

                int option=int.Parse(Console.ReadLine());
                switch (option)
	            {
	                case 1:
	                {
	                    System.Console.WriteLine("<------------------ Registration ---------------->");
                        Registration();
	                    break;
	                }
	                case 2:
	                {
	                    System.Console.WriteLine("<------------------ Login ---------------->");
	                    Login();
                        break;
	                }
	                case 3:
	                {
	                    System.Console.WriteLine("Exit");
                        choice="no";
	                    break;
	                }
	                default:
	                   { 
                        break;
                       }
                    }
                     System.Console.WriteLine("Do You want to Continue in Main Menu: Yes/no");
                     choice=Console.ReadLine();
            } while (choice=="yes");
        }
        /// <summary>
        /// Getting User Details from User and Registration
        /// </summary>
        public static void Registration()
        {
            
            System.Console.WriteLine("Enter Your Name :");
            string Name=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Age :");
            int Age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your PhoneNumber :");
            long PhoneNumber=long.Parse(Console.ReadLine());

            // double WalletBalance;

            UserDetails user=new UserDetails(Name,Age,PhoneNumber);
            userList.Add(user);
            System.Console.WriteLine($"\nYour registration ID is : {user.UsedID}");

        }
        /// <summary>
        /// Login Option For User to enter 
        /// </summary>
        public static void Login()
        {
            System.Console.WriteLine("\nPlease Enter Your UserID :");
            string tempUserId=Console.ReadLine().ToUpper();
            int flag=1;
            foreach (UserDetails checkuser in userList)
            {
                if(tempUserId==checkuser.UsedID)
                {
                    System.Console.WriteLine("\n>>>>>>>>>> Login Successfully <<<<<<<<<<<");
                    currentUser=checkuser;
                    SubMenu();
                    flag=0;
                }   
            }
            if(flag==1)
            {
                System.Console.WriteLine("\n>>>>>>>>>> Invalid UserID <<<<<<<<<<<");
            }
        }
        /// <summary>
        /// After Logged In User Can Access this SubMenu
        /// </summary>
        public static void SubMenu()
        {       string choice="yes";
                do
                {
                    System.Console.WriteLine("\n\t<<<---------------- Sub Menu ------------------>>>\n\t\t\t1. Ticket Booking \n\t\t\t2. Ticket Cancellation \n\t\t\t3. Boooking History \n\t\t\t4. Wallet Recharge \n\t\t\t5. Exit");
                    int option=int.Parse(Console.ReadLine());
                    switch (option)
	            {
	                case 1:
	                {
	                    System.Console.WriteLine("<------------------ Ticket Booking ---------------->");
                        TicketBooking();
	                    break;
	                }
	                case 2:
	                {
	                    System.Console.WriteLine("<------------------ Ticket Cancellation ---------------->");
	                    TicketCancellation();
                        break;
	                }
                    case 3:
	                {
	                    System.Console.WriteLine("<------------------ Booking History ---------------->");
	                    BookingHistory();
                        break;
	                }
                    case 4:
	                {
	                    System.Console.WriteLine("<------------------ Wallet Recharge ---------------->");
	                    currentUser.RechargeWallet();
                        break;
	                }
	                case 5:
	                {
	                    System.Console.WriteLine("<<<<<<<------<<<< Exiting Sub Menu <<<<<<<------<<<");
                        choice="no";
	                    break;
	                }
	                default:
	                   { 
                        break;
                       }
                    }
                     System.Console.WriteLine("Do You want to Continue in SubMenu: Yes/no");
                     choice=Console.ReadLine();

                } while (choice=="yes");
        }
        /// <summary>
        /// This is the Option For Movie TicketBooking 
        /// </summary>
        public static void TicketBooking()
        {
            System.Console.WriteLine("\nYou Have entered TicketBooking\n");
            foreach (TheatreDetails theatres in TheatresList)
            {
                System.Console.WriteLine($"Theatre Id : {theatres.TheatreID}\tTheatre Name : {theatres.TheatreName}\t Theatre Location : {theatres.TheatreLocation}");
            }
            System.Console.WriteLine("\nPlease Select Your Theatre Id :");
            string tempTheatreId=Console.ReadLine().ToUpper();

            foreach (MovieDetails movies in moviesList)
            {
                System.Console.WriteLine($"Movie ID: {movies.MovieID}\t Movie Name : {movies.MovieName}\t Language : {movies.Language}");
                
            }
            foreach (TheatreDetails checktheatre in TheatresList)
            {
                if(tempTheatreId==checktheatre.TheatreID)
                {
                    foreach (ScreeningDetails checksreens in screenList)
                    {
                        if(tempTheatreId==checksreens.TheatreID)
                        {
                            System.Console.WriteLine($"Movie ID : {checksreens.MovieID}\tTheatre ID : {checksreens.TheatreID}\t Ticket Price : {checksreens.TicketPrice}\t Seat Availability : {checksreens.NoOfSeatsAvailable}");
                         
                        }                 
                    }
                }
                    else{
                    break;
                    }
            
                        System.Console.WriteLine("PLease Choose The Movie Id To Book : ");
                        string tempMovieID=Console.ReadLine().ToUpper();
                        System.Console.WriteLine("Choose the Seat Count :");
                        int tempSeatCount=int.Parse(Console.ReadLine());

                        foreach(ScreeningDetails checksreens in screenList) 
                        {
                        
                            if(tempSeatCount>checksreens.NoOfSeatsAvailable)
                            {
                                System.Console.WriteLine($"Required Seat count not available. Current availability is {checksreens.NoOfSeatsAvailable}");
                            }
                            else if(tempSeatCount<=checksreens.NoOfSeatsAvailable)
                            {
                                double tax = (tempSeatCount*checksreens.TicketPrice)/0.18;
                                double sum=tempSeatCount*checksreens.TicketPrice;
                                double totalAmount =sum+tax;
                                System.Console.WriteLine($"\nTotal Amount : {totalAmount}\n");
                                if(currentUser.WalletBalance>=totalAmount)
                                {
                                   System.Console.WriteLine("Do you Want to Book Tickets...Please Confirm it.   Yes/No");
                                    string check=Console.ReadLine().ToLower();
                                    
                                if (check=="yes")
                                {
	
	                                    currentUser.WalletBalance-=totalAmount;
	                                    checksreens.NoOfSeatsAvailable-=tempSeatCount;
	                                    foreach (BookingDetails checkbooking in bookingList)
	                                    {
	                                        checkbooking.BookingStatus=BookingStatus.Booked;
	                                        checkbooking.TotalAmount=totalAmount;   
	                                    }
	                                    System.Console.WriteLine($"Tickets Booked\nYour Balance : Rs. {currentUser.WalletBalance}");
                                        break;
                                }
                                }
                                else
                                {
                                    System.Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet");
                                    System.Console.WriteLine("If want to Recharge Just Type Yes/no");
                                    string check=Console.ReadLine().ToLower();
                                    if(check=="yes")
                                    {
                                        currentUser.RechargeWallet();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    
                                }

                    } 
                }
            }


        }
        /// <summary>
        /// Ticket Cancellation is Used To Cancel booked Ticket
        /// </summary>
        public static void TicketCancellation()
        {
            foreach (BookingDetails checkbooking in bookingList)
            {
                System.Console.WriteLine($"{checkbooking.BookingID}\t{checkbooking.UserID}\t{checkbooking.MovieID}\t{checkbooking.TheatreID}\t{checkbooking.SeatCount}\t{checkbooking.TotalAmount}\t{checkbooking.BookingStatus}");
            }
            System.Console.WriteLine("Enter Booking Id To Cancel :");
            string cancel=Console.ReadLine().ToUpper();
            foreach (BookingDetails checkbooking in bookingList)
            {
                if(checkbooking.UserID==cancel)
                {
                    checkbooking.BookingStatus=BookingStatus.Cancelled;
                    currentUser.WalletBalance+=checkbooking.TotalAmount;
                    checkbooking.SeatCount--;
                    foreach (ScreeningDetails screens in screenList)
                    {
                        screens.NoOfSeatsAvailable+=checkbooking.SeatCount;
                    }

                    System.Console.WriteLine($"Ticekt Cancelled \n\nYour Balance : {currentUser.WalletBalance}");
                }
                else
                {
                    System.Console.WriteLine("No Bookings Available!!!");
                }
            }
        }
        /// <summary>
        /// Booking History -It Shows the History of Booking
        /// </summary>
        public static void BookingHistory()
        {
            foreach (BookingDetails checkbooking in bookingList)
            {
                System.Console.WriteLine($"{checkbooking.BookingID}\t{checkbooking.UserID}\t{checkbooking.MovieID}\t{checkbooking.TheatreID}\t{checkbooking.SeatCount}\t{checkbooking.TotalAmount}\t{checkbooking.BookingStatus}");
            }
            System.Console.WriteLine("-------------->>> No More History <<<---------------");
        }
     
        
    }
