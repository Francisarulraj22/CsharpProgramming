using System;

namespace StudentDetails;

        class program
        {
            public static void Main(string[] args)
            {
                
                Console.WriteLine("Enter Student name:");
                String studentName=Console.ReadLine(); 
                Console.WriteLine("Enter Father's name:");
                String fatherName=Console.ReadLine();
                Console.WriteLine("Enter Gender:");
                String gender=Console.ReadLine(); 
                Console.WriteLine("Enter Mail Id:");
                String mailId=Console.ReadLine();
                Console.WriteLine("Enter Phone number:");
                Int64 num=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Age:");
                Int32 age=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Chemistry Mark:");
                Int32 che=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Physics Mark:");
                Int32 phy=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Maths Mark:");
                Int32 math=int.Parse(Console.ReadLine());
                //Average and percetage
                 int sum= che+math+phy;
                 float average=sum/3;
                 float percentage=sum/6;
                 Console.WriteLine("----------Student Details-----------");
                 Console.WriteLine($"Student Name:{studentName}");
                 Console.WriteLine($"Father's Name:{fatherName}");
                 Console.WriteLine($"Gender:{gender}");
                 Console.WriteLine($"Mail Id:{mailId}");
                 Console.WriteLine($"PhoneNo:{num}");
                 Console.WriteLine($"Mail Id:{age}");
                 Console.WriteLine($"Chemistry Mark:{che}");
                 Console.WriteLine($"Physics Mark:{phy}");
                 Console.WriteLine($"Maths Mark:{math}");
                 Console.WriteLine("Average:"+average);
                 Console.WriteLine("Percentage:"+percentage+"%");

        
                
                
                
                
            



            }
        }