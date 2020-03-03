﻿using System;
using System.Threading.Tasks;
using Tinder2API.Models;

namespace Tinder2API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
