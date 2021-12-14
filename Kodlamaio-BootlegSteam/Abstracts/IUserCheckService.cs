using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Abstracts
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
