using Interfaces.Controller;
using Interfaces.Repository;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    public class UserController : IUserController
    {
        private IQuoteRepository _sqlQuotes { get; set; }

        public UserController(IQuoteRepository sqlQuotes)
        {
            _sqlQuotes = sqlQuotes;
        }
        public User GetUser(int Id)
        {
            return _sqlQuotes.GetUser(Id);
        }
        public List<User> GetAllUsers()
        {
            return _sqlQuotes.GetAllUsers();
        }
        public void Add(User user)
        {
            _sqlQuotes.Add(user);
        }
    }
}
