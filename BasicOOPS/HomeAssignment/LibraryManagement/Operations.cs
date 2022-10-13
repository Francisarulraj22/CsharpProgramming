using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement;


    public class Operations
    {
        
        static string currentuserId=null;
        static List<Booking>BookList=new List<Booking>();
        static List<BorrowDetails>BorrowList=new List<BorrowDetails>();
        static List<UserRegistration>UserList=new List<UserRegistration>();


        public static void Mainmenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Menu:\n1.User Registration\n2.User Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("<<<<<<<<<< User registration >>>>>>>>");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("<<<<<<<<<< User Login >>>>>>>>>>>>>");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        choice="no";
                        break;
                    }

                    default:
                    break;
                }
                
            } while (choice=="yes");
        }

        public static void SubMenu()
        {


 string choice="yes";
            do
            {
                System.Console.WriteLine("Menu:\n1.BorrowBook\n2.Show Return Date \n3.Show Borrowed History\n4.Return Book\n5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("<<<<<<<<<< Borrow Book >>>>>>>>");
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("<<<<<<<<<< Show Returned Date >>>>>>>>>>>>>");
                       
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("<<<<<<<<<< Show Borrowed History>>>>>>>>>");
                        ViewBorrowedHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("<<<<<<<<<<< Return Books >>>>>>>>>>");
                        ReturnBook();
                        break;
                    }
                    case 5:
                    {
                        choice="no";
                        break;
                    }
                    default:
                    break;
                }
                
            } while (choice=="yes");
        

        }
       public static void UserRegistration()
       {
        System.Console.WriteLine("Enter Name:");
        string Name=Console.ReadLine();
        System.Console.WriteLine("Enter Gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);   
        System.Console.WriteLine("Enter your Department:");  
        Department Department=Enum.Parse<Department>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter Mobile Number:");
        long Number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Mail Id:");
        string MailId=Console.ReadLine();
        UserRegistration user=new UserRegistration(Name,gender,Department,Number,MailId);
        UserList.Add(user);
        System.Console.WriteLine($"Your UserId:{user.Userregistration}");
        currentuserId=user.Userregistration; 
       }
       public static void UserLogin()
       {
        System.Console.WriteLine("Enter your RegisterId:");
        string Userid=Console.ReadLine();
        foreach (var tempreg in UserList)
        {
           if(Userid==tempreg.Userregistration)
        {
            System.Console.WriteLine("Login Successfull!!!!");
            SubMenu();
        }
        else
        {
            System.Console.WriteLine("xxxxxxxxxxx Invalid User Id xxxxxxxxxxx");
        } 
        }
        
       }

        public static void BorrowBook()
        {
            foreach (var books in BookList)
            {
                System.Console.WriteLine($"BookID- {books.BookId}   Book Name-  {books.BookName}   Author Name-{books.AuthorName}   No.of Books-  {books.Count}");
            }
            System.Console.WriteLine("Choose the Book Id:");
            string needbookid=Console.ReadLine();
            foreach (var tempbook in BookList)
            {
                if(needbookid==tempbook.BookId)
                {
                    int count=0;
                    foreach (var tempcheck in BorrowList)
                    {
                        if(currentuserId==tempcheck.UserId)
                        {
                            System.Console.WriteLine("You can enroll for 3 books maximum at a time");
                        
                        }   
                        else
                        {
                           tempcheck.Status-=1; 
                        }
                        count++; 
                    } 
                    

                    
                }
                else
                {
                    System.Console.WriteLine("Books are not available for the selected count");
                    foreach (var tempborrow in BorrowList)
                    {
                        if(needbookid==tempborrow.BookId)
                        {
                         System.Console.WriteLine($"The book will be available on {tempborrow.BorrowDate.AddDays(15)}");
                        }
                    }
                }
            }


        }
        public static void ReturnBook()
        {
            foreach (var tempreturn in BorrowList)
            {
                if(currentuserId==tempreturn.UserId)
                {
                    System.Console.WriteLine($"Return day Will be {tempreturn.BorrowDate.AddDays(15).ToString("dd/MM/yyyy")}");
                }
                else if(tempreturn.BorrowDate>tempreturn.BorrowDate.AddDays(15))
                {
                
                }
            }
        }


        public static void ViewBorrowedHistory()
        {
            foreach (var temoborrowbook in BorrowList)
            {
             System.Console.WriteLine($"BOrrowID-  {temoborrowbook.BorrowId}   BookID- {temoborrowbook.BookId}   RegistrationId-  {temoborrowbook.UserId}  BorrowDate-  {temoborrowbook.BorrowDate}  Status- {temoborrowbook.Status}");
            }
        }
    public static void DefaultUserData()
    {
         UserList.Add(new UserRegistration("Ravichandran",Gender.Male,Department.EEE,8756798,"ravi@gmail.com")); 
         UserList.Add(new UserRegistration("Priyadarshini",Gender.Female,Department.CSE,7609877,"priya@gmail.com"));

    }
    public static void DefaultBookDetails()
    {
        BookList.Add(new Booking("BID101","C#","Author1",3));
        BookList.Add(new Booking("BID102","HTML","Author2",5));
        BookList.Add(new Booking("BID103","CSS","Author1",3));
        BookList.Add(new Booking("BID104","JS","Author1",3));
        BookList.Add(new Booking("BID105","TS","Author2",2));
    }
    public static void DefaultBorrowBook()
    {
        
        BorrowList.Add(new BorrowDetails("LB301","BID101","SF3001",new DateTime(2022,04,10),Status.Issued));
        BorrowList.Add(new BorrowDetails("LB302","BID103","SF3001",new DateTime(2022,04,12),Status.Returned));
        BorrowList.Add(new BorrowDetails("LB303","BID104","SF3001",new DateTime(2022,04,15),Status.Issued)); 
        BorrowList.Add(new BorrowDetails("LB304","BID102","SF3002",new DateTime(2022,04,11),Status.Returned));
        BorrowList.Add(new BorrowDetails("LB305","BID105","SF3002",new DateTime(2022,04,15),Status.Issued)); 
    }
     


    }

