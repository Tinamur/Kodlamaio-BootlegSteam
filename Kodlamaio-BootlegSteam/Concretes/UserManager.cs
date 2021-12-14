using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Concretes
{
    public class UserManager : BaseUserManager
    {
        private IUserCheckService _userCheckService;
        public UserManager(IUserCheckService usercheckService)
        {
            _userCheckService = usercheckService;
        }
        public override void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine(user.FirstName+" - Başarı ile Kayıt Oldu");
                base.Add(user);
            }
            else
            {
                Console.WriteLine("Kayıt İşlemi Başarısız");
            }

        }
    }
}
