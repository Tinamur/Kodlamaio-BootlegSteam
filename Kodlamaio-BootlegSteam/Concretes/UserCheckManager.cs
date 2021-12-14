using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Concretes
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}
