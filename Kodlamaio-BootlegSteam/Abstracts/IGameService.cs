using Kodlamaio_BootlegSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Abstracts
{
    interface IGameService
    {
        void Add(Game game);
        void Add(List<Game> games);
        void Update(Game game);
        void Update(List<Game> games);
    }
}
