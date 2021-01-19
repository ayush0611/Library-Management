using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class BorrowDetails
    {
        public int Id { get; set; }
        public int BookBorrowed { get; set; }
        public int BorrowedBy { get; set; }
        public DateTime BorrowedOn { get; set; }
        public bool IsReturned { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}
