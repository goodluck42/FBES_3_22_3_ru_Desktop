using System;
using System.Collections.Generic;
using FormsNMVP.Models;

namespace FormsNMVP.Services
{
    public interface IUserStorage
    {
        bool Add(User user);
        bool RemoveByLogin(string login);
        User GetUserById(int id);
        User GetUserByLogin(string login);

        IReadOnlyList<User> GetAll();
    }
}