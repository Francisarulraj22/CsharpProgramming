using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Booking
    {
        private static int s_bookid=100;
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string  AuthorName { get; set; }
        public int Count { get; set; }
        public Booking(string bookid,string bookName,string authorName,int count)
        {
            s_bookid++;
            BookId="BID"+s_bookid;
            BookName=bookName;
            AuthorName=authorName;
            Count=count;          
        }

        
    }
}