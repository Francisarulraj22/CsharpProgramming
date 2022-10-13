using System;

namespace OnlineTheatreTicketBookingApplication
{
    /// <summary>
    /// UserDetails class have the properties and constructors of this class and it inherits Personal details class and Iwallet Interface.
    /// </summary>
    public class UserDetails:PersonalDetails,Iwallet
    {

        private static int s_userid=1000;
        public string UsedID { get; set; }
        public double WalletBalance { get; set; }

    
        public UserDetails(string name, int age, long phoneNumber) :base( name,age,phoneNumber)
        {
            s_userid++;
            UsedID="UID"+s_userid;     
        }
        public UserDetails(string data)
        {
            string[] values=data.Split(",");
            s_userid=int.Parse(values[0].Remove(0,3));
            UsedID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
            
        }
        public void RechargeWallet()
        {
                System.Console.WriteLine("\nDo You Want To Recharge :Yes/no");
                string choose=Console.ReadLine().ToLower();
                if(choose=="yes")
                {
                    System.Console.WriteLine("\nEnter the Amount To Recharge :");
                    double Amount=double.Parse(Console.ReadLine());
                    Operations.currentUser.WalletBalance+=Amount;
                    System.Console.WriteLine($"Total Balance Rs. {Operations.currentUser.WalletBalance}");

                }
                

        }
        


    }
}