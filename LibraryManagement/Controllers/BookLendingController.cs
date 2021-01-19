using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/lending")]
    [ApiController]
    public class BookLendingController : ControllerBase
    {
        [Route("books/all")]
        public IEnumerable<Book> GetAllLentBooks()
        {
            return new List<Book>();
        }

        [Route("visitor/{visitorId}/books")]
        public IEnumerable<Book> GetBooksLentByVisitor(int visitorId)
        {
            return new List<Book>();
        }

        [Route("visitor/{visitorId}/book/{bookId}/lend")]
        public BorrowDetails PostLendNewBook(int visitorId, int bookId)
        {
            return new BorrowDetails();
        }

        [Route("visitor/{visitorId}/book/{bookId}/return")]
        public BorrowDetails PostReturnLentBook(int visitorId, int bookId)
        {
            return new BorrowDetails();
        }
    }
}
