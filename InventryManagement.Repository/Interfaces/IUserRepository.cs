using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Repository.Interfaces
{
   public interface IUserRepository
    {
        User add(User model);
        User GetById(int id);
        List<User> GetAll();
        void Update(User model);
        int Delete(int id);
    }
}
