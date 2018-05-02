using Interfaces.Controller;
using Microsoft.AspNetCore.Mvc;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotations.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private IAuthorController _ctrl;
        public AuthorController(IAuthorController ctrl)
        {
            _ctrl = ctrl;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _ctrl.GetAllAuthors();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _ctrl.GetAuthor(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Author value)
        {
            _ctrl.Add(value);
        }
    }
}
