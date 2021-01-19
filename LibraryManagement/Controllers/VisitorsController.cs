using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/visitor")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        // GET: api/visitor/all
        [Route("all")]
        public IEnumerable<Visitor> GetVisitors()
        {
            return new List<Visitor>();
        }

        // GET: api/visitor/5
        [Route("{id}")]
        public Visitor GetVisitor(int id)
        {
            return new Visitor();
        }

        // POST: api/visitor/add
        [Route("add")]
        public Visitor PostVisitor([FromBody] Visitor visitor)
        {
            return new Visitor();
        }

        // PUT: api/visitor/5/update
        [Route("{id}/update")]
        public Visitor PutVisitor(int id, [FromBody] Visitor visitor)
        {
            return new Visitor();
        }

        // DELETE: api/visitor/5/delete
        [Route("{id}/delete")]
        public bool DeleteVisitor(int id)
        {
            return true;
        }
    }
}
