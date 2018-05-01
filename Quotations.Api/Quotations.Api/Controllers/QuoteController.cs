using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Controller;
using Microsoft.AspNetCore.Mvc;
using ServiceModel;

namespace Quotations.Api.Controllers
{
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        public IQuoteController controller { get; set; }
        // GET api/values
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return controller.GetAllQuotes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Quote Get(int id)
        {
            return controller.GetQuote(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Quote value)
        {
            controller.Add(value);
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
