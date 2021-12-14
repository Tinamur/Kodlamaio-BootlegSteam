using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Concretes
{
    class SaleManager : ISaleService
    {
        public void TryToSell(User user, Game game)
        {
            if (user.Wallet>=game.GetFinalPrice())
            {
                user.Wallet -= game.GetFinalPrice();
                user.OwnedGames.Add(game);
                Console.WriteLine("Tebrikler başarılı bir şekilde "
                    + game.Name +" satın alındı!" );
            }
            else
            {
                Console.WriteLine("Bakiyeniz Yeterli Değil");
            }


        }
    }
}
