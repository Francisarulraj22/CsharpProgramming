using System;
using System.Collections.Generic;
namespace OnlineGroceryApplication;

    public delegate void EventManager();
public static class Operations
{
    public static List<CustomerDetails>customerList=new List<CustomerDetails>();
    public static List<ProductDetails>productList=new List<ProductDetails>();
    public static List<OrderDetails>orderList=new List<OrderDetails>();
    public static List <BookingDetails>bookingList=new List<BookingDetails>();    
    public static CustomerDetails currentcustomer;
    public static event EventManager eventlink=null;

public static void Subscribe()
{
    eventlink += new EventManager(Files.Create);
    eventlink += new EventManager(Files.ReadFile);
    eventlink += new EventManager(Operations.MainMenu);
    eventlink += new EventManager(Files.WriteFile);
}
    public static void StartEvent()
    {
        Subscribe();
        eventlink();
    }
    
    public static void MainMenu()
    {
        AddDefaultdata();
        System.Console.WriteLine("Do you want to continue: Yes/No");
        string choice=Console.ReadLine().ToLower();
        
        do
        {
         System.Console.WriteLine("\n<<<<<<<<<<<--------------  Main Menu --------------->>>>>>>>>>\n\n\t\t1. Customer Registration\n\t\t2. Customer Login\n\t\t3. Exit");
         int option=int.Parse(Console.ReadLine());
         switch (option)
         {
            case 1:
            {
                CustomerRegistration();
                break;
            }
            case 2:
            {
                CustomerLogin();
                break; 
            }  
            case 3:
            {
                System.Console.WriteLine("\n <------<<< Exiting Main Menu <-------<<<");
                choice="no";
                break;
            }
            default:
                break;
        }
        } while (choice=="yes");
      
         

    
    }
    public static void CustomerRegistration()
    {

        //string name, string fatherName,double WalletBalance, Gender gender, long mobileNumber, DateTime dateOfBirth, string mailID):base( name, fatherName, gender, mobileNumber, dateOfBirth, mailID
        System.Console.WriteLine("Enter Your Name :");
        string name=Console.ReadLine();
         
        System.Console.WriteLine("Enter Father Name :");
        string fatherName=Console.ReadLine();

        System.Console.WriteLine("Enter Your Gender :");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        double WalletBalance=currentcustomer.WalletBalance;

        System.Console.WriteLine("Enter Your Mobile Number :");
        long mobileNumber=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Date Of Birth in dd/MM/yyyy format :");
        DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter Your Mail Id");
        string mailID=Console.ReadLine();
        
        CustomerDetails customer=new CustomerDetails(name,fatherName,WalletBalance,gender,mobileNumber,dateOfBirth,mailID); 
        customerList.Add(customer);
        
        System.Console.WriteLine($"Register Successfull!!!\t Your CustomerId :{customer.CustomerID}");
    }
     public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter Your Customer ID:");
        string LoginId=Console.ReadLine().ToUpper();
        int flag=1;
        foreach (CustomerDetails customer in customerList)
        {
            if(LoginId==customer.CustomerID)
            {
            System.Console.WriteLine("Login Succesfull!!!");
            currentcustomer=customer; 
            SubMenu();

            flag=0;            
            }
                   
        }
        
