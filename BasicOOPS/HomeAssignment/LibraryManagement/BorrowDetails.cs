using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Status{Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowid=301;
        public string BorrowId { get; set; }
        public string BookId { get;}
        public string UserId { get; }
        public DateTime BorrowDate { get; set; }
        public Status Status { get; set; }

        public BorrowDetails(string borrowId,string bookid,string UserId,DateTime borrowdate,Status status)
        {
            s_borrowid++;
            BorrowId="LB"+s_borrowid;
            BorrowDate=borrowdate;
            Status=status;
        }

    }
}