using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Concretes
{
    class OfferManager : IOfferService
    {
        public void NewOffer(Offer offer, List<Game> games)
        {
            Console.WriteLine("Kampanya Eklendi");
            foreach (Game game in games)
            {
                offer.GamesInOffer.Add(game);
                game.SetDiscount(offer.Discount);
            }
        }

        public void NewOffer(Offer offer, Game game)
        {
            offer.GamesInOffer.Add(game);
            game.SetDiscount(offer.Discount);
        }

        public void RemoveOffer(Offer offer)
        {
            Console.WriteLine("Kampanya Silindi");
            foreach (Game game in offer.GamesInOffer)
            {
                game.SetDiscount(0);
            }
        }

        public void UpdateOffer(Offer offer, List<Game> games)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void UpdateOffer(Offer offer, Game game)
        {
            offer.GamesInOffer.Add(game);
            game.SetDiscount(offer.Discount);
        }
    }
}
