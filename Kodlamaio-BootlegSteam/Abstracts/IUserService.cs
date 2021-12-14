using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Abstracts
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Remove(User user);
        List<User> GetUsers();

    }
}
