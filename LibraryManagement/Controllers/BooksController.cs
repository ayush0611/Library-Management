using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/book/all
        [Route("all")]
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>();
        }

        // GET: api/book/5
        [Route("{id}")]
        public Book GetBook(int id)
        {
            return new Book();
        }

        // POST: api/book/add
        [Route("add")]
        public Book PostBook([FromBody] Book book)
        {
            return new Book();
        }

        // PUT: api/book/5/update
        [Route("{id}/update")]
        public Book PutBook(int id, [FromBody] Book book)
        {
            return new Book();
        }

        // DELETE: api/book/5/delete
        [Route("{id}/delete")]
        public bool DeleteBook(int id)
        {
            return true;
        }
    }
}
