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
    public class UserController : Controller
    {
        private IUserController _ctrl;
        public UserController(IUserController ctrl)
        {
            _ctrl = ctrl;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _ctrl.GetAllUsers();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _ctrl.GetUser(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _ctrl.Add(value);
        }

    }
}