        if(flag== 1)
        {
            System.Console.WriteLine("Invalid Customer ID");
        }
    }
    public static void SubMenu()
    {
        
        
        string choiceforsubmenu="yes";
        do
        {
            System.Console.WriteLine("\n<<<<<<<<<-------------- SubMenu -------------->>>>>>>>\n\n\t\t1. Show Customer Detail\n\t\t2. Show Product Details\n\t\t3. Wallet Recharge\n\t\t4. Take Order\n\t\t5. Modify Order\n\t\t6. Cancel Order\n\t\t7. Exit");
            int option=int.Parse(Console.ReadLine());
            switch (option)
        {
            case 1:
            {
                System.Console.WriteLine("Show Customer Detail");
                currentcustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Show Product Details");
                ShowProductDetails();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wallet Recharge");
                currentcustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Take Order");
                TakeOrder();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Modify Order");
                ModifyOrder();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Cancel Order");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("\n <------<<< Exiting Sub Menu  <-----<<< ");
                choiceforsubmenu="no";
                break;
            }
               
            default:
                break;
            
        } 

        
        }while (choiceforsubmenu=="yes"); 
    }
    public static void ShowProductDetails()
    {
        System.Console.WriteLine("<<<<<<<<<<<----------- Product Details ----------->>>>>>>>>>>\n");
        foreach (ProductDetails product in productList)
        {
            System.Console.WriteLine($"{product.ProductID}\t{product.ProductName}\t{product.QuantityAvailable}\t{product.PricePerQuantity}");
        }
    }
    public static void TakeOrder()
    {
        //Show The detailed List
        //Select Product & Check for product
        // get the Quantity and Compare with Availablity
        // Calculate price and compare with customer
        // take order and create obj and add in local list

        BookingDetails bookObject=new BookingDetails(currentcustomer.CustomerID,0,BookingStatus.Initiated);
        List<OrderDetails>tempOrderList=new List<OrderDetails>();
        ShowProductDetails();
        double TotalPrice=0;
        string choice="yes";
        int flag=1;
        do
        {
              
            System.Console.WriteLine("Choose The ProductID : ");
            string productID=Console.ReadLine();
           
            foreach (ProductDetails product in productList)
            {
            if(productID==product.ProductID)
            {
                System.Console.WriteLine("Select Quantity :");
                int quantity=int.Parse(Console.ReadLine());

                if(quantity<=product.QuantityAvailable)
                {
                    double totalPrice=quantity*product.PricePerQuantity;
                    product.QuantityAvailable-=quantity;
                    OrderDetails orderObject=new OrderDetails(product.ProductID,bookObject.BookingID,quantity,totalPrice);
                    tempOrderList.Add(orderObject); 
                    System.Console.WriteLine("\nYour Order Stored in Cart...");
                    flag=0;
                }
                else
                {
                    System.Console.WriteLine("\nQuantity Unavailable...");
                    break;
                }
            }
            
        } 
        if(flag==1)
            {
                System.Console.WriteLine("\nProduct Id Not Valid");
                break;
            }  
         System.Console.WriteLine("Do You want to Add an Another Items? Yes/No");
         choice=Console.ReadLine().ToLower(); 
        
        }while (choice=="yes");

        foreach (OrderDetails temporders in tempOrderList)
        {
            TotalPrice+=temporders.PriceOfOrder;
            
        }
        System.Console.WriteLine("Do You Want to proceed? Yes or No");
        string confirm=Console.ReadLine().ToLower();
        while(confirm=="yes")
        {
         if(confirm=="yes")
        {
            if(currentcustomer.WalletBalance>=TotalPrice)
                {
                    currentcustomer.WalletBalance-=TotalPrice;
                    bookObject.BookingStatus=BookingStatus.Booked; 
                    System.Console.WriteLine("Booking Successfull");
                    bookingList.Add(bookObject);
                    confirm="no";
                }
            else
                {
                    System.Console.WriteLine("Not having enough Amount--- Rs. "+currentcustomer.WalletBalance);
                    currentcustomer.WalletRecharge();
                    break;
                }  
                 }
        else
        {
            System.Console.WriteLine("Cart Removued Successfully");
        }
        }
    }
    public static void ModifyOrder()
    {
        System.Console.WriteLine("ModifyOrder Selected...");
    }
    public static void CancelOrder()
    {
        
        System.Console.WriteLine("Enter your OrderId to Cancel :");
        string cancel=Console.ReadLine().ToUpper();
        foreach (BookingDetails bookings in bookingList)
        {
            if(bookings.BookingID==cancel&&bookings.BookingStatus.Equals(BookingStatus.Booked))
            {
                bookings.BookingStatus=BookingStatus.Cancelled;
                currentcustomer.WalletBalance+=bookings.TotalPrice;           
            }   
        }
        System.Console.WriteLine("Order Cancelled Succefully");
    }
    public static void AddDefaultdata()
    {
        CustomerDetails sample = new CustomerDetails("Ravi","Ettaparajan",10000,Gender.Male,98587986,new DateTime(1999,11,11),"ravi@gmail.com");
        customerList.Add(sample);
        
        CustomerDetails sample4 = new CustomerDetails("Baskaran","Sthurajan",2000,Gender.Male,98768734,new DateTime(1999,11,11),"baskaran@gmail.com");
        customerList.Add(sample4);

        OrderDetails sample2 = new OrderDetails("BID3001","PID101",2,80);
        orderList.Add(sample2);
        OrderDetails sample3 = new OrderDetails("BID3002","PID101",2,100);
        orderList.Add(sample3);
        
        ProductDetails sample1 = new ProductDetails("Sugar",20,40);
        productList.Add(sample1);
        ProductDetails sample5 = new ProductDetails("rice",100,50);
        productList.Add(sample5);
        //Booking Datils Data

        BookingDetails sample6 = new BookingDetails("CID3001",220,BookingStatus.Booked);
        bookingList.Add(sample6);
        BookingDetails sample7 = new BookingDetails("CID3002",400,BookingStatus.Booked); 
        bookingList.Add(sample7);
    }
} 
    
