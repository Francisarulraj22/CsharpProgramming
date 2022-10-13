using System;
namespace LibraryManagement;
class program
{
    public static void Main(string[] args)
    {
        Operations.DefaultBookDetails();
        Operations.DefaultBorrowBook();
        Operations.DefaultUserData();

        Operations.Mainmenu();
    }
        
    
}