using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
{
    class PlayerCheckManager: IPlayerCheckManager
    {
        public bool CheckRealPlayer(Player player)
        {
            Console.WriteLine("Player CHECKED!");
            return true;
        }
    }
}
