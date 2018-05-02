using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Controller
{
    public interface IUserController
    {
        User GetUser(int Id);

        List<User> GetAllUsers();

        void Add(User user);
        
    }
}
