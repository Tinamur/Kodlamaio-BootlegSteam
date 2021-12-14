using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Abstracts
{
    interface IOfferService
    {
        void NewOffer(Offer offer, List<Game> games);
        void NewOffer(Offer offer, Game game);
        void RemoveOffer(Offer offer);
        void UpdateOffer(Offer offer, List<Game> games);
        void UpdateOffer(Offer offer, Game game);
    }
}
