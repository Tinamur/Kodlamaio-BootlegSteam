using Kodlamaio_BootlegSteam.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Entities
{
    public class User:IEntity
    {
        public User()
        {
            OwnedGames = new List<Game>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Wallet { get; set; }
        public List<Game> OwnedGames { get; set; }
    }
}
