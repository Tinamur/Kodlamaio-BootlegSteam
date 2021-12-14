using Kodlamaio_BootlegSteam.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Entities
{
    public class Offer:IOffer
    {
        public Offer()
        {
            GamesInOffer = new List<Game>();
        }
        public int Id { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public List<Game> GamesInOffer { get; set; }

    }
}
