using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class BookInfo:DepartmentDetails
    {
        // Class BookInfo: Inherit DepartmentDetails
        // Properties: BookID, BookName, AuthorName, Price
        private static int s_bookid=1000;
        public string  BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public BookInfo(string departmentname,string degree,string bookName,string authorName,int price):base( departmentname, degree)
        {
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
            
        }
        public void ShowBook()
        {
            ShowDetail();
            System.Console.WriteLine($"BookName:{BookName}\nAuthorName:{AuthorName}\n:Price{Price}");
        }

    }
}