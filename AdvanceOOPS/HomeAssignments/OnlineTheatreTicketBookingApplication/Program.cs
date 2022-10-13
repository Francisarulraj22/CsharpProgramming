
namespace OnlineTheatreTicketBookingApplication;
class program
{
    public static void Main(string[] args)
    {
        
        Files.CreateFile();
        Files.ReadFile();
        Operations.MainMenu(); 
        Files.WriteFile();
    }
}