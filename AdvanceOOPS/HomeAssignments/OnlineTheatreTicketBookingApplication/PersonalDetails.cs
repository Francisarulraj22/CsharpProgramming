

namespace OnlineTheatreTicketBookingApplication
{
    /// <summary>
    /// Personal Detail class have the properties and constructors of this class
    /// </summary>
    public class PersonalDetails
    {
       

        // Name
        // Age
        // PhoneNumber
    public string  Name { get; set; }
    public int Age { get; set; }
    public long PhoneNumber { get; set; }
    public PersonalDetails(string name, int age, long phoneNumber)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }
     public PersonalDetails()
        {
        }
    

    }
}