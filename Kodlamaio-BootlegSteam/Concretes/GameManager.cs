using Kodlamaio_BootlegSteam.Abstracts;
using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Concretes
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kayıt İşlemleri");
        }

        public void Add(List<Game> games)
        {
            Console.WriteLine("Toplu Oyun Kaydı İşlemleri");
            foreach (Game game in games)
            {
                Add(game);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Update İşlemleri");
        }
        public void Update(List<Game> games)
        {
            Console.WriteLine("Toplu Oyun Update İşlemleri");
            foreach (Game game in games)
            {
                Update(game);
            }
        }

    }
}
