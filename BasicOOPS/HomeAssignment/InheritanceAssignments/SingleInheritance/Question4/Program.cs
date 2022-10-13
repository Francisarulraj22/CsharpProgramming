using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
            //Parent class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< DepartmentDetails >>>>>>>>>>>>>");
            DepartmentDetails person=new DepartmentDetails("CSE","BE");
            person.ShowDetail();


            //Child class object
            System.Console.WriteLine("<<<<<<<<<<<<<<< BookInfo >>>>>>>>>>>>>");
            BookInfo book=new BookInfo("CSE","BE","C#","Author",1999);
            book.ShowBook();

        }
            
    }
