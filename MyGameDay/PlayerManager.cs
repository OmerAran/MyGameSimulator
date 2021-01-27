using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
{
    class PlayerManager:IPlayerManager
    {

        public void Add(Player player)
        {
            Console.WriteLine("Player ADDED !!!");
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player UPDATED !!");
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player DELETED !");
        }

    }
}
