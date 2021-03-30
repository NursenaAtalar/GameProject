using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "is added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "is deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "is updated ");
        }
    }
}
