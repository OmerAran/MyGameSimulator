using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
{
    class GameManager:IGameManager
    {
        
        public void Add(Game game)
        {
            Console.WriteLine("Game ADDED!!!");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game UPDATED!!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game DELETED!");
        }
    }
}
