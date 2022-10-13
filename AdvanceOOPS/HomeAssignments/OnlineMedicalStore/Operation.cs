using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class Operation
    {
    static string Currentuser=null;
    static string Currentmedicine=null;
    static string Currentdetails=null;
    public static List<UserDetails>userList=new List<UserDetails>();
    public static List<MedicineDetails>medicaldetailList=new List<MedicineDetails>();
    public static List<OrderDetails>orderList=new List<OrderDetails>();


    
    public static void  Mainmenu()
    {
        
           
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option:\n1.User Registration\n2.Login\n3.Order History\n4.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                    {   System.Console.WriteLine("User registration:");
                        Register();
                        break;
                    }
                    case 2:
                    {   System.Console.WriteLine("User Login:");
                        Login();
                        break;
                    }
                    case 3:
                    {   System.Console.WriteLine("Order History:");
                        
                        break;
                    }
                    case 4:
                    {   System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }     
                    default:
                        break;
                }
            }while ( choice=="yes");   
    }
    
        public static void Register()
        {
            System.Console.WriteLine("Enter Your Name :");
            string Name=Console.ReadLine();

            System.Console.WriteLine("Enter Your Age :");
            int Age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your City :");
            string City=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Phone Number :");
            long PhoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Balance :");
            double Balance=0;
            UserDetails userdetail=new UserDetails(Name,Age,City,PhoneNumber,Balance);
            userList.Add(userdetail);

            System.Console.WriteLine($"Your UserId:{userdetail.UserId}");
        }

    public static void Login()
    {
        System.Console.WriteLine("Enter Your UserId:");
        string Usernumber=Console.ReadLine();
        
        foreach (UserDetails user in userList )
        {
            if(Usernumber==user.UserId)
            {
                System.Console.WriteLine("--------->>>>> Login Succesful <<<<<<----------");
                SubMenu();
                Currentuser=user.UserId;
            }
        }
    }
    public static void SubMenu()
    {
         string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option:\n1.Show Medicine List\n2.Purcharse Medicine\n3.Cancel Purchase\n4.Show Purchase History\n5.Recharge\n6.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                    {   System.Console.WriteLine("Show Medicine List :");

                        break;
                    }
                    case 2:
                    {   System.Console.WriteLine("Purcharse Medicine :");
                        
                        break;
                    }
                    case 3:
                    {   System.Console.WriteLine("Cancel Purchase :");
                        
                        break;
                    }
                    case 4:
                    {   System.Console.WriteLine("Show Purchase History :");
                        
                        break;
                    }     
                    case 5:
                    {   System.Console.WriteLine("Recharge :");
                        
                        break;
                    } 
                    case 6:
                    {   System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    } 
                    default:
                        break;
                }
            }while ( choice=="yes"); 

    }
    public static void ShowMedicineList()
    {
        foreach (MedicineDetails medicine in medicaldetailList)
        {
            System.Console.WriteLine($"Medicine Id : {medicine.MedicineId} Medicine Name : {medicine.MedicineName} Available Count : {medicine.AvailableCount} Price : {medicine.Price} Date Of Expiry : {medicine.DateOfExpire}" );
        }
    }

    public static void PurchaseMedicine()
    {
        foreach (MedicineDetails medicine in medicaldetailList)
        {
            System.Console.WriteLine($"Medicine Id : {medicine.MedicineId} Medicine Name : {medicine.MedicineName} Available Count : {medicine.AvailableCount} Price : {medicine.Price} Date Of Expiry : {medicine.DateOfExpire}" );
        }
        System.Console.WriteLine("Choose the Medicine Id You want :");
        string tempmedicine=Console.ReadLine();
        
        System.Console.WriteLine("Number of Count :");
        int tempcount=int.Parse(Console.ReadLine());
        foreach (MedicineDetails tempcheck in medicaldetailList)
        {
            if(tempcheck.MedicineId==tempmedicine && tempcount==tempcheck.AvailableCount)
            {
                System.Console.WriteLine("Medicine Available !!!");
            }
            else
            {
                System.Console.WriteLine("Medicine Unavailable...");
            }
        }

        



    }
    }
}