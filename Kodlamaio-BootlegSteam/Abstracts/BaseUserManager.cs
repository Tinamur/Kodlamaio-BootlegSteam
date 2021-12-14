using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Abstracts
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("BaseCustomerAdd Kodları");
        }

        //Elimde Useri Kayıt tuttuğum bir Yer Yok
        // O yüzden boş refereans Göndereceğim
        public virtual List<User> GetUsers()
        {
            Console.WriteLine("BaseCustomerGetUsers Kodları");
            return new List<User>();
        }

        public virtual void Remove(User user)
        {
            Console.WriteLine("BaseCustomerRemove Kodları");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("BaseCustomerUpdate Kodları");
        }
    }
}
