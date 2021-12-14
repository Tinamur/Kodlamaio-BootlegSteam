using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Adapters;
using Kodlamaio_BootlegSteam.Concretes;
using Kodlamaio_BootlegSteam.Entities;
using System;

namespace Kodlamaio_BootlegSteam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boş User
            User user1 = new User();

            User user2 = new User
            {
                Id = 1,
                FirstName = "User_1",
                LastName = "User_1_LastName",
                NationalityId = "123456",
                DateOfBirth = new DateTime(1990,1,1),
                Wallet = 200
            };
            BaseUserManager userManager = new UserManager(new MernisServiceSimulation());
            //User Add Simulation
            userManager.Add(user1);
            userManager.Add(user2);
            Console.WriteLine("----------------");
            //Game And Offer Simulation
            Game game1 = new Game { Name = "Game_1", BasePrice = 20 };
            Offer offer = new Offer { Discount = 15 };
            IOfferService offerManager = new OfferManager();
            offerManager.NewOffer(offer, game1);

            Console.WriteLine(game1.GetDiscount());
            Console.WriteLine(game1.GetFinalPrice());

            ISaleService saleService = new SaleManager();
            saleService.TryToSell(user2, game1);
            user2.OwnedGames.ForEach(game => Console.WriteLine(game.Name));

        }
    }
}
