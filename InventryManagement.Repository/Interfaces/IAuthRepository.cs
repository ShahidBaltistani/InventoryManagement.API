﻿using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventryManagement.Repository.Interfaces
{
   public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}
