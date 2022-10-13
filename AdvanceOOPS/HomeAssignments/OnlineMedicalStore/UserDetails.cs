using System;
namespace OnlineMedicalStore
{
    public class UserDetails
    {
       
        private static int s_userid=1000;
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Age  { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public int MyProperty { get; set; }
        public double Balance { get; set; }

        public UserDetails(string name, int age, string city, long phoneNumber, double balance)
        {
            s_userid++;
            UserId="UID"+s_userid;
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }
        public UserDetails(string data)
        {
            string[] values = data.Split(",");
            s_userid = int.Parse(values[0].Remove(0,3));
            UserId = values[0];
            Name = values[1];
            Age = int.Parse(values[2]);
            City = values[3];
            PhoneNumber = int.Parse(values[4]);
            Balance = double.Parse(values[5]);
        }

    }
}